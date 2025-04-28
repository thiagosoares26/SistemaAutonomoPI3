using System.Text.RegularExpressions;
using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Common.Interfaces;
using AutoSystem_KingMe.Models.Constants;
using KingMeServer;

namespace AutoSystem_KingMe.Services.Game
{
    public class MatchGameService
    {
        private readonly string _matchId;

        private int lastHistoricHash;
        private Dictionary<string, string> lastCharacterPositions = new();

        public bool GameInited { get; set; }
        public PlayerOnGameEntity PlayerOnGame { get; private set; }
        public List<PlayerEntity> Players { get; private set; }
        public int? NoQuantity { get; private set; }

        public MatchGameService(string matchId, PlayerOnGameEntity playerOnGame)
        {
            _matchId = matchId;
            PlayerOnGame = playerOnGame;
            Players = GetPlayersOnMatch();
        }

        public string GetPlayerName()
        {
            var player = Players.FirstOrDefault(x => x.Id == PlayerOnGame.Id);
            return player.Name;
        }

        public PlayerEntity? StartMatch()
        {
            var gameResponse = MatchService.StartGame(PlayerOnGame);
            return gameResponse.OnSuccess(playerTurnId =>
            {
                Players = GetPlayersOnMatch();
                var playerTurn = Players.FirstOrDefault(x => x.Id == playerTurnId);

                return playerTurn;
            });
        }

        public List<PlayerEntity> GetPlayersOnMatch() =>
            PlayerService.GetPlayers(_matchId).OnSuccess(pl => pl) ?? new();


        public string? GetFavorites()
        {
            int playerId = int.Parse(PlayerOnGame.Id);
            var gameResponse = PlayerService.GetFavorites(playerId, PlayerOnGame.Password);

            return gameResponse.OnSuccess(x => x);
        }

        public CheckTimeEntity? CheckTime()
        {
            var gameResponse = MatchService.CheckTime(_matchId);
            return gameResponse.OnSuccess(check =>
            {
                var playerTurn = Players.FirstOrDefault(p => p.Id == check.PlayerId );
                check.PlayerTurn = playerTurn;

                return check;
            });
        }

        public bool IsMyTime(out CheckTimeEntity? time)
        {
            time = CheckTime();
            if (time is null) return false;

            return time.PlayerId == PlayerOnGame.Id;
        }
       
        public void PositionCharacter(string sector, string letter)
        {
            MatchService.PutCharacter(PlayerOnGame, sector, letter)
                .OnSuccess(x => x);
        }

        public void PromoteCharacter(string letter)
        {
            MatchService.PromotionCharacter(PlayerOnGame, letter).
                OnSuccess(x => x);
        }

        public Dictionary<string, string> GetCharacterPositions(out bool isPositionsChanged)
        {
            var gameResponse = MatchService.GetHistoryGame(int.Parse(_matchId), false, true);            
            bool positionsChanged = false;

            var positions = gameResponse.OnSuccess(output =>
            {
                // Caso as posições não tenham sido atualizadas, não é necessário remo
                if (lastHistoricHash == output.GetHashCode()) return lastCharacterPositions;
                var characterPositions = new Dictionary<string, string>();

                var historyResponse = output.HandleReponse<HistoryEntity>();
                historyResponse.Entities.Reverse();

                var charactersNotSelecteds = CharacterConst.Names.Select(x => x.Key).ToList();
                string votingInCharacter = string.Empty;
                foreach (var line in historyResponse.Entities)
                {
                    switch (line.MatchPhase)
                    {
                        case "S": // Seleção
                            characterPositions.Add(line.Character, line.Sector);
                            charactersNotSelecteds.Remove(line.Character);
                            
                            break;

                        case "P": // Promoção
                            characterPositions[line.Character] = line.Sector;
                            if (line.Sector == "10") votingInCharacter = line.Character;

                            break;

                        case "V": // Votação
                            if (line.Voting == "N" && characterPositions.ContainsKey(votingInCharacter))
                                characterPositions[votingInCharacter] = "-1";
                            
                            break;
                        default:
                            break;
                    }

                    // Adicionando a posição do ultimo Personagem que não foi selecionado
                    if (charactersNotSelecteds.Count == 1)
                    {
                        var character = charactersNotSelecteds.FirstOrDefault();

                        characterPositions.Add(character, "0");
                        charactersNotSelecteds.Remove(character);
                    }
                }

                positionsChanged = true;
                lastCharacterPositions = characterPositions;
                return characterPositions;
            }) ?? new();

            isPositionsChanged = positionsChanged;
            return positions;
        }

        public IRawGameResponse Voting(string voting)
        {
            var gameResponse = MatchService.Voting(PlayerOnGame, voting, NoQuantity.GetValueOrDefault());
            gameResponse.OnSuccess(x =>
            {
                if (voting == "S") NoQuantity--;
            });

            return gameResponse;
        }

        public void ResetCharacterPositions()
        {
            lastCharacterPositions = new Dictionary<string, string>();
            lastHistoricHash = 0;
        }

        public PlayerEntity? GetPlayerWinner()
        {
            var gameResponse = PlayerService.GetPlayers(_matchId);

            return gameResponse.OnSuccess(players =>
            {
                int maxScore = players.Max(p => int.Parse(p.Score));

                return players.FirstOrDefault(p => int.Parse(p.Score) == maxScore);
            });
        }




        public void DefineNoQuantity()
        {
            if (Players != null && NoQuantity is null)
            {
                if (Players.Count == 3)
                {
                    NoQuantity = 4;
                }
                else if (Players.Count == 4)
                {
                    NoQuantity = 3;
                }
                else if (Players.Count >= 5)
                {
                    NoQuantity = 2;
                }
            }
        }

    }
}
