using Monopoly_Start;
using System.Windows.Forms;

namespace MonopolyGame
{
    public partial class Gameboard : Form
    {
        private List<Player> playerList;
        private PropertyList propertyList = new PropertyList();
        private int currentPlayerIndex = 0;
        private int rollCount = 0;
        private int doublesCount = 0;
        private Gameplay gameplay = new Gameplay();

        private PictureBox[] spaces;
        private int currentSpaceIndex = 0;
        private PictureBox pictureBox;
        public Gameboard(List<Player> players)
        {
            InitializeComponent();
            this.pictureBox = getPictureBox(players[currentPlayerIndex].getPiece());
            initializeSpacesArray();
            setupPanelsOnGameBoardImage();
            setColumnStylesForTableLayoutPanel();
            setPictureBoxProperties();

            this.playerList = players;
            UpdatePlayerTurnLabel();
        }

        private void setColumnStylesForTableLayoutPanel()
        {
            bottomPanel.ColumnStyles.Clear();
            topPanel.ColumnStyles.Clear();
            leftPanel.RowStyles.Clear();
            rightPanel.RowStyles.Clear();

            int numberOfColumns = 11;
            int numberOfRows = 9;
            float columnWidth = bottomPanel.Width / numberOfColumns;
            float rowHeight = leftPanel.Height / numberOfColumns;

            for (int i = 0; i < numberOfColumns; i++)
            {
                bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / numberOfRows));
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / numberOfRows));
            }
        }

        private void setPictureBoxProperties()
        {
            foreach (Control control in bottomPanel.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Dock = DockStyle.Fill;
                }
            }

            foreach (Control control in topPanel.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Dock = DockStyle.Fill;
                }
            }

            foreach (Control control in leftPanel.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Dock = DockStyle.Fill;
                }
            }

            foreach (Control control in rightPanel.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Dock = DockStyle.Fill;
                }
            }
        }

        private void initializeSpacesArray()
        {
            spaces = new PictureBox[]
            {
               goSpace, mediterraneanAve, communityChest2, balticAve, incomeTax, readingRailroad, orientalAve, chance3, vermontAve, connecticutAve,
               inJailSpace, stCharlesPlace, electricCompany, statesAve, virginiaAve, pennsylvaniaRailroad, stJamesPlace, communityChest3, tennesseeAve, newYorkAve,
               freeParkingSpace, kentuckyAve, chance1, indianaAve, illinoisAve, boRailroad, atlanticAve, ventorAve, waterWorks,
               marvinGardens, goToJailSpace, pacificAve, northCarolinaAve, communityChest1, pennsylvaniaAve, shortLine, chance2, parkPlace, luxuryTax, boardwalk
            };
        }

        private PictureBox createPictureBox(Image characterImage)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackColor = Color.White;
            pictureBox.Size = new Size(50, 50);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = characterImage;
            Controls.Add(pictureBox);
            return pictureBox;
        }

        private PictureBox getPictureBox(string pictureName)
        {
            PictureBox picture = new PictureBox();
            Image character;

            switch (pictureName.ToLower())
            {
                case "hat":
                    character = Properties.Resources.hat;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "car":
                    character = Properties.Resources.raceCar;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "thimble":
                    character = Properties.Resources.thimble;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "shoe":
                    character = Properties.Resources.shoe;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "wheelbarrow":
                    character = Properties.Resources.wheelbarrow;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "iron":
                    character = Properties.Resources.iron;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "ship":
                    character = Properties.Resources.battleShip;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "dog":
                    character = Properties.Resources.dog;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;
            }
            return pictureBox;
        }

        private void startOnGoSpace(PictureBox pictureBox)
        {
            PictureBox goSpacePictureBox = goSpace;

            int targetX = (goSpacePictureBox.Width - pictureBox.Width) / 2;
            int targetY = (goSpacePictureBox.Height - pictureBox.Height) / 2;

            pictureBox.Location = new Point(targetX, targetY);
            goSpacePictureBox.Controls.Add(pictureBox);

            pictureBox.BringToFront();
        }

        private void movePiece(int total)
        {
            currentSpaceIndex += total;
            currentSpaceIndex %= spaces.Length;

            PictureBox currentSpace = spaces[currentSpaceIndex];

            int targetX = (currentSpace.Width - this.pictureBox.Width) / 2;
            int targetY = (currentSpace.Height - this.pictureBox.Height) / 2;

            this.pictureBox.Location = new Point(targetX, targetY);
            currentSpace.Controls.Add(this.pictureBox);


            (int propertyCost, Property propertyForSale) = gameplay.turnOptions(currentSpaceIndex, propertyList);
            if (propertyCost > 0)
            {
                buyButton.Text = "Buy " + propertyForSale.getName() + "\r\n for " + (propertyCost.ToString());
            }

        }


        private void setupPanelsOnGameBoardImage()
        {
            bottomPanel.Parent = gameBoardImage;
            topPanel.Parent = gameBoardImage;
            leftPanel.Parent = gameBoardImage;
            rightPanel.Parent = gameBoardImage;
        }


        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            if (rollCount == 0)
            {
                (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

                diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
                diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");

                rollCount++;

                movePiece(total);

                if (dice1 == dice2)
                {
                    doublesCount++;
                    if (doublesCount < 3)
                    {
                        rollCount = 0;
                    }
                    else
                    {
                        //put go to jail logic here
                    }
                }
            }
            else
            {
                MessageBox.Show("You are only alowed to move once per turn.");
            }
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            if (rollCount > 0)
            {
                currentPlayerIndex = (currentPlayerIndex + 1) % playerList.Count;
                UpdatePlayerTurnLabel();
                rollCount = 0;
                doublesCount = 0;
            }
            else
            {
                if (doublesCount == 0)
                {
                    MessageBox.Show("Please roll the dice before ending your turn.");
                }
                else
                {
                    MessageBox.Show("You rolled doubles. You get to roll again!");
                }

            }
        }

        private void UpdatePlayerTurnLabel()
        {
            PlayerTurnLabel.Text = playerList[currentPlayerIndex].getName();
            balanceTextBox.Text = playerList[currentPlayerIndex].getMoneyBalance().ToString();
            buyButton.Text = "Buy";
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            (int propertyCost, Property propertyForSale) = gameplay.turnOptions(currentSpaceIndex, propertyList);

            if (propertyCost > 0)
            {    
                if (playerList[currentPlayerIndex].getMoneyBalance() > propertyCost)
                {
                    playerList[currentPlayerIndex].setMoneyBalance(playerList[currentPlayerIndex].getMoneyBalance() - propertyCost);
                    playerList[currentPlayerIndex].addProperties(propertyForSale);

                    balanceTextBox.Text = playerList[currentPlayerIndex].getMoneyBalance().ToString();
                    buyButton.Text = "Cougradulations you purchased " + propertyForSale.getName();
                }
                else
                {
                    MessageBox.Show("You cannot afford that property");
                }
            }
        }
    }
}