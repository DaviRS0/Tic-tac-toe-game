namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int gridSize = 3;
        private int rounds = 0;
        private int player1Wins = 0;
        private int player2Wins = 0;
        private bool isPlayer1Turn = true;
        private PictureBox[,] grid;

        public Form1()
        {
            InitializeComponent();
            comboBoxGridSize.SelectedIndex = 0; // Set default grid size to 3x3
            InitializeGame();
        }

        private void InitializeGame()
        {
            // Clear existing grid if any
            if (grid != null)
            {
                foreach (var pictureBox in grid)
                {
                    this.Controls.Remove(pictureBox);
                }
            }

            // Initialize grid based on selected size
            gridSize = comboBoxGridSize.SelectedIndex == 0 ? 3 : 5;
            grid = new PictureBox[gridSize, gridSize];

            // Create PictureBox controls dynamically
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    grid[i, j] = new PictureBox
                    {
                        Width = 50,
                        Height = 50,
                        Location = new Point(50 * i, 50 * j),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    grid[i, j].Click += new EventHandler(pictureBox_Click);
                    this.Controls.Add(grid[i, j]);
                }
            }

            // Reset game state
            isPlayer1Turn = true;
            rounds = 0;
            UpdateUI();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox.Image != null) return; // Cell already occupied

            pictureBox.Image = isPlayer1Turn ? Properties.Resources.PlayerCircle : Properties.Resources.PlayerX;
            isPlayer1Turn = !isPlayer1Turn;

            // Check for winner or draw
            if (CheckForWinner())
            {
                string winner = isPlayer1Turn ? "Player 2" : "Player 1";
                MessageBox.Show($"{winner} is the winner for this round");
                if (isPlayer1Turn) player2Wins++; else player1Wins++;
                rounds++;
                InitializeGame();
            }
            else if (CheckForDraw())
            {
                MessageBox.Show("It is a draw this round");
                rounds++;
                InitializeGame();
            }

            UpdateUI();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            // Reset game state
            rounds = 0;
            player1Wins = 0;
            player2Wins = 0;
            isPlayer1Turn = true;
            InitializeGame();
            UpdateUI();
        }

        private void comboBoxGridSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeGame();
            UpdateUI();
        }

        // FIX THE LOGIC BEHIND THIS FUNCTION
        private bool CheckForWinner()
        {
            // Check rows
            for (int i = 0; i < gridSize; i++)
            {
                bool rowWin = true;
                for (int j = 1; j < gridSize; j++)
                {
                    if (grid[i, j].Image == null || !grid[i, j].Image.Equals(grid[i, j - 1].Image))
                    {
                        rowWin = false;
                        break;
                    }
                }
                if (rowWin && grid[i, 0].Image != null) return true;
            }

            // Check columns
            for (int i = 0; i < gridSize; i++)
            {
                bool colWin = true;
                for (int j = 1; j < gridSize; j++)
                {
                    if (grid[j, i].Image == null || !grid[j, i].Image.Equals(grid[j - 1, i].Image))
                    {
                        colWin = false;
                        break;
                    }
                }
                if (colWin && grid[0, i].Image != null) return true;
            }

            // Check main diagonal
            bool mainDiagonalWin = true;
            for (int i = 1; i < gridSize; i++)
            {
                if (grid[i, i].Image == null || !grid[i, i].Image.Equals(grid[i - 1, i - 1].Image))
                {
                    mainDiagonalWin = false;
                    break;
                }
            }
            if (mainDiagonalWin && grid[0, 0].Image != null) return true;

            // Check anti-diagonal
            bool antiDiagonalWin = true;
            for (int i = 1; i < gridSize; i++)
            {
                if (grid[i, gridSize - i - 1].Image == null || !grid[i, gridSize - i - 1].Image.Equals(grid[i - 1, gridSize - i].Image))
                {
                    antiDiagonalWin = false;
                    break;
                }
            }
            if (antiDiagonalWin && grid[0, gridSize - 1].Image != null) return true;

            return false;
        }

        private bool CheckForDraw()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (grid[i, j].Image == null)
                    {
                        return false; // If any cell is empty, it's not a draw
                    }
                }
            }
            return true; // All cells are occupied, it's a draw
        }

        private void UpdateUI()
        {
            // Update the label to show whose turn it is
            labelCurrentTurn.Text = isPlayer1Turn ? "Player 1's Turn" : "Player 2's Turn";

            // Update the labels to show the number of wins for each player
            labelPlayer1Wins.Text = $"{player1Wins}";
            labelPlayer2Wins.Text = $"{player2Wins}";

            // Update the label to show the number of rounds played
            labelRounds.Text = $"Rounds: {rounds}";
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Unused Event Handlers
        private void pictureP1Win_Click(object sender, EventArgs e) { }
        private void pictureP2Win_Click(object sender, EventArgs e) { }
        private void labelRounds_Click(object sender, EventArgs e) { }
        private void labelPlayer1Wins_Click_1(object sender, EventArgs e) { }
        private void labelPlayer2Wins_Click_1(object sender, EventArgs e) { }
        private void labelCurrentTurn_Click(object sender, EventArgs e) { }
        private void labelAccolade_Click(object sender, EventArgs e) { }
        private void labelPlayer1Wins_Click(object sender, EventArgs e) { }
        private void labelPlayer2Wins_Click(object sender, EventArgs e) { }
        #endregion
    }
}
