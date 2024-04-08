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
        private Button selectedButton;
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
                Gameboard gameBoard = new Gameboard(selectedButton.Name.ToLower());
                this.Hide();
                gameBoard.Show();
            }
            else
            {
                MessageBox.Show("Please select a game piece", "No Piece Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}