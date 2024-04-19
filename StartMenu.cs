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
        public List<Player> playerList = new List<Player>();


        private Button selectedButton;
        public StartMenu()
        {
            InitializeComponent();
            InitializePieceSelection();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializePieceSelection()
        {
            shipButton.Click += PieceSelection_Click;
            dogButton.Click += PieceSelection_Click;
            hatButton.Click += PieceSelection_Click;
            ironButton.Click += PieceSelection_Click;
            carButton.Click += PieceSelection_Click;
            shoeButton.Click += PieceSelection_Click;
            thimbleButton.Click += PieceSelection_Click;
            wheelbarrowButton.Click += PieceSelection_Click;
        }

        private void PieceSelection_Click(object sender, EventArgs e)
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
            if (selectedButton != null)
            {
                Gameboard gameBoard = new Gameboard(selectedButton.Name.ToLower(), playerList);
                this.Hide();
                gameBoard.Show();
            }
            else
            {
                MessageBox.Show("Please select a game piece", "No Piece Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
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
            if (playerName != "" && playerColor != "" && playerPiece != "")
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

                playerList.Add(new Player(playerName, playerPiece, playerColor));

                playerName = "";
                playerColor = "";
                playerPiece = "";
                playerNameTextBox.Clear();
            }
        }
    }
}