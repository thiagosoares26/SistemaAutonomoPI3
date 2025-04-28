using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Forms;

namespace AutoSystem_KingMe.Services.Game
{
    public class LobbyGameService
    {
        public List<MatchEntity> GetMatches(string? status = "T")
        {
            var gameResponse = MatchService.GetMatches(status);
            return gameResponse.OnSuccess(matches => matches) ?? new(); 
        }

        public string? CreateMatch(string nameMatch, string passwordMatch, string nameGroup)
        {
            var gameResponse = MatchService.CreateMatch(nameMatch, passwordMatch, nameGroup);
            return gameResponse.OnSuccess(x => x);
        }

        public List<PlayerEntity> GetPlayers(string matchId)
        {
            var gameResponse = PlayerService.GetPlayers(matchId);
            return gameResponse.OnSuccess(players => players) ?? new();
        }

        public MatchGameService? EnterOnMatch(string matchId, string playerName, string matchPassword, bool isAutomation)
        {
            var gameResponse = MatchService.EnterMatch(matchId, playerName, matchPassword);
            return gameResponse.OnSuccess(playerOnGame =>
            {
                var player = gameResponse.Entities.FirstOrDefault();
                var matchGameService = new MatchGameService(matchId, player);
                var matchForm = new MatchForm(matchGameService, isAutomation);
                matchForm.Show();

                return matchGameService;
            });

        }

    }
}
