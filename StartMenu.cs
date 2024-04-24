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
        private void red_Click(object sender, EventArgs e)
        {
            playerColor = "Red";
        }
        private void orange_Click(object sender, EventArgs e)
        {
            playerColor = "Orange";
        }

        private void yellow_Click(object sender, EventArgs e)
        {
            playerColor = "Yellow";
        }

        private void green_Click(object sender, EventArgs e)
        {
            playerColor = "Green";
        }

        private void lightBlue_Click(object sender, EventArgs e)
        {
            playerColor = "Light Blue";
        }

        private void darkBlue_Click(object sender, EventArgs e)
        {
            playerColor = "Dark Blue";
        }

        private void purple_Click(object sender, EventArgs e)
        {
            playerColor = "Purple";
        }

        private void black_Click(object sender, EventArgs e)
        {
            playerColor = "Black";
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
            else if (playerColor == "") 
            {
                MessageBox.Show("Please choose a color.", "No Color Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (playerPiece == "")
            {
                MessageBox.Show("Please choose your piece.", "No Piece Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //hides colors and pieces ghat have already been chosen
            else
            {
                switch (playerColor)
                {
                    case "Red":
                        red.Visible = false;
                        break;
                    case "Orange":
                        orange.Visible = false;
                        break;
                    case "Yellow":
                        yellow.Visible = false;
                        break;
                    case "Green":
                        green.Visible = false;
                        break;
                    case "Light Blue":
                        lightBlue.Visible = false;
                        break;
                    case "Dark Blue":
                        darkBlue.Visible = false;
                        break;
                    case "Purple":
                        purple.Visible = false;
                        break;
                    case "Black":
                        black.Visible = false;
                        break;
                    default:
                        break;
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
}