using AutoSystem_KingMe.Models.Constants;
using AutoSystem_KingMe.Services.Game;

namespace AutoSystem_KingMe.Forms
{
    public partial class MatchForm : Form
    {
        private readonly MatchGameService _matchGameService;
        private bool hideFavorites = false;
        private bool isAutomation;

        private Dictionary<string, Point> sectorPositions = new Dictionary<string, Point>
        {
            { "0", new Point(603, 661) }, { "1", new Point(603, 603) },
            { "2", new Point(603, 533) }, { "3", new Point(603, 461) },
            { "4", new Point(603, 395) }, { "5", new Point(603, 331) },
            { "10", new Point(699, 264) }
        };

        public MatchForm(MatchGameService matchGameService, bool isAutomation)
        {
            this.isAutomation = isAutomation;
            _matchGameService = matchGameService;

            InitializeComponent();
            FormClosing += MatchForm_FormClosing;
            turnTimer.Start();
        }

        #region Botões principais

        private void InitGame()
        {
            if (!_matchGameService.GameInited)
            {
                if (!isAutomation)
                {
                    lblIniciouPartida.Visible = true;
                    lblTextAcoes.Visible = true;
                    pnlAcoes.Visible = true;
                    lblQuantidadeNao.Visible = true;
                    btnVerificarVez.Visible = true;
                }

                btnIniciarPartida.Visible = false;
                btnVerFavoritos.Visible = true;
                lblJogador.Text = $"Jogador: {_matchGameService.GetPlayerName()}";

                ShowImages();
                _matchGameService.DefineNoQuantity();
                _matchGameService.GameInited = true;
            }
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            var playerTurn = _matchGameService.StartMatch();
            if (playerTurn is not null)
            {
                lblIniciouPartida.Text = "Partida Iniciada! Vez do jogador: " + playerTurn.Name;
                InitGame();
            }
        }

        // todo: Mudar nome de "Favoritos", para "Cartas" ou algo mais descritivo
        private void btnVerFavoritos_Click(object sender, EventArgs e)
        {
            lblListaFavoritos.Visible = true;
            if (hideFavorites)
            {
                lblListaFavoritos.Text = "Lista de favoritos: ";
                btnVerFavoritos.Text = "Favoritos";
            }
            else
            {
                var favorites = _matchGameService.GetFavorites();

                lblListaFavoritos.Text = "Lista de favoritos: " + favorites;
                btnVerFavoritos.Text = "Esconder lista de favoritos";
            }

            hideFavorites = !hideFavorites;
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            var checkTime = _matchGameService.CheckTime();
            if (checkTime is not null)
                lblVezJogador.Text = $"Vez do jogador {checkTime.PlayerTurn?.Name} - ID: {checkTime.PlayerTurn?.Id}";
        }

        private void btnPosicionarPersonagem_Click(object sender, EventArgs e)
        {
            string letter = txbPersonagem.Text.Trim().ToUpper();
            string sector = txbSetor.Text.Trim();

            if (!int.TryParse(txbSetor.Text.Trim(), out int _))
            {
                MessageBox.Show("Setor inválido.");
                return;
            }

            _matchGameService.PositionCharacter(sector, letter);
        }

        private void btnPromoverPersonagem_Click(object sender, EventArgs e)
        {
            string letter = txbPersonagem.Text.Trim().ToUpper();
            _matchGameService.PromoteCharacter(letter);
        }

        #endregion

        #region Lógica de Timer (status da partida)

        private void turnTimer_Tick(object sender, EventArgs e)
        {
            turnTimer.Stop();

            var time = _matchGameService.CheckTime();
            if (time is not null && time.Status == "J")
            {
                InitGame();

                if (time is null) return;

                lblStatusRodada.Text = time.PhaseDescription;
                lblQuantidadeNao.Text = _matchGameService.NoQuantity.ToString();
                lblVezJogador.Text = $"Vez do jogador {time.PlayerTurn?.Name} - ID: {time.PlayerTurn?.Id}";
                lblJogador.Text = $"Jogador: {_matchGameService.GetPlayerName()}";

                ShowImages();
                ReloadState();

                if (time.Phase == "V" && time.PlayerId == _matchGameService.PlayerOnGame.Id)
                {
                    lblVotacao.Visible = true;
                    pnlVotacao.Visible = true;
                }
            }

            turnTimer.Start();
        }

        #endregion

        #region Métodos auxiliares

        private void ShowImages()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pic && pic.Name.StartsWith("pic"))
                {
                    pic.Visible = true;
                }
            }
        }

        private PictureBox FindPictureBox(string letra)
        {
            string nome = "pic" + letra.ToUpper();
            return Controls.Find(nome, true).FirstOrDefault() as PictureBox;
        }

        private void ReloadState()
        {
            try
            {
                var imagesCounterBySector = new Dictionary<string, int>();
                var charactersPositions = _matchGameService.GetCharacterPositions(out bool isPositionsChanged);
                var characters = CharacterConst.Names.Select(x => x.Key);

                // Caso as posições não tenham sido modificadas, não deve reposicionar as imagens
                if (!isPositionsChanged) return;

                foreach (var letter in characters)
                {
                    PictureBox pictureBox = FindPictureBox(letter);
                    if (!charactersPositions.ContainsKey(letter)) continue;

                    string sector = charactersPositions[letter];
                    if (!imagesCounterBySector.ContainsKey(sector))
                        imagesCounterBySector[sector] = 0;

                    if (sector == "-1") // Personagem removido
                    {
                        pictureBox.Visible = false;
                        continue;
                    }

                    int margin = imagesCounterBySector[sector] * 30;
                    Point basePosition = sectorPositions[sector];
                    Point newPosition = new Point(basePosition.X + margin, basePosition.Y);

                    if (pictureBox != null)
                    {
                        pictureBox.Visible = true;
                        pictureBox.Location = newPosition;
                    }

                    imagesCounterBySector[sector]++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estado do jogo: {ex.Message}");
            }
        }


        #endregion

        #region Eventos do Formulário

        private void MatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        #endregion

        private void btnVotar_Click(object sender, EventArgs e)
        {
            bool accepted = rdoAceitarVotacao.Checked;
            string voting = accepted ? "S" : "N";

            var gameResponse = _matchGameService.Voting(voting);
            gameResponse.OnSuccess(x =>
            {
                pnlVotacao.Visible = false;
                lblVotacao.Visible = false;
            });
        }

    }
}
