using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Services;
using AutoSystem_KingMe.Services.Game;
using KingMeServer;

namespace AutoSystem_KingMe.Forms
{
    public partial class MatchForm : Form
    {
        private readonly MatchGameService _matchGameService;

        #region Campos privados
        private readonly string _matchId;
        private static string mensagemCompartilhada;
        private readonly string _estadoJogoPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Forms", "game_state.txt");
        private readonly object lockAtualizacao = new object();
        private Dictionary<int, int> contadorImagensPorSetor = new Dictionary<int, int>();
        string statusRodada;
        int? qtdNao = null;


        private List<string> imagensPosicionadas = new List<string>();
        private bool hideFavorites = false;
        #endregion

        #region Propriedades públicas
        public readonly PlayerOnGameEntity PlayerOnGame;
        public List<CheckTimeEntity> CheckTime { get; set; }
        public List<CharacterEntity> Personagens { get; set; }
        public List<PlayerEntity> Players { get; set; }
        #endregion

        #region Estruturas auxiliares
        private Dictionary<int, Point> setores = new Dictionary<int, Point>
        {
            { 0, new Point(603, 661) }, { 1, new Point(603, 603) },
            { 2, new Point(603, 533) }, { 3, new Point(603, 461) },
            { 4, new Point(603, 395) }, { 5, new Point(603, 331) },
            { 10, new Point(699, 264) }
        };

        private Dictionary<int, List<PictureBox>> imagensPorSetor = new Dictionary<int, List<PictureBox>>();
        #endregion

        #region Construtor
        public MatchForm(MatchGameService matchGameService)
        {
            _matchGameService = matchGameService;

            InitializeComponent();
            lblJogador.Text = $"Jogador: {_matchGameService.GetPlayerName()}";
            FormClosing += MatchForm_FormClosing;
            turnTimer.Start();
        }
        #endregion

        #region Botões principais

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_matchId))
            {
                btnIniciarPartida.Visible = false;
                lblIniciouPartida.Visible = true;
                lblIniciouPartida.Text = "Partida não pode ser inciada! Sem referência de ID";
                return;
            }

            var playerTurn = _matchGameService.StartMatch();
            if (playerTurn is not null)
            {
                lblIniciouPartida.Visible = true;
                btnIniciarPartida.Visible = false;
                lblTextAcoes.Visible = true;
                pnlAcoes.Visible = true;
                btnVerFavoritos.Visible = true;
                lblQuantidadeNao.Visible = true;
                ShowImages();

                lblIniciouPartida.Text = "Partida Iniciada! Vez do jogador: " + playerTurn.Name;
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

            //var retorno = MatchService.PromotionCharacter(PlayerOnGame, letra);
            //Personagens = retorno.Entities;

            //if (!retorno.IsSuccess)
            //{
            //    lblMenssagemErro.Text = retorno.ErrorMessage;
            //    return;
            //}

            //statusRodada = "Setup";
            //foreach (var personagem in Personagens)
            //{
            //    string letraPersonagem = personagem.Character;
            //    string setor = personagem.Sector;

            //    if (letraPersonagem != null && setor != null)
            //    {
            //        SalvarEstadoJogoComString(letraPersonagem, setor);
            //        CarregarEstadoJogo();
            //        verificarVez();
            //    }
            //}
        }

        #endregion

        #region Lógica de Timer (status da partida)

        private void turnTimer_Tick(object sender, EventArgs e)
        {
            turnTimer.Stop();

            if (_matchGameService.GameStarted)
            {
                var time = _matchGameService.CheckTime();
                if (time is null) return;

                lblStatusRodada.Text = time.PhaseDescription;
                lblQuantidadeNao.Text = _matchGameService.NoQuantity.ToString();
                ShowImages();




            }

            try
            {

                if (status == "INICIADA")
                {

                    lblStatusRodada.Text = statusRodada;
                    QuantidadeNaos();
                    lblQuantidadeNao.Text = Convert.ToString(qtdNao);


                    // here
                    CarregarEstadoJogo();

                    var time = MatchService.CheckTime(_matchId).Entities.FirstOrDefault();
                    if (time is not null)
                    {
                        if (time.Phase == "V" && time.PlayerId == PlayerOnGame.Id)
                        {
                            lblVotacao.Visible = true;
                            pnlVotacao.Visible = true;
                        }
                    }

                }
                else if (status == "ERRO")
                {
                    btnIniciarPartida.Visible = false;
                    lblIniciouPartida.Visible = true;
                    lblIniciouPartida.Text = "Erro ao iniciar a partida.";
                }
            }
            finally
            {
                turnTimer.Start();
            }
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

        private void LimparEstadoJogo()
        {
            try
            {
                File.WriteAllText(_estadoJogoPath, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar o estado do jogo: {ex.Message}");
            }
        }


        private PictureBox EncontrarPictureBox(string letra)
        {
            string nome = "pic" + letra.ToUpper();
            return Controls.Find(nome, true).FirstOrDefault() as PictureBox;
        }

        private void CarregarEstadoJogo()
        {
            try
            {
                contadorImagensPorSetor.Clear();
                


                foreach (var characters in _matchGameService.CharactersOnTable)
                {
                    //string letra = partes[0].Trim().ToUpper();
                    //if (!int.TryParse(partes[1].Trim(), out int setor)) continue;
                    //if (!setores.ContainsKey(setor)) continue;


                    if (!contadorImagensPorSetor.ContainsKey(setor))
                        contadorImagensPorSetor[setor] = 0;

                    int deslocamento = contadorImagensPorSetor[setor] * 30;
                    Point basePos = setores[setor];
                    Point novaPos = new Point(basePos.X + deslocamento, basePos.Y);

                    PictureBox pictureBox = EncontrarPictureBox(letra);
                    if (pictureBox != null)
                    {
                        pictureBox.Visible = true;
                        pictureBox.Location = novaPos;
                    }

                    contadorImagensPorSetor[setor]++;
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

            File.WriteAllText(_estadoJogoPath, string.Empty);
            LimparEstadoJogo();
        }

        #endregion

        private void btnVotar_Click(object sender, EventArgs e)
        {
            bool aceito = rdoAceitarVotacao.Checked;
            string votacao = aceito ? "S" : "N";

            var votacaoResponse = Jogo.Votar(int.Parse(PlayerOnGame.Id), PlayerOnGame.Password, votacao);
            if (!votacaoResponse.StartsWith("ERRO"))
            {
                pnlVotacao.Visible = false;
                lblVotacao.Visible = false;

                if (!aceito) qtdNao--;
            }
        }

    }
}
