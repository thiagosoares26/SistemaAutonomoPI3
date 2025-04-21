using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Models.Common.Interfaces;
using KingMeServer;

namespace AutoSystem_KingMe.Services
{
    public static class MatchService
    {
		private static Dictionary<string, string> matchStatuses = new Dictionary<string, string>();

		public static IGameResponse<MatchEntity> GetMatches(string? status = "T") =>
            Jogo.ListarPartidas(status)
                .HandleReponse<MatchEntity>();

        public static IRawGameResponse CreateMatch(string nameMatch, string passwordMatch, string nameGroup) =>
            Jogo.CriarPartida(nameMatch, passwordMatch, nameGroup)
				.HandleRawResponse();

        public static IGameResponse<PlayerOnGameEntity> EnterMatch(string strIdMatch, string playerName, string passwordMatch)
        {
            if (!int.TryParse(strIdMatch, out int idMatch))
                return new GameResponse<PlayerOnGameEntity>() { ErrorMessage = "ID da partida está incorreto." };

            string gameResponse = Jogo.Entrar(idMatch, playerName, passwordMatch);
            return gameResponse.HandleReponse<PlayerOnGameEntity>();
        }

		public static IRawGameResponse StartGame(PlayerOnGameEntity player) =>
			Jogo.Iniciar(int.Parse(player.Id), player.Password)
			    .HandleRawResponse();

		public static IRawGameResponse Voting(PlayerOnGameEntity player, string voting, int noQuantity)
        {
            if (voting == "N" && noQuantity <= 0) return new GameResponse<PlayerOnGameEntity>() { ErrorMessage = "Todos seus \"Nãos\" já foram utilizados." };

            return Jogo.Votar(int.Parse(player.Id), player.Password, voting)
                .HandleRawResponse();
        }

		public static IRawGameResponse GetHistoryGame(int matchId, bool formatted, bool completed) =>
            Jogo.ConsultarHistorico(matchId, formatted, completed)
                .HandleRawResponse(throwError: false);

        public static IGameResponse<SectorCharacterEntity> PutCharacter(PlayerOnGameEntity player, string sector, string character) =>
            Jogo.ColocarPersonagem(int.Parse(player.Id), player.Password, int.Parse(sector), character)
				.HandleReponse<SectorCharacterEntity>();

        public static IOneGameResponse<CheckTimeEntity> CheckTime(string idMatch) =>
            Jogo.VerificarVez(int.Parse(idMatch))
                .HandleOneResponse<CheckTimeEntity>(throwError: false);

		public static IGameResponse<SectorCharacterEntity> PromotionCharacter(PlayerOnGameEntity player, string character) =>
			Jogo.Promover(int.Parse(player.Id), player.Password, character)
				.HandleReponse<SectorCharacterEntity>();
		
    }
}
