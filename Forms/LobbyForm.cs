using AutoSystem_KingMe.Forms;
using AutoSystem_KingMe.Models.Constants;
using AutoSystem_KingMe.Services.Game;
using KingMeServer;

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
            lblWarningError.Text = string.Empty;
            lblIdPlayer.Text = string.Empty;
            lblPasswordPlayer.Text = string.Empty;

            string strIdMatch = txtBox_IdMatch.Text;
            string namePlayer = txtBox_PlayerName.Text;
            string passwordMatch = txtBox_PasswordMatch.Text;

            _lobbyService.EnterOnMatch(strIdMatch, namePlayer, passwordMatch);
        }

        private void btnPartidaTeste_Click(object sender, EventArgs e)
        {
            string password = new Random().Next(1_000, 9_999).ToString();
            string matchName = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 19);

            string? matchId = _lobbyService.CreateMatch(matchName, password, GROUP_NAME);
            if (string.IsNullOrWhiteSpace(matchId)) return;
            
            var matchKamikaze = _lobbyService.EnterOnMatch(matchId, "Kamikaze", password);
            var matchPracinha = _lobbyService.EnterOnMatch(matchId, "Pracinha", password);

            matchKamikaze.IniciarPartida();
            var persons = PersonConst.Names.Select(x => x.Key).ToList();

            var playerMatchQueue = new Queue<MatchForm>();
            playerMatchQueue.Enqueue(matchKamikaze);
            playerMatchQueue.Enqueue(matchPracinha);

            int setor = 4;
            for (int i = 0; i < persons.Count; i++)
            {
                var person = persons[i];
                var player = playerMatchQueue.Dequeue();
                playerMatchQueue.Enqueue(player);

                player.PosicionarPersonagem(setor, person);
                if ((i + 1) % 4 == 1) setor--;
            }

        }

    }
}
