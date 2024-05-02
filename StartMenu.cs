using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonopolyGame
{
    public partial class StartMenu : Form
    {
        public string playerName;
        public string playerColor;
        public string playerPiece;
        public List<Player> players = new List<Player>();


        private Button selectedButton;
        public StartMenu()
        {
            InitializeComponent();
        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (players.Count > 1)
            {
                Gameboard gameBoard = new Gameboard(players);
                this.Hide();
                gameBoard.Show();
            }
            else
            {
                MessageBox.Show("Please add at least 2 players to start playing.", "Not Enough Players", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //sets player parameters
        private void playerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            playerName = playerNameTextBox.Text;
        }

        private void shipButton_Click(object sender, EventArgs e)
        {
            playerPiece = "ship";
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            playerPiece = "dog";
        }

        private void hatButton_Click(object sender, EventArgs e)
        {
            playerPiece = "hat";
        }

        private void ironButton_Click(object sender, EventArgs e)
        {
            playerPiece = "iron";
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            playerPiece = "car";
        }

        private void shoeButton_Click(object sender, EventArgs e)
        {
            playerPiece = "shoe";
        }

        private void thimbleButton_Click(object sender, EventArgs e)
        {
            playerPiece = "thimble";
        }

        private void wheelbarrowButton_Click(object sender, EventArgs e)
        {
            playerPiece = "wheelbarrow";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //ensures players select all requirements
            if (playerName == "")
            {
                MessageBox.Show("Please select your player name", "No Name Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (playerPiece == "")
            {
                MessageBox.Show("Please choose your piece.", "No Piece Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                switch (playerPiece)
                {
                    case "ship":
                        shipButton.Visible = false;
                        break;
                    case "dog":
                        dogButton.Visible = false;
                        break;
                    case "hat":
                        hatButton.Visible = false;
                        break;
                    case "iron":
                        ironButton.Visible = false;
                        break;
                    case "car":
                        carButton.Visible = false;
                        break;
                    case "shoe":
                        shoeButton.Visible = false;
                        break;
                    case "thimble":
                        thimbleButton.Visible = false;
                        break;
                    case "wheelbarrow":
                        wheelbarrowButton.Visible = false;
                        break;
                    default: break;
                }

                players.Add(new Player(playerName, playerPiece, playerColor));
                //Starts game if max players are picked
                if (players.Count > 7)
                {
                    Gameboard gameBoard = new Gameboard(players);
                    this.Hide();
                    gameBoard.Show();
                }

                playerName = "";
                playerColor = "";
                playerPiece = "";
                playerNameTextBox.Clear();
            }
        }
    }
