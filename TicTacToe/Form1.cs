namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private int gridSize = 3;
        private int rounds = 0;
        private int player1Wins = 0;
        private int player2Wins = 0;
        private bool isPlayer1Turn = true;
        private PictureBox[,]? grid; // Declare grid as nullable

        public Form1()
        {
            InitializeComponent();
            this.Text = "Group#_LastName1_LastName2";
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

        private void pictureBox_Click(object? sender, EventArgs e)
        {
            if (sender is not PictureBox pictureBox) return; // Ensure sender is a PictureBox

            if (pictureBox.Image != null) return; // Cell already occupied

            // Assign the image and tag based on the current player's turn
            if (isPlayer1Turn)
            {
                pictureBox.Image = Properties.Resources.PlayerCircle;
                pictureBox.Tag = "Player1"; // Assign Player 1 tag
            }
            else
            {
                pictureBox.Image = Properties.Resources.PlayerX;
                pictureBox.Tag = "Player2"; // Assign Player 2 tag
            }

            // Check for winner or draw
            if (CheckForWinner())
            {
                string winner = isPlayer1Turn ? "Player 1" : "Player 2"; // Before toggling the turn
                MessageBox.Show($"{winner} is the winner for this round");
                if (isPlayer1Turn) player1Wins++; else player2Wins++;
                rounds++;
                InitializeGame();
                return; // Stop further execution
            }
            else if (CheckForDraw())
            {
                MessageBox.Show("It is a draw this round");
                rounds++;
                InitializeGame();
                return; // Stop further execution
            }

            // Toggle the player's turn after checking for the winner
            isPlayer1Turn = !isPlayer1Turn;

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

        private bool CheckForWinner()
        {
            // Check rows
            for (int i = 0; i < gridSize; i++)
            {
                if (grid[i, 0]?.Tag != null)
                {
                    bool rowWin = true;
                    for (int j = 1; j < gridSize; j++)
                    {
                        if (grid[i, j]?.Tag == null || !grid[i, j].Tag.Equals(grid[i, j - 1]?.Tag))
                        {
                            rowWin = false;
                            break;
                        }
                    }
                    if (rowWin)
                    {
                        return true;
                    }
                }
            }

            // Check columns
            for (int i = 0; i < gridSize; i++)
            {
                if (grid[0, i]?.Tag != null)
                {
                    bool colWin = true;
                    for (int j = 1; j < gridSize; j++)
                    {
                        if (grid[j, i]?.Tag == null || !grid[j, i].Tag.Equals(grid[j - 1, i]?.Tag))
                        {
                            colWin = false;
                            break;
                        }
                    }
                    if (colWin)
                    {
                        return true;
                    }
                }
            }

            // Check main diagonal
            if (grid[0, 0]?.Tag != null)
            {
                bool mainDiagonalWin = true;
                for (int i = 1; i < gridSize; i++)
                {
                    if (grid[i, i]?.Tag == null || !grid[i, i].Tag.Equals(grid[i - 1, i - 1]?.Tag))
                    {
                        mainDiagonalWin = false;
                        break;
                    }
                }
                if (mainDiagonalWin)
                {
                    return true;
                }
            }

            // Check anti-diagonal
            if (grid[0, gridSize - 1]?.Tag != null)
            {
                bool antiDiagonalWin = true;
                for (int i = 1; i < gridSize; i++)
                {
                    if (grid[i, gridSize - i - 1]?.Tag == null || !(grid[i, gridSize - i - 1]?.Tag?.Equals(grid[i - 1, gridSize - i]?.Tag) ?? false))
                    {
                        antiDiagonalWin = false;
                        break;
                    }
                }
                if (antiDiagonalWin)
                {
                    return true;
                }
            }

            return false;
        }


        private bool CheckForDraw()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    if (grid[i, j]!.Image == null)
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
            labelCurrentTurn.Text = isPlayer1Turn ? "Player 1's Turn (O)" : "Player 2's Turn (X)";
            labelRounds.Text = $"Rounds: {rounds}";
            labelPlayer1Wins.Text = $"{player1Wins}";
            labelPlayer2Wins.Text = $"{player2Wins}";

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
