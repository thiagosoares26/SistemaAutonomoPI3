using AutoSystem_KingMe.Models.Constants;
using AutoSystem_KingMe.Services.Game;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AutoSystem_KingMe.Forms
{
	public partial class MatchForm : Form
	{
		private readonly MatchGameService _matchGameService;
		private bool hideFavorites = false;
		private bool isAutomation;

		private Dictionary<string, Point> positionInitial = new Dictionary<string, Point>
		{
			{ "A", new Point(63, 329) }, { "B", new Point(91, 329) },
			{ "C", new Point(119, 329) }, { "D", new Point(147, 329) },
			{ "E", new Point(174, 329) }, { "G", new Point(205, 329) },
			{ "H", new Point(236, 329) }, { "K", new Point(63, 376) },
			{ "L", new Point(94, 376) }, { "M", new Point(126, 376) },
			{ "Q", new Point(155, 376) }, { "R", new Point(183, 376) },
			{ "T", new Point(211, 376) }
		};

		private Dictionary<string, Point> sectorPositions = new Dictionary<string, Point>
		{
			{ "0", new Point(374, 662) }, { "1", new Point(374, 592) },
			{ "2", new Point(383, 528) }, { "3", new Point(383, 456) },
			{ "4", new Point(386, 376) }, { "5", new Point(385, 318) },
			{ "10", new Point(472, 249) }
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
				lblRoundRodada.Text = $"Rodada: {time.Round}";
				lblQuantidadeNao.Text = $"Nãos da partida: {_matchGameService.NoQuantity.ToString()}";
				lblVezJogador.Text = $"Vez do jogador {time.PlayerTurn?.Name} - ID: {time.PlayerTurn?.Id}";
				lblJogador.Text = $"Jogador: {_matchGameService.GetPlayerName()}";

				if ((time.Round == "2" || time.Round == "3") && time.Phase == "S")
				{
					ReloadState(resetImages: true);
				}
				else
				{
					ReloadState();
				}

				ShowImages();
			}
			else if (time is not null && time.Status == "E")
			{
				lblStatusRodada.Text = "Partida encerrada!";
				lblRoundRodada.Text = string.Empty;
				lblQuantidadeNao.Text = string.Empty;
				lblVezJogador.Text = string.Empty;
				lblJogador.Text = string.Empty;
				lboVencedor.Visible = true;

				lboVencedor.Items.Clear();
				var player = _matchGameService.GetPlayerWinner();
				lboVencedor.Items.Add(player);
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

		private void ResetImages()
		{
			foreach (var item in positionInitial)
			{
				string pictureBoxName = "pic" + item.Key;

				var control = this.Controls.Find(pictureBoxName, true).FirstOrDefault();

				if (control is PictureBox pictureBox)
				{
					pictureBox.Visible = true;
					pictureBox.Location = item.Value;
				}
			}
		}

		private void ReloadState(bool resetImages = false)
		{
			try
			{
				if (resetImages)
				{
					_matchGameService.ResetCharacterPositions();
					ResetImages();
				}

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

						if (pictureBox.Location != newPosition)
						{
							pictureBox.Location = newPosition;
						}
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

		private void txbPersonagem_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblVezJogador_Click(object sender, EventArgs e)
		{

		}

		private void picA_Click(object sender, EventArgs e)
		{

		}
	}
}
