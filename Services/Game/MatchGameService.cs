using AutoSystem_KingMe.Models;
using KingMeServer;

namespace AutoSystem_KingMe.Services.Game
{
    public class MatchGameService
    {
        private readonly string _matchId;
        private readonly PlayerOnGameEntity _playerOnGame;

        public List<CharacterEntity> Personagens { get; private set; }
        public List<PlayerEntity> Players { get; private set; }
        public List<CharacterEntity> CharactersOnTable { get; private set; }
        public bool GameStarted { get; private set; }
        public int? NoQuantity { get; private set; }

        public MatchGameService(string matchId, PlayerOnGameEntity playerOnGame)
        {
            _matchId = matchId;
            _playerOnGame = playerOnGame;
            Players = GetPlayersOnMatch();
        }

        public string GetPlayerName()
        {
            var player = Players.FirstOrDefault(x => x.Id == _playerOnGame.Id);
            return player.Name;
        }

        public PlayerEntity? StartMatch()
        {
            var gameResponse = MatchService.StartGame(_playerOnGame);
            return gameResponse.OnSuccess(playerTurnId =>
            {
                Players = GetPlayersOnMatch();
                var playerTurn = Players.FirstOrDefault(x => x.Id == playerTurnId);
                
                GameStarted = true;
                DefineNoQuantity();

                return playerTurn;
            });
        }

        public List<PlayerEntity> GetPlayersOnMatch() =>
            PlayerService.GetPlayers(_matchId).OnSuccess(pl => pl) ?? new();


        public string? GetFavorites()
        {
            int playerId = int.Parse(_playerOnGame.Id);
            var gameResponse = PlayerService.GetFavorites(playerId, _playerOnGame.Password);

            return gameResponse.OnSuccess(x => x);
        }

        public CheckTimeEntity? CheckTime()
        {
            var gameResponse = MatchService.CheckTime(_matchId);
            return gameResponse.OnSuccess(check =>
            {
                var playerTurn = Players.FirstOrDefault(p => p.Id == check.PlayerId);
                check.PlayerTurn = playerTurn;

                return check;
            });
        }
       
        public void PositionCharacter(string sector, string letter)
        {
            var gameResponse = MatchService.PutCharacter(_playerOnGame, sector, letter);
            gameResponse.OnSuccess(chars => CharactersOnTable = chars);
        }

        public void PromoteCharacter(string letter)
        {
            var gameResponse = MatchService.PromotionCharacter(_playerOnGame, letter);
            gameResponse.OnSuccess(chars => CharactersOnTable = chars);
        }

        private void DefineNoQuantity()
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
