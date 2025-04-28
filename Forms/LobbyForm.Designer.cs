namespace AutoSystem_KingMe
{
    partial class LobbyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnGetMatchs = new Button();
			panel1 = new Panel();
			lblGetMatchesResponse = new Label();
			lboMatches = new ListBox();
			label3 = new Label();
			label2 = new Label();
			cboMatchsStatus = new ComboBox();
			panel2 = new Panel();
			label14 = new Label();
			label9 = new Label();
			label8 = new Label();
			label6 = new Label();
			lblCreationMatchResponse = new Label();
			txtBox_senhaPartida = new TextBox();
			txtBox_nomePartida = new TextBox();
			btnCreateMatch = new Button();
			panel4 = new Panel();
			lblListPlayerResponse = new Label();
			txtBox_idPartida = new TextBox();
			label5 = new Label();
			lboPlayers = new ListBox();
			btnListPlayers = new Button();
			lbVersion = new Label();
			panel3 = new Panel();
			btnPartidaAutomacao = new Button();
			lblPasswordPlayer = new Label();
			lblIdPlayer = new Label();
			txtBox_PlayerName = new TextBox();
			label12 = new Label();
			txtBox_PasswordMatch = new TextBox();
			label11 = new Label();
			txtBox_IdMatch = new TextBox();
			label10 = new Label();
			btnEnterMatch = new Button();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// btnGetMatchs
			// 
			btnGetMatchs.AllowDrop = true;
			btnGetMatchs.BackColor = Color.Gold;
			btnGetMatchs.FlatAppearance.BorderSize = 0;
			btnGetMatchs.FlatStyle = FlatStyle.Flat;
			btnGetMatchs.Location = new Point(20, 95);
			btnGetMatchs.Margin = new Padding(3, 2, 3, 2);
			btnGetMatchs.Name = "btnGetMatchs";
			btnGetMatchs.Size = new Size(137, 33);
			btnGetMatchs.TabIndex = 0;
			btnGetMatchs.Text = "Consultar partidas";
			btnGetMatchs.UseVisualStyleBackColor = false;
			btnGetMatchs.Click += btnGetMatchs_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Transparent;
			panel1.Controls.Add(lblGetMatchesResponse);
			panel1.Controls.Add(lboMatches);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(cboMatchsStatus);
			panel1.Controls.Add(btnGetMatchs);
			panel1.Location = new Point(74, 73);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(237, 339);
			panel1.TabIndex = 3;
			// 
			// lblGetMatchesResponse
			// 
			lblGetMatchesResponse.Font = new Font("Segoe UI", 8F);
			lblGetMatchesResponse.ForeColor = Color.Red;
			lblGetMatchesResponse.Location = new Point(58, 36);
			lblGetMatchesResponse.Name = "lblGetMatchesResponse";
			lblGetMatchesResponse.Size = new Size(174, 16);
			lblGetMatchesResponse.TabIndex = 15;
			// 
			// lboMatches
			// 
			lboMatches.FormattingEnabled = true;
			lboMatches.ItemHeight = 15;
			lboMatches.Location = new Point(21, 161);
			lboMatches.Margin = new Padding(3, 2, 3, 2);
			lboMatches.Name = "lboMatches";
			lboMatches.Size = new Size(196, 169);
			lboMatches.TabIndex = 14;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F);
			label3.ForeColor = Color.Gold;
			label3.Location = new Point(20, 138);
			label3.Name = "label3";
			label3.Size = new Size(49, 15);
			label3.TabIndex = 13;
			label3.Text = "Partidas";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F);
			label2.ForeColor = Color.Gold;
			label2.Location = new Point(20, 37);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 12;
			label2.Text = "Status";
			// 
			// cboMatchsStatus
			// 
			cboMatchsStatus.CausesValidation = false;
			cboMatchsStatus.FormattingEnabled = true;
			cboMatchsStatus.Items.AddRange(new object[] { "T - Todas", "A - Abertas", "J - Em Jogo", "E - Encerradas" });
			cboMatchsStatus.Location = new Point(20, 59);
			cboMatchsStatus.Margin = new Padding(3, 2, 3, 2);
			cboMatchsStatus.Name = "cboMatchsStatus";
			cboMatchsStatus.Size = new Size(101, 23);
			cboMatchsStatus.TabIndex = 10;
			// 
			// panel2
			// 
			panel2.BackColor = Color.Transparent;
			panel2.Controls.Add(label14);
			panel2.Controls.Add(label9);
			panel2.Controls.Add(label8);
			panel2.Controls.Add(label6);
			panel2.Controls.Add(lblCreationMatchResponse);
			panel2.Controls.Add(txtBox_senhaPartida);
			panel2.Controls.Add(txtBox_nomePartida);
			panel2.Controls.Add(btnCreateMatch);
			panel2.Location = new Point(335, 70);
			panel2.Name = "panel2";
			panel2.Size = new Size(218, 339);
			panel2.TabIndex = 12;
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.ForeColor = Color.Gold;
			label14.Location = new Point(45, 115);
			label14.Name = "label14";
			label14.Size = new Size(128, 15);
			label14.TabIndex = 18;
			label14.Text = "Arqueiros de Azincourt";
			// 
			// label9
			// 
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.ForeColor = Color.Gold;
			label9.Location = new Point(44, 42);
			label9.Name = "label9";
			label9.Size = new Size(111, 15);
			label9.TabIndex = 17;
			label9.Text = "Nome Partida:";
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.Gold;
			label8.Location = new Point(44, 98);
			label8.Name = "label8";
			label8.Size = new Size(111, 15);
			label8.TabIndex = 16;
			label8.Text = "Nome do Grupo:";
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.Gold;
			label6.Location = new Point(44, 141);
			label6.Name = "label6";
			label6.Size = new Size(111, 15);
			label6.TabIndex = 15;
			label6.Text = "Senha da Partida:";
			// 
			// lblCreationMatchResponse
			// 
			lblCreationMatchResponse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblCreationMatchResponse.ForeColor = Color.Gold;
			lblCreationMatchResponse.Location = new Point(35, 210);
			lblCreationMatchResponse.Name = "lblCreationMatchResponse";
			lblCreationMatchResponse.Size = new Size(151, 39);
			lblCreationMatchResponse.TabIndex = 14;
			lblCreationMatchResponse.Text = "ID da Partida:";
			// 
			// txtBox_senhaPartida
			// 
			txtBox_senhaPartida.Location = new Point(44, 162);
			txtBox_senhaPartida.Name = "txtBox_senhaPartida";
			txtBox_senhaPartida.Size = new Size(124, 23);
			txtBox_senhaPartida.TabIndex = 3;
			// 
			// txtBox_nomePartida
			// 
			txtBox_nomePartida.Location = new Point(44, 62);
			txtBox_nomePartida.Name = "txtBox_nomePartida";
			txtBox_nomePartida.Size = new Size(124, 23);
			txtBox_nomePartida.TabIndex = 1;
			// 
			// btnCreateMatch
			// 
			btnCreateMatch.BackColor = Color.Gold;
			btnCreateMatch.FlatAppearance.BorderSize = 0;
			btnCreateMatch.FlatStyle = FlatStyle.Flat;
			btnCreateMatch.Location = new Point(36, 268);
			btnCreateMatch.Name = "btnCreateMatch";
			btnCreateMatch.Size = new Size(142, 40);
			btnCreateMatch.TabIndex = 0;
			btnCreateMatch.Text = "Criar Partida";
			btnCreateMatch.UseVisualStyleBackColor = false;
			btnCreateMatch.Click += btnCreateMatch_Click;
			// 
			// panel4
			// 
			panel4.BackColor = Color.Transparent;
			panel4.Controls.Add(lblListPlayerResponse);
			panel4.Controls.Add(txtBox_idPartida);
			panel4.Controls.Add(label5);
			panel4.Controls.Add(lboPlayers);
			panel4.Controls.Add(btnListPlayers);
			panel4.Location = new Point(70, 433);
			panel4.Name = "panel4";
			panel4.Size = new Size(250, 344);
			panel4.TabIndex = 16;
			// 
			// lblListPlayerResponse
			// 
			lblListPlayerResponse.AutoSize = true;
			lblListPlayerResponse.Location = new Point(161, 334);
			lblListPlayerResponse.Name = "lblListPlayerResponse";
			lblListPlayerResponse.Size = new Size(0, 15);
			lblListPlayerResponse.TabIndex = 18;
			// 
			// txtBox_idPartida
			// 
			txtBox_idPartida.Location = new Point(10, 49);
			txtBox_idPartida.Name = "txtBox_idPartida";
			txtBox_idPartida.Size = new Size(91, 23);
			txtBox_idPartida.TabIndex = 17;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.Gold;
			label5.Location = new Point(10, 31);
			label5.Name = "label5";
			label5.Size = new Size(105, 15);
			label5.TabIndex = 16;
			label5.Text = "PlayerId da Partida";
			// 
			// lboPlayers
			// 
			lboPlayers.FormattingEnabled = true;
			lboPlayers.ItemHeight = 15;
			lboPlayers.Location = new Point(10, 77);
			lboPlayers.Margin = new Padding(3, 2, 3, 2);
			lboPlayers.Name = "lboPlayers";
			lboPlayers.Size = new Size(230, 244);
			lboPlayers.TabIndex = 15;
			// 
			// btnListPlayers
			// 
			btnListPlayers.BackColor = Color.Gold;
			btnListPlayers.FlatAppearance.BorderSize = 0;
			btnListPlayers.FlatStyle = FlatStyle.Flat;
			btnListPlayers.Location = new Point(116, 41);
			btnListPlayers.Name = "btnListPlayers";
			btnListPlayers.Size = new Size(124, 31);
			btnListPlayers.TabIndex = 0;
			btnListPlayers.Text = "Listar Jogadores";
			btnListPlayers.UseVisualStyleBackColor = false;
			btnListPlayers.Click += btnListPlayers_Click;
			// 
			// lbVersion
			// 
			lbVersion.AutoSize = true;
			lbVersion.BackColor = Color.Transparent;
			lbVersion.ForeColor = Color.Gold;
			lbVersion.Location = new Point(335, 792);
			lbVersion.Name = "lbVersion";
			lbVersion.Size = new Size(48, 15);
			lbVersion.TabIndex = 18;
			lbVersion.Text = "Version:";
			// 
			// panel3
			// 
			panel3.BackColor = Color.Transparent;
			panel3.Controls.Add(btnPartidaAutomacao);
			panel3.Controls.Add(lblPasswordPlayer);
			panel3.Controls.Add(lblIdPlayer);
			panel3.Controls.Add(txtBox_PlayerName);
			panel3.Controls.Add(label12);
			panel3.Controls.Add(txtBox_PasswordMatch);
			panel3.Controls.Add(label11);
			panel3.Controls.Add(txtBox_IdMatch);
			panel3.Controls.Add(label10);
			panel3.Controls.Add(btnEnterMatch);
			panel3.Location = new Point(326, 415);
			panel3.Name = "panel3";
			panel3.Size = new Size(250, 360);
			panel3.TabIndex = 20;
			// 
			// btnPartidaAutomacao
			// 
			btnPartidaAutomacao.BackColor = Color.Gold;
			btnPartidaAutomacao.FlatAppearance.BorderSize = 0;
			btnPartidaAutomacao.FlatStyle = FlatStyle.Flat;
			btnPartidaAutomacao.Location = new Point(143, 299);
			btnPartidaAutomacao.Name = "btnPartidaAutomacao";
			btnPartidaAutomacao.Size = new Size(93, 35);
			btnPartidaAutomacao.TabIndex = 11;
			btnPartidaAutomacao.Text = "Automação";
			btnPartidaAutomacao.UseVisualStyleBackColor = false;
			btnPartidaAutomacao.Click += btnPartidaAutomacao_Click;
			// 
			// lblPasswordPlayer
			// 
			lblPasswordPlayer.ForeColor = Color.Gold;
			lblPasswordPlayer.Location = new Point(30, 256);
			lblPasswordPlayer.Name = "lblPasswordPlayer";
			lblPasswordPlayer.Size = new Size(156, 22);
			lblPasswordPlayer.TabIndex = 9;
			lblPasswordPlayer.Text = "Senha do Jogador:";
			// 
			// lblIdPlayer
			// 
			lblIdPlayer.ForeColor = Color.Gold;
			lblIdPlayer.Location = new Point(30, 223);
			lblIdPlayer.Name = "lblIdPlayer";
			lblIdPlayer.Size = new Size(156, 22);
			lblIdPlayer.TabIndex = 8;
			lblIdPlayer.Text = "ID do Jogador:";
			// 
			// txtBox_PlayerName
			// 
			txtBox_PlayerName.BackColor = SystemColors.Menu;
			txtBox_PlayerName.BorderStyle = BorderStyle.None;
			txtBox_PlayerName.Location = new Point(33, 72);
			txtBox_PlayerName.Name = "txtBox_PlayerName";
			txtBox_PlayerName.Size = new Size(151, 16);
			txtBox_PlayerName.TabIndex = 7;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.ForeColor = Color.Gold;
			label12.Location = new Point(34, 159);
			label12.Name = "label12";
			label12.Size = new Size(98, 15);
			label12.TabIndex = 6;
			label12.Text = "Senha da partida:";
			// 
			// txtBox_PasswordMatch
			// 
			txtBox_PasswordMatch.BackColor = SystemColors.Menu;
			txtBox_PasswordMatch.BorderStyle = BorderStyle.None;
			txtBox_PasswordMatch.Location = new Point(33, 178);
			txtBox_PasswordMatch.Name = "txtBox_PasswordMatch";
			txtBox_PasswordMatch.Size = new Size(151, 16);
			txtBox_PasswordMatch.TabIndex = 5;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.ForeColor = Color.Gold;
			label11.Location = new Point(30, 107);
			label11.Name = "label11";
			label11.Size = new Size(77, 15);
			label11.TabIndex = 4;
			label11.Text = "ID da partida:";
			// 
			// txtBox_IdMatch
			// 
			txtBox_IdMatch.BackColor = SystemColors.Menu;
			txtBox_IdMatch.BorderStyle = BorderStyle.None;
			txtBox_IdMatch.Location = new Point(33, 125);
			txtBox_IdMatch.Name = "txtBox_IdMatch";
			txtBox_IdMatch.Size = new Size(151, 16);
			txtBox_IdMatch.TabIndex = 3;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.ForeColor = Color.Gold;
			label10.Location = new Point(30, 54);
			label10.Name = "label10";
			label10.Size = new Size(105, 15);
			label10.TabIndex = 1;
			label10.Text = "Nome do Jogador:";
			// 
			// btnEnterMatch
			// 
			btnEnterMatch.BackColor = Color.Gold;
			btnEnterMatch.FlatAppearance.BorderSize = 0;
			btnEnterMatch.FlatStyle = FlatStyle.Flat;
			btnEnterMatch.Location = new Point(4, 299);
			btnEnterMatch.Name = "btnEnterMatch";
			btnEnterMatch.Size = new Size(112, 35);
			btnEnterMatch.TabIndex = 0;
			btnEnterMatch.Text = "Entrar na Partida";
			btnEnterMatch.UseVisualStyleBackColor = false;
			btnEnterMatch.Click += btnEnterMatch_Click;
			// 
			// LobbyForm
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			BackgroundImage = Properties.Resources.lobbyKingMe;
			ClientSize = new Size(628, 827);
			Controls.Add(panel3);
			Controls.Add(lbVersion);
			Controls.Add(panel4);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Cursor = Cursors.Hand;
			Margin = new Padding(3, 2, 3, 2);
			Name = "LobbyForm";
			Text = "Lobby";
			Load += LobbyForm_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnGetMatchs;
        private Panel panel1;
        private ComboBox cboMatchsStatus;
        private Label label2;
        private ListBox lboMatches;
        private Label label3;
		private Panel panel2;
		private Button btnCreateMatch;
		private TextBox txtBox_senhaPartida;
		private TextBox txtBox_nomePartida;
		private Label label9;
		private Label label8;
		private Label label6;
		private Label lblCreationMatchResponse;
        private Panel panel4;
        private Button btnListPlayers;
        private ListBox lboPlayers;
        private Label label5;
        private TextBox txtBox_idPartida;
        private Label lblListPlayerResponse;
		private Label lbVersion;
		private Panel panel3;
		private Button btnEnterMatch;
		private Label label10;
		private TextBox txtBox_IdMatch;
		private Label label12;
		private TextBox txtBox_PasswordMatch;
		private Label label11;
		private TextBox txtBox_PlayerName;
		private Label lblPasswordPlayer;
		private Label lblIdPlayer;
        private Label lblGetMatchesResponse;
		private Label label14;
        private Button btnPartidaAutomacao;
    }
}
