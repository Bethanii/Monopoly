using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MonopolyGame
{
    public partial class StartMenu : Form
    {
        private Button selectedButton;
        private List<Player> players = new List<Player>();
        private List<string> selectedPieces = new List<string>();
        private const int MaxPlayers = 8;
        public StartMenu()
        {
            InitializeComponent();
            InitializePieceSelection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializePieceSelection()
        {
            shipButton.Click += pieceSelection_Click;
            dogButton.Click += pieceSelection_Click;
            hatButton.Click += pieceSelection_Click;
            ironButton.Click += pieceSelection_Click;
            carButton.Click += pieceSelection_Click;
            shoeButton.Click += pieceSelection_Click;
            thimbleButton.Click += pieceSelection_Click;
            wheelbarrowButton.Click += pieceSelection_Click;
        }

        private void pieceSelection_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (selectedButton != null)
            {
                selectedButton.FlatAppearance.BorderSize = 0;
            }

            clickedButton.FlatAppearance.BorderColor = Color.Blue;
            clickedButton.FlatAppearance.BorderSize = 3;
            selectedButton = clickedButton;
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            AddPlayer();

            if (players.Count > 0)
            {
                Gameboard gameBoard = new Gameboard(players);
                this.Hide();
                gameBoard.Show();
            }
            else
            {
                MessageBox.Show("Please add at least one player to start the game.", "No Players Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addAnotherPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayer();
            InitializePieceSelection();
        }


        private void AddPlayer()
        {
            if (selectedButton != null) 
            {
                string playerName = playerNameTextBox.Text.Trim();

                if (string.IsNullOrEmpty(playerName))
                {
                    MessageBox.Show("Please enter a valid name", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //setting as static for now
                string defaultColor = "Red";
                int defaultBoardPosition = 0;
                int defaultMoneyBalance = 1500;
                int defaultInJailCounter = 0;

                Player newPlayer = new Player(playerName, selectedButton.Name.ToLower(), defaultColor, defaultBoardPosition, defaultMoneyBalance, defaultInJailCounter);
                players.Add(newPlayer);
                selectedPieces.Add(selectedButton.Name.ToLower());

                selectedButton.FlatAppearance.BorderSize = 0;
                selectedButton = null;
                playerNameTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please select a game piece", "No Piece Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}