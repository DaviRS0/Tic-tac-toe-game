
namespace TicTacToe
{
    partial class Form1
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
            comboBoxGridSize = new ComboBox();
            buttonNewGame = new Button();
            buttonExit = new Button();
            pictureBox = new PictureBox();
            labelRounds = new Label();
            lblRound = new Label();
            lblGrid = new Label();
            label2 = new Label();
            grpboxP1 = new GroupBox();
            labelPlayer1Wins = new Label();
            pictureP1Win = new PictureBox();
            pictureBox25 = new PictureBox();
            grpboxP2 = new GroupBox();
            labelPlayer2Wins = new Label();
            pictureP2Win = new PictureBox();
            pictureBox26 = new PictureBox();
            labelCurrentTurn = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            grpboxP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureP1Win).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            grpboxP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureP2Win).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGridSize
            // 
            comboBoxGridSize.FormattingEnabled = true;
            comboBoxGridSize.Items.AddRange(new object[] { "3", "5" });
            comboBoxGridSize.Location = new Point(522, 12);
            comboBoxGridSize.Name = "comboBoxGridSize";
            comboBoxGridSize.Size = new Size(72, 23);
            comboBoxGridSize.TabIndex = 0;
            comboBoxGridSize.SelectedIndexChanged += comboBoxGridSize_SelectedIndexChanged;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new Point(443, 296);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new Size(121, 43);
            buttonNewGame.TabIndex = 1;
            buttonNewGame.Text = "New game";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(443, 345);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(121, 43);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(70, 308);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(186, 71);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // labelRounds
            // 
            labelRounds.AutoSize = true;
            labelRounds.Location = new Point(522, 62);
            labelRounds.Name = "labelRounds";
            labelRounds.Size = new Size(13, 15);
            labelRounds.TabIndex = 5;
            labelRounds.Text = "0";
            labelRounds.Click += labelRounds_Click;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Location = new Point(425, 62);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(42, 15);
            lblRound.TabIndex = 30;
            lblRound.Text = "Round";
            // 
            // lblGrid
            // 
            lblGrid.AutoSize = true;
            lblGrid.Location = new Point(425, 12);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new Size(52, 15);
            lblGrid.TabIndex = 31;
            lblGrid.Text = "Grid Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 96);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 32;
            label2.Text = "Score Board";
            // 
            // grpboxP1
            // 
            grpboxP1.Controls.Add(labelPlayer1Wins);
            grpboxP1.Controls.Add(pictureP1Win);
            grpboxP1.Controls.Add(pictureBox25);
            grpboxP1.Location = new Point(389, 135);
            grpboxP1.Name = "grpboxP1";
            grpboxP1.Size = new Size(88, 141);
            grpboxP1.TabIndex = 33;
            grpboxP1.TabStop = false;
            grpboxP1.Text = "Player 1";
            // 
            // labelPlayer1Wins
            // 
            labelPlayer1Wins.AutoSize = true;
            labelPlayer1Wins.Location = new Point(36, 69);
            labelPlayer1Wins.Name = "labelPlayer1Wins";
            labelPlayer1Wins.Size = new Size(13, 15);
            labelPlayer1Wins.TabIndex = 35;
            labelPlayer1Wins.Text = "0";
            labelPlayer1Wins.Click += labelPlayer1Wins_Click_1;
            // 
            // pictureP1Win
            // 
            pictureP1Win.Image = Properties.Resources.Winner;
            pictureP1Win.Location = new Point(26, 87);
            pictureP1Win.Name = "pictureP1Win";
            pictureP1Win.Size = new Size(37, 37);
            pictureP1Win.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureP1Win.TabIndex = 36;
            pictureP1Win.TabStop = false;
            pictureP1Win.Visible = false;
            pictureP1Win.Click += pictureP1Win_Click;
            // 
            // pictureBox25
            // 
            pictureBox25.Image = Properties.Resources.PlayerCircle;
            pictureBox25.Location = new Point(26, 22);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(37, 37);
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox25.TabIndex = 35;
            pictureBox25.TabStop = false;
            // 
            // grpboxP2
            // 
            grpboxP2.Controls.Add(labelPlayer2Wins);
            grpboxP2.Controls.Add(pictureP2Win);
            grpboxP2.Controls.Add(pictureBox26);
            grpboxP2.Location = new Point(522, 135);
            grpboxP2.Name = "grpboxP2";
            grpboxP2.Size = new Size(88, 141);
            grpboxP2.TabIndex = 34;
            grpboxP2.TabStop = false;
            grpboxP2.Text = "Player 2";
            // 
            // labelPlayer2Wins
            // 
            labelPlayer2Wins.AutoSize = true;
            labelPlayer2Wins.Location = new Point(38, 69);
            labelPlayer2Wins.Name = "labelPlayer2Wins";
            labelPlayer2Wins.Size = new Size(13, 15);
            labelPlayer2Wins.TabIndex = 37;
            labelPlayer2Wins.Text = "0";
            labelPlayer2Wins.Click += labelPlayer2Wins_Click_1;
            // 
            // pictureP2Win
            // 
            pictureP2Win.Image = Properties.Resources.Winner;
            pictureP2Win.Location = new Point(25, 87);
            pictureP2Win.Name = "pictureP2Win";
            pictureP2Win.Size = new Size(37, 37);
            pictureP2Win.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureP2Win.TabIndex = 37;
            pictureP2Win.TabStop = false;
            pictureP2Win.Visible = false;
            pictureP2Win.Click += pictureP2Win_Click;
            // 
            // pictureBox26
            // 
            pictureBox26.Image = Properties.Resources.PlayerX;
            pictureBox26.Location = new Point(25, 22);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(37, 37);
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox26.TabIndex = 36;
            pictureBox26.TabStop = false;
            // 
            // labelCurrentTurn
            // 
            labelCurrentTurn.AutoSize = true;
            labelCurrentTurn.Location = new Point(118, 404);
            labelCurrentTurn.Name = "labelCurrentTurn";
            labelCurrentTurn.Size = new Size(72, 15);
            labelCurrentTurn.TabIndex = 35;
            labelCurrentTurn.Text = "Current turn";
            labelCurrentTurn.Click += labelCurrentTurn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 450);
            Controls.Add(labelCurrentTurn);
            Controls.Add(grpboxP2);
            Controls.Add(grpboxP1);
            Controls.Add(label2);
            Controls.Add(lblGrid);
            Controls.Add(lblRound);
            Controls.Add(labelRounds);
            Controls.Add(pictureBox);
            Controls.Add(buttonExit);
            Controls.Add(buttonNewGame);
            Controls.Add(comboBoxGridSize);
            Name = "Form1";
            Text = "Group18_Sobral_Ajibola";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            grpboxP1.ResumeLayout(false);
            grpboxP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureP1Win).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            grpboxP2.ResumeLayout(false);
            grpboxP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureP2Win).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize components or perform any startup tasks here
        }

        #endregion

        private ComboBox comboBoxGridSize;
        private Button buttonNewGame;
        private Button buttonExit;
        private PictureBox pictureBox;
        private Label labelRounds;
        private Label lblRound;
        private Label lblGrid;
        private Label label2;
        private GroupBox grpboxP1;
        private PictureBox pictureBox25;
        private GroupBox grpboxP2;
        private PictureBox pictureBox26;
        private PictureBox pictureP1Win;
        private PictureBox pictureP2Win;
        private Label labelPlayer1Wins;
        private Label labelPlayer2Wins;
        private Label labelCurrentTurn;
    }
}
