using AutoSystem_KingMe.Controller;
using AutoSystem_KingMe.Forms;
using AutoSystem_KingMe.Models.Constants;
using AutoSystem_KingMe.Services.Game;
using KingMeServer;
using System.Reactive.Linq;
using System.Text.RegularExpressions;

namespace AutoSystem_KingMe
{
	public partial class LobbyForm : Form
	{
		private readonly LobbyGameService _lobbyService;
		private const string GROUP_NAME = "Arqueiros de Azincourt";

		public LobbyForm()
		{
			_lobbyService = new LobbyGameService();

			InitializeComponent();
			lbVersion.Text = $"{lbVersion.Text} {Jogo.versao}";
			cboMatchsStatus.SelectedIndex = 0;
		}

		private void btnGetMatchs_Click(object sender, EventArgs e)
		{
			lboMatches.Items.Clear();

			string? statusSelected = cboMatchsStatus.SelectedItem?.ToString()?.Substring(0, 1);
			_lobbyService.GetMatches(statusSelected)
				.ForEach(match => lboMatches.Items.Add(match));
		}

		private void btnCreateMatch_Click(object sender, EventArgs e)
		{
			lblCreationMatchResponse.Text = string.Empty;
			string name = txtBox_nomePartida.Text;
			string password = txtBox_senhaPartida.Text;

			string? matchId = _lobbyService.CreateMatch(name, password, GROUP_NAME);
			if (!string.IsNullOrWhiteSpace(matchId))
				lblCreationMatchResponse.Text = $"ID da Partida: {matchId}";
		}

		private void btnListPlayers_Click(object sender, EventArgs e)
		{
			lboPlayers.Items.Clear();
			string matchId = txtBox_idPartida.Text;

			_lobbyService.GetPlayers(matchId)
				.ForEach(player => lboPlayers.Items.Add(player));
		}

		private void btnEnterMatch_Click(object sender, EventArgs e)
		{
			lblIdPlayer.Text = string.Empty;
			lblPasswordPlayer.Text = string.Empty;

			string matchId = txtBox_IdMatch.Text;
			string namePlayer = txtBox_PlayerName.Text;
			string passwordMatch = txtBox_PasswordMatch.Text;

			_lobbyService.EnterOnMatch(matchId, namePlayer, passwordMatch, false);
		}

		private void btnPartidaAutomacao_Click(object sender, EventArgs e)
		{

			string matchId = txtBox_IdMatch.Text;
			string namePlayer = txtBox_PlayerName.Text;
			string passwordMatch = txtBox_PasswordMatch.Text;

			var automationService = _lobbyService.EnterOnMatch(matchId, namePlayer, passwordMatch, true);
			if (automationService is null) return;

			new AutomationController(automationService);

			//string password = new Random().Next(1_000, 9_999).ToString();
			//string matchName = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 19);

			//string? matchId = _lobbyService.CreateMatch(matchName, password, GROUP_NAME);
			//if (string.IsNullOrWhiteSpace(matchId)) return;

			//var matchServiceKamikaze = _lobbyService.EnterOnMatch(matchId, "Kamikaze", password, false);
			//var matchServicePracinha = _lobbyService.EnterOnMatch(matchId, "Pracinha", password, false);

			//if (matchServiceKamikaze is null || matchServicePracinha is null) return;

			//matchServiceKamikaze.StartMatch();
			//var persons = CharacterConst.Names.Select(x => x.Key).ToList();

			//var services = new List<MatchGameService>() { matchServiceKamikaze, matchServicePracinha };

			//int setor = 4;
			//for (int i = 0; i < persons.Count; i++)
			//{
			//    var person = persons[i];
			//    var time = matchServiceKamikaze.CheckTime();

			//    var player = services.FirstOrDefault(x => x.PlayerOnGame.Id == time.PlayerId);
			//    player.PositionCharacter(setor.ToString(), person);
			//    if ((i + 1) % 4 == 1) setor--;
			//}

		}

		private void LobbyForm_Load(object sender, EventArgs e)
		{

		}
	}
}
