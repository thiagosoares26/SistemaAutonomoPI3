namespace AutoSystem_KingMe.Forms
{
	partial class MatchForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			btnIniciarPartida = new Button();
			lblIniciouPartida = new Label();
			lblStatusRodada = new Label();
			pnlAcoes = new Panel();
			lblMenssagemErro = new Label();
			btnPromoverPersonagem = new Button();
			lblStatusAcao = new Label();
			btnPosicionarPersonagem = new Button();
			lblTextPersonagem = new Label();
			lblTextSetor = new Label();
			txbPersonagem = new TextBox();
			txbSetor = new TextBox();
			btnVerFavoritos = new Button();
			lblListaFavoritos = new Label();
			turnTimer = new System.Windows.Forms.Timer(components);
			lblJogador = new Label();
			picA = new PictureBox();
			picB = new PictureBox();
			picG = new PictureBox();
			picC = new PictureBox();
			picD = new PictureBox();
			picE = new PictureBox();
			picH = new PictureBox();
			pick = new PictureBox();
			picL = new PictureBox();
			picM = new PictureBox();
			picQ = new PictureBox();
			picR = new PictureBox();
			picT = new PictureBox();
			lblVezJogador = new Label();
			btnVerificarVez = new Button();
			lblQuantidadeNao = new Label();
			pnlVotacao = new Panel();
			btnVotar = new Button();
			gboEscolhaVotacao = new GroupBox();
			rdoNegarVotacao = new RadioButton();
			rdoAceitarVotacao = new RadioButton();
			lblDescricaoVotacao = new Label();
			lblVotacao = new Label();
			lblRoundRodada = new Label();
			lboVencedor = new ListBox();
			pnlAcoes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)picA).BeginInit();
			((System.ComponentModel.ISupportInitialize)picB).BeginInit();
			((System.ComponentModel.ISupportInitialize)picG).BeginInit();
			((System.ComponentModel.ISupportInitialize)picC).BeginInit();
			((System.ComponentModel.ISupportInitialize)picD).BeginInit();
			((System.ComponentModel.ISupportInitialize)picE).BeginInit();
			((System.ComponentModel.ISupportInitialize)picH).BeginInit();
			((System.ComponentModel.ISupportInitialize)pick).BeginInit();
			((System.ComponentModel.ISupportInitialize)picL).BeginInit();
			((System.ComponentModel.ISupportInitialize)picM).BeginInit();
			((System.ComponentModel.ISupportInitialize)picQ).BeginInit();
			((System.ComponentModel.ISupportInitialize)picR).BeginInit();
			((System.ComponentModel.ISupportInitialize)picT).BeginInit();
			pnlVotacao.SuspendLayout();
			gboEscolhaVotacao.SuspendLayout();
			SuspendLayout();
			// 
			// btnIniciarPartida
			// 
			btnIniciarPartida.BackColor = Color.Gold;
			btnIniciarPartida.FlatAppearance.BorderColor = Color.Black;
			btnIniciarPartida.FlatAppearance.BorderSize = 0;
			btnIniciarPartida.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnIniciarPartida.FlatStyle = FlatStyle.Flat;
			btnIniciarPartida.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnIniciarPartida.ForeColor = Color.Black;
			btnIniciarPartida.Location = new Point(40, 18);
			btnIniciarPartida.Name = "btnIniciarPartida";
			btnIniciarPartida.Size = new Size(101, 26);
			btnIniciarPartida.TabIndex = 0;
			btnIniciarPartida.Text = "INICIAR";
			btnIniciarPartida.UseVisualStyleBackColor = false;
			btnIniciarPartida.Click += btnIniciarPartida_Click;
			// 
			// lblIniciouPartida
			// 
			lblIniciouPartida.BackColor = Color.Transparent;
			lblIniciouPartida.ForeColor = Color.Gold;
			lblIniciouPartida.Location = new Point(726, 433);
			lblIniciouPartida.Name = "lblIniciouPartida";
			lblIniciouPartida.Size = new Size(196, 26);
			lblIniciouPartida.TabIndex = 1;
			lblIniciouPartida.Visible = false;
			// 
			// lblStatusRodada
			// 
			lblStatusRodada.BackColor = Color.Transparent;
			lblStatusRodada.ForeColor = Color.Gold;
			lblStatusRodada.Location = new Point(726, 402);
			lblStatusRodada.Name = "lblStatusRodada";
			lblStatusRodada.Size = new Size(196, 23);
			lblStatusRodada.TabIndex = 2;
			lblStatusRodada.Text = "Status da partida:";
			// 
			// pnlAcoes
			// 
			pnlAcoes.BackColor = Color.Transparent;
			pnlAcoes.BorderStyle = BorderStyle.FixedSingle;
			pnlAcoes.Controls.Add(lblMenssagemErro);
			pnlAcoes.Controls.Add(btnPromoverPersonagem);
			pnlAcoes.Controls.Add(lblStatusAcao);
			pnlAcoes.Controls.Add(btnPosicionarPersonagem);
			pnlAcoes.Controls.Add(lblTextPersonagem);
			pnlAcoes.Controls.Add(lblTextSetor);
			pnlAcoes.Controls.Add(txbPersonagem);
			pnlAcoes.Controls.Add(txbSetor);
			pnlAcoes.Location = new Point(715, 12);
			pnlAcoes.Name = "pnlAcoes";
			pnlAcoes.Size = new Size(216, 236);
			pnlAcoes.TabIndex = 3;
			pnlAcoes.Visible = false;
			// 
			// lblMenssagemErro
			// 
			lblMenssagemErro.AutoSize = true;
			lblMenssagemErro.ForeColor = Color.Red;
			lblMenssagemErro.Location = new Point(24, 255);
			lblMenssagemErro.Name = "lblMenssagemErro";
			lblMenssagemErro.Size = new Size(0, 15);
			lblMenssagemErro.TabIndex = 7;
			// 
			// btnPromoverPersonagem
			// 
			btnPromoverPersonagem.BackColor = Color.Gold;
			btnPromoverPersonagem.FlatAppearance.BorderSize = 0;
			btnPromoverPersonagem.FlatStyle = FlatStyle.Flat;
			btnPromoverPersonagem.ForeColor = Color.Black;
			btnPromoverPersonagem.Location = new Point(33, 184);
			btnPromoverPersonagem.Name = "btnPromoverPersonagem";
			btnPromoverPersonagem.Size = new Size(152, 23);
			btnPromoverPersonagem.TabIndex = 6;
			btnPromoverPersonagem.Text = "Promover Personagem";
			btnPromoverPersonagem.UseVisualStyleBackColor = false;
			btnPromoverPersonagem.Click += btnPromoverPersonagem_Click;
			// 
			// lblStatusAcao
			// 
			lblStatusAcao.AutoSize = true;
			lblStatusAcao.BackColor = Color.Gold;
			lblStatusAcao.ForeColor = SystemColors.ActiveCaptionText;
			lblStatusAcao.Location = new Point(24, 10);
			lblStatusAcao.Name = "lblStatusAcao";
			lblStatusAcao.Size = new Size(134, 15);
			lblStatusAcao.TabIndex = 5;
			lblStatusAcao.Text = "Posicionar Personagem:";
			// 
			// btnPosicionarPersonagem
			// 
			btnPosicionarPersonagem.BackColor = Color.Gold;
			btnPosicionarPersonagem.FlatAppearance.BorderSize = 0;
			btnPosicionarPersonagem.FlatStyle = FlatStyle.Flat;
			btnPosicionarPersonagem.ForeColor = Color.Black;
			btnPosicionarPersonagem.Location = new Point(33, 146);
			btnPosicionarPersonagem.Name = "btnPosicionarPersonagem";
			btnPosicionarPersonagem.Size = new Size(152, 23);
			btnPosicionarPersonagem.TabIndex = 4;
			btnPosicionarPersonagem.Text = "Posicionar Personagem";
			btnPosicionarPersonagem.UseVisualStyleBackColor = false;
			btnPosicionarPersonagem.Click += btnPosicionarPersonagem_Click;
			// 
			// lblTextPersonagem
			// 
			lblTextPersonagem.AutoSize = true;
			lblTextPersonagem.ForeColor = Color.Gold;
			lblTextPersonagem.Location = new Point(26, 91);
			lblTextPersonagem.Name = "lblTextPersonagem";
			lblTextPersonagem.Size = new Size(73, 15);
			lblTextPersonagem.TabIndex = 3;
			lblTextPersonagem.Text = "Personagem";
			// 
			// lblTextSetor
			// 
			lblTextSetor.AutoSize = true;
			lblTextSetor.ForeColor = Color.Gold;
			lblTextSetor.Location = new Point(26, 43);
			lblTextSetor.Name = "lblTextSetor";
			lblTextSetor.Size = new Size(37, 15);
			lblTextSetor.TabIndex = 2;
			lblTextSetor.Text = "Setor:";
			// 
			// txbPersonagem
			// 
			txbPersonagem.Location = new Point(24, 109);
			txbPersonagem.Name = "txbPersonagem";
			txbPersonagem.Size = new Size(161, 23);
			txbPersonagem.TabIndex = 1;
			txbPersonagem.TextChanged += txbPersonagem_TextChanged;
			// 
			// txbSetor
			// 
			txbSetor.BorderStyle = BorderStyle.FixedSingle;
			txbSetor.Location = new Point(24, 61);
			txbSetor.Name = "txbSetor";
			txbSetor.Size = new Size(161, 23);
			txbSetor.TabIndex = 0;
			// 
			// btnVerFavoritos
			// 
			btnVerFavoritos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnVerFavoritos.BackColor = Color.Gold;
			btnVerFavoritos.FlatAppearance.BorderColor = Color.Black;
			btnVerFavoritos.FlatAppearance.BorderSize = 0;
			btnVerFavoritos.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnVerFavoritos.FlatStyle = FlatStyle.Flat;
			btnVerFavoritos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnVerFavoritos.ForeColor = Color.Black;
			btnVerFavoritos.Location = new Point(374, 15);
			btnVerFavoritos.Name = "btnVerFavoritos";
			btnVerFavoritos.Size = new Size(101, 26);
			btnVerFavoritos.TabIndex = 5;
			btnVerFavoritos.Text = "Ver favoritos";
			btnVerFavoritos.UseVisualStyleBackColor = false;
			btnVerFavoritos.Visible = false;
			btnVerFavoritos.Click += btnVerFavoritos_Click;
			// 
			// lblListaFavoritos
			// 
			lblListaFavoritos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			lblListaFavoritos.BackColor = Color.Transparent;
			lblListaFavoritos.ForeColor = Color.Gold;
			lblListaFavoritos.Location = new Point(481, 18);
			lblListaFavoritos.Name = "lblListaFavoritos";
			lblListaFavoritos.Size = new Size(217, 26);
			lblListaFavoritos.TabIndex = 6;
			lblListaFavoritos.Text = "Favoritos:";
			lblListaFavoritos.Visible = false;
			// 
			// turnTimer
			// 
			turnTimer.Interval = 500;
			turnTimer.Tick += turnTimer_Tick;
			// 
			// lblJogador
			// 
			lblJogador.BackColor = Color.Transparent;
			lblJogador.ForeColor = Color.Gold;
			lblJogador.Location = new Point(726, 348);
			lblJogador.Name = "lblJogador";
			lblJogador.Size = new Size(127, 15);
			lblJogador.TabIndex = 7;
			lblJogador.Text = "Jogador: ";
			// 
			// picA
			// 
			picA.BackColor = Color.Transparent;
			picA.BackgroundImage = Properties.Resources.A1;
			picA.BackgroundImageLayout = ImageLayout.Zoom;
			picA.Location = new Point(63, 329);
			picA.Name = "picA";
			picA.Size = new Size(31, 34);
			picA.TabIndex = 8;
			picA.TabStop = false;
			picA.Visible = false;
			picA.Click += picA_Click;
			// 
			// picB
			// 
			picB.BackColor = Color.Transparent;
			picB.BackgroundImage = Properties.Resources.B1;
			picB.BackgroundImageLayout = ImageLayout.Zoom;
			picB.Location = new Point(91, 329);
			picB.Name = "picB";
			picB.Size = new Size(31, 34);
			picB.TabIndex = 9;
			picB.TabStop = false;
			picB.Visible = false;
			// 
			// picG
			// 
			picG.BackColor = Color.Transparent;
			picG.BackgroundImage = Properties.Resources.G1;
			picG.BackgroundImageLayout = ImageLayout.Zoom;
			picG.Location = new Point(205, 329);
			picG.Name = "picG";
			picG.Size = new Size(31, 34);
			picG.TabIndex = 10;
			picG.TabStop = false;
			picG.Visible = false;
			// 
			// picC
			// 
			picC.BackColor = Color.Transparent;
			picC.BackgroundImage = Properties.Resources.C1;
			picC.BackgroundImageLayout = ImageLayout.Zoom;
			picC.Location = new Point(119, 329);
			picC.Name = "picC";
			picC.Size = new Size(31, 34);
			picC.TabIndex = 10;
			picC.TabStop = false;
			picC.Visible = false;
			// 
			// picD
			// 
			picD.BackColor = Color.Transparent;
			picD.BackgroundImage = Properties.Resources.D1;
			picD.BackgroundImageLayout = ImageLayout.Zoom;
			picD.Location = new Point(147, 329);
			picD.Name = "picD";
			picD.Size = new Size(31, 34);
			picD.TabIndex = 11;
			picD.TabStop = false;
			picD.Visible = false;
			// 
			// picE
			// 
			picE.BackColor = Color.Transparent;
			picE.BackgroundImage = Properties.Resources.E1;
			picE.BackgroundImageLayout = ImageLayout.Zoom;
			picE.Location = new Point(174, 329);
			picE.Name = "picE";
			picE.Size = new Size(31, 34);
			picE.TabIndex = 12;
			picE.TabStop = false;
			picE.Visible = false;
			// 
			// picH
			// 
			picH.BackColor = Color.Transparent;
			picH.BackgroundImage = Properties.Resources.H1;
			picH.BackgroundImageLayout = ImageLayout.Zoom;
			picH.Location = new Point(236, 329);
			picH.Name = "picH";
			picH.Size = new Size(31, 34);
			picH.TabIndex = 13;
			picH.TabStop = false;
			picH.Visible = false;
			// 
			// pick
			// 
			pick.BackColor = Color.Transparent;
			pick.BackgroundImage = Properties.Resources.K1;
			pick.BackgroundImageLayout = ImageLayout.Zoom;
			pick.Location = new Point(63, 376);
			pick.Name = "pick";
			pick.Size = new Size(31, 34);
			pick.TabIndex = 14;
			pick.TabStop = false;
			pick.Visible = false;
			// 
			// picL
			// 
			picL.BackColor = Color.Transparent;
			picL.BackgroundImage = Properties.Resources.L1;
			picL.BackgroundImageLayout = ImageLayout.Zoom;
			picL.Location = new Point(94, 376);
			picL.Name = "picL";
			picL.Size = new Size(31, 34);
			picL.TabIndex = 15;
			picL.TabStop = false;
			picL.Visible = false;
			// 
			// picM
			// 
			picM.BackColor = Color.Transparent;
			picM.BackgroundImage = Properties.Resources.M1;
			picM.BackgroundImageLayout = ImageLayout.Zoom;
			picM.Location = new Point(126, 376);
			picM.Name = "picM";
			picM.Size = new Size(31, 34);
			picM.TabIndex = 16;
			picM.TabStop = false;
			picM.Visible = false;
			// 
			// picQ
			// 
			picQ.BackColor = Color.Transparent;
			picQ.BackgroundImage = Properties.Resources.Q1;
			picQ.BackgroundImageLayout = ImageLayout.Zoom;
			picQ.Location = new Point(155, 376);
			picQ.Name = "picQ";
			picQ.Size = new Size(31, 34);
			picQ.TabIndex = 17;
			picQ.TabStop = false;
			picQ.Visible = false;
			// 
			// picR
			// 
			picR.BackColor = Color.Transparent;
			picR.BackgroundImage = Properties.Resources.R1;
			picR.BackgroundImageLayout = ImageLayout.Zoom;
			picR.Location = new Point(183, 376);
			picR.Name = "picR";
			picR.Size = new Size(31, 34);
			picR.TabIndex = 18;
			picR.TabStop = false;
			picR.Visible = false;
			// 
			// picT
			// 
			picT.BackColor = Color.Transparent;
			picT.BackgroundImage = Properties.Resources.T1;
			picT.BackgroundImageLayout = ImageLayout.Zoom;
			picT.Location = new Point(211, 376);
			picT.Name = "picT";
			picT.Size = new Size(31, 34);
			picT.TabIndex = 19;
			picT.TabStop = false;
			picT.Visible = false;
			// 
			// lblVezJogador
			// 
			lblVezJogador.BackColor = Color.Transparent;
			lblVezJogador.ForeColor = Color.Gold;
			lblVezJogador.Location = new Point(481, 56);
			lblVezJogador.Name = "lblVezJogador";
			lblVezJogador.Size = new Size(217, 26);
			lblVezJogador.TabIndex = 21;
			lblVezJogador.Click += lblVezJogador_Click;
			// 
			// btnVerificarVez
			// 
			btnVerificarVez.BackColor = Color.Gold;
			btnVerificarVez.FlatAppearance.BorderSize = 0;
			btnVerificarVez.FlatStyle = FlatStyle.Flat;
			btnVerificarVez.Location = new Point(374, 56);
			btnVerificarVez.Name = "btnVerificarVez";
			btnVerificarVez.Size = new Size(101, 26);
			btnVerificarVez.TabIndex = 22;
			btnVerificarVez.Text = "Verificar Vez";
			btnVerificarVez.UseVisualStyleBackColor = false;
			btnVerificarVez.Visible = false;
			btnVerificarVez.Click += btnVerificarVez_Click;
			// 
			// lblQuantidadeNao
			// 
			lblQuantidadeNao.BackColor = Color.Gold;
			lblQuantidadeNao.FlatStyle = FlatStyle.Flat;
			lblQuantidadeNao.Location = new Point(191, 18);
			lblQuantidadeNao.Name = "lblQuantidadeNao";
			lblQuantidadeNao.Size = new Size(165, 23);
			lblQuantidadeNao.TabIndex = 23;
			lblQuantidadeNao.Text = "Nãos da partida:";
			lblQuantidadeNao.Visible = false;
			// 
			// pnlVotacao
			// 
			pnlVotacao.BackColor = Color.Transparent;
			pnlVotacao.BorderStyle = BorderStyle.FixedSingle;
			pnlVotacao.Controls.Add(btnVotar);
			pnlVotacao.Controls.Add(gboEscolhaVotacao);
			pnlVotacao.Controls.Add(lblDescricaoVotacao);
			pnlVotacao.Location = new Point(63, 498);
			pnlVotacao.Name = "pnlVotacao";
			pnlVotacao.Size = new Size(198, 151);
			pnlVotacao.TabIndex = 24;
			pnlVotacao.Visible = false;
			// 
			// btnVotar
			// 
			btnVotar.BackColor = Color.Gold;
			btnVotar.FlatAppearance.BorderColor = Color.Black;
			btnVotar.FlatAppearance.BorderSize = 0;
			btnVotar.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnVotar.FlatStyle = FlatStyle.Flat;
			btnVotar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnVotar.ForeColor = Color.Black;
			btnVotar.Location = new Point(7, 111);
			btnVotar.Name = "btnVotar";
			btnVotar.Size = new Size(186, 26);
			btnVotar.TabIndex = 25;
			btnVotar.Text = "VOTAR";
			btnVotar.UseVisualStyleBackColor = false;
			btnVotar.Click += btnVotar_Click;
			// 
			// gboEscolhaVotacao
			// 
			gboEscolhaVotacao.Controls.Add(rdoNegarVotacao);
			gboEscolhaVotacao.Controls.Add(rdoAceitarVotacao);
			gboEscolhaVotacao.ForeColor = Color.Gold;
			gboEscolhaVotacao.Location = new Point(7, 58);
			gboEscolhaVotacao.Name = "gboEscolhaVotacao";
			gboEscolhaVotacao.Size = new Size(186, 44);
			gboEscolhaVotacao.TabIndex = 3;
			gboEscolhaVotacao.TabStop = false;
			gboEscolhaVotacao.Text = "Escolha";
			// 
			// rdoNegarVotacao
			// 
			rdoNegarVotacao.AccessibleRole = AccessibleRole.MenuBar;
			rdoNegarVotacao.AutoSize = true;
			rdoNegarVotacao.Checked = true;
			rdoNegarVotacao.FlatStyle = FlatStyle.Flat;
			rdoNegarVotacao.Location = new Point(112, 19);
			rdoNegarVotacao.Name = "rdoNegarVotacao";
			rdoNegarVotacao.Size = new Size(56, 19);
			rdoNegarVotacao.TabIndex = 5;
			rdoNegarVotacao.TabStop = true;
			rdoNegarVotacao.Text = "Negar";
			rdoNegarVotacao.UseVisualStyleBackColor = true;
			// 
			// rdoAceitarVotacao
			// 
			rdoAceitarVotacao.AccessibleRole = AccessibleRole.MenuBar;
			rdoAceitarVotacao.AutoSize = true;
			rdoAceitarVotacao.FlatStyle = FlatStyle.Flat;
			rdoAceitarVotacao.Location = new Point(33, 19);
			rdoAceitarVotacao.Name = "rdoAceitarVotacao";
			rdoAceitarVotacao.Size = new Size(61, 19);
			rdoAceitarVotacao.TabIndex = 4;
			rdoAceitarVotacao.Text = "Aceitar";
			rdoAceitarVotacao.UseVisualStyleBackColor = true;
			// 
			// lblDescricaoVotacao
			// 
			lblDescricaoVotacao.AutoSize = true;
			lblDescricaoVotacao.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			lblDescricaoVotacao.ForeColor = Color.Gold;
			lblDescricaoVotacao.Location = new Point(24, 23);
			lblDescricaoVotacao.Name = "lblDescricaoVotacao";
			lblDescricaoVotacao.Size = new Size(171, 20);
			lblDescricaoVotacao.TabIndex = 0;
			lblDescricaoVotacao.Text = "Deseja eleger como Rei";
			// 
			// lblVotacao
			// 
			lblVotacao.AutoSize = true;
			lblVotacao.BackColor = Color.Transparent;
			lblVotacao.ForeColor = Color.Gold;
			lblVotacao.Location = new Point(73, 489);
			lblVotacao.Name = "lblVotacao";
			lblVotacao.Size = new Size(49, 15);
			lblVotacao.TabIndex = 0;
			lblVotacao.Text = "Votação";
			lblVotacao.Visible = false;
			// 
			// lblRoundRodada
			// 
			lblRoundRodada.BackColor = Color.Transparent;
			lblRoundRodada.ForeColor = Color.Gold;
			lblRoundRodada.Location = new Point(726, 376);
			lblRoundRodada.Name = "lblRoundRodada";
			lblRoundRodada.Size = new Size(119, 23);
			lblRoundRodada.TabIndex = 25;
			lblRoundRodada.Text = "Rodada da partida:";
			// 
			// lboVencedor
			// 
			lboVencedor.FormattingEnabled = true;
			lboVencedor.ItemHeight = 15;
			lboVencedor.Location = new Point(726, 468);
			lboVencedor.Name = "lboVencedor";
			lboVencedor.Size = new Size(198, 94);
			lboVencedor.TabIndex = 26;
			lboVencedor.Visible = false;
			// 
			// MatchForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.backgroundOficial;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(955, 718);
			Controls.Add(lboVencedor);
			Controls.Add(lblRoundRodada);
			Controls.Add(lblVotacao);
			Controls.Add(pnlVotacao);
			Controls.Add(lblQuantidadeNao);
			Controls.Add(btnVerificarVez);
			Controls.Add(lblVezJogador);
			Controls.Add(picT);
			Controls.Add(picR);
			Controls.Add(picQ);
			Controls.Add(picM);
			Controls.Add(picL);
			Controls.Add(pick);
			Controls.Add(picH);
			Controls.Add(picE);
			Controls.Add(picD);
			Controls.Add(picC);
			Controls.Add(picG);
			Controls.Add(picB);
			Controls.Add(picA);
			Controls.Add(lblJogador);
			Controls.Add(lblListaFavoritos);
			Controls.Add(btnVerFavoritos);
			Controls.Add(pnlAcoes);
			Controls.Add(lblStatusRodada);
			Controls.Add(lblIniciouPartida);
			Controls.Add(btnIniciarPartida);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MinimizeBox = false;
			Name = "MatchForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "MatchForm";
			pnlAcoes.ResumeLayout(false);
			pnlAcoes.PerformLayout();
			((System.ComponentModel.ISupportInitialize)picA).EndInit();
			((System.ComponentModel.ISupportInitialize)picB).EndInit();
			((System.ComponentModel.ISupportInitialize)picG).EndInit();
			((System.ComponentModel.ISupportInitialize)picC).EndInit();
			((System.ComponentModel.ISupportInitialize)picD).EndInit();
			((System.ComponentModel.ISupportInitialize)picE).EndInit();
			((System.ComponentModel.ISupportInitialize)picH).EndInit();
			((System.ComponentModel.ISupportInitialize)pick).EndInit();
			((System.ComponentModel.ISupportInitialize)picL).EndInit();
			((System.ComponentModel.ISupportInitialize)picM).EndInit();
			((System.ComponentModel.ISupportInitialize)picQ).EndInit();
			((System.ComponentModel.ISupportInitialize)picR).EndInit();
			((System.ComponentModel.ISupportInitialize)picT).EndInit();
			pnlVotacao.ResumeLayout(false);
			pnlVotacao.PerformLayout();
			gboEscolhaVotacao.ResumeLayout(false);
			gboEscolhaVotacao.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnIniciarPartida;
		private Label lblIniciouPartida;
		private Label lblStatusRodada;
		private Panel pnlAcoes;
		private Label lblTextPersonagem;
		private Label lblTextSetor;
		private TextBox txbPersonagem;
		private TextBox txbSetor;
		private Button btnPosicionarPersonagem;
		private Label lblStatusAcao;
		private Button btnVerFavoritos;
		private Label lblListaFavoritos;
		private System.Windows.Forms.Timer turnTimer;
		private Label lblJogador;
		private PictureBox picA;
		private PictureBox picB;
		private PictureBox picG;
		private PictureBox picC;
		private PictureBox picD;
		private PictureBox picE;
		private PictureBox picH;
		private PictureBox pick;
		private PictureBox picL;
		private PictureBox picM;
		private PictureBox picQ;
		private PictureBox picR;
		private PictureBox picT;
        private Label lblVezJogador;
        private Button btnPromoverPersonagem;
        private Label lblMenssagemErro;
        private Button btnVerificarVez;
		private Label lblQuantidadeNao;
        private Panel pnlVotacao;
        private Label lblDescricaoVotacao;
        private Label lblVotacao;
        private GroupBox gboEscolhaVotacao;
        private RadioButton rdoNegarVotacao;
        private RadioButton rdoAceitarVotacao;
        private Button btnVotar;
        private Label lblRoundRodada;
        private ListBox lboVencedor;
    }
}