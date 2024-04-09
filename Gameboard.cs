using System.Windows.Forms;

namespace MonopolyGame
{
    public partial class Gameboard : Form
    {
        private PictureBox[] spaces;
        private int currentSpaceIndex = 0;
        private PictureBox pictureBox;
        private List<Player> players;
        private int currentPlayerIndex = 0;
        private Dictionary<Player, PictureBox> playerPieces = new Dictionary<Player, PictureBox>();
        private Dictionary<int, Property> boardPositionToPropertyMap;

        public Gameboard(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            initializeSpacesArray();
            setupPanelsOnGameBoardImage();
            setColumnStylesForTableLayoutPanel();
            setPictureBoxProperties();
            setupPlayersOnBoard();
            InitializeProperties();
            clearPropertyPanel();
        }

        private void clearPropertyPanel()
        {
            if (propertyPanel.Parent != null)
            {
                propertyPanel.Parent.Controls.Remove(propertyPanel);
            }
        }

        private void setupPlayersOnBoard()
        {
            foreach (var player in players)
            {
                PictureBox playerPictureBox = getPictureBox(player.getPiece());
                startOnGoSpace(playerPictureBox);
                playerPieces[player] = playerPictureBox;
            }
        }
        private void setColumnStylesForTableLayoutPanel()
        {
            bottomPanel.ColumnStyles.Clear();
            topPanel.ColumnStyles.Clear();
            leftPanel.RowStyles.Clear();
            rightPanel.RowStyles.Clear();

            int numberOfColumns = 11;
            int numberOfRows = 11;
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
                case "hatbutton":
                    character = Properties.Resources.hat;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "carbutton":
                    character = Properties.Resources.raceCar;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "thimblebutton":
                    character = Properties.Resources.thimble;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "shoebutton":
                    character = Properties.Resources.shoe;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "wheelbarrowbutton":
                    character = Properties.Resources.wheelbarrow;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "ironbutton":
                    character = Properties.Resources.iron;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "shipbutton":
                    character = Properties.Resources.battleShip;
                    pictureBox = createPictureBox(character);
                    startOnGoSpace(pictureBox);
                    break;

                case "dogbutton":
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

        private void movePiece(int total, Player currentPlayer)
        {
            int newBoardPosition = (currentPlayer.getBoardPosition() + total) % spaces.Length;
            currentPlayer.setBoardPosition(newBoardPosition);

            PictureBox pieceToMove = playerPieces[currentPlayer];
            PictureBox currentSpace = spaces[newBoardPosition];

            int targetX = (currentSpace.Width - pieceToMove.Width) / 2;
            int targetY = (currentSpace.Height - pieceToMove.Height) / 2;

            pieceToMove.Location = new Point(targetX, targetY);
            currentSpace.Controls.Add(pieceToMove);
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
            if (players.Count > 0)
            {
                Gameplay gameplay = new Gameplay();
                (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

                diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
                diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");

                Player currentPlayer = players[currentPlayerIndex];
                //  movePiece(total, currentPlayer);
                // moving one increment for testing 
                movePiece(1, currentPlayer);
            }
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
            string nextPlayerName = players[currentPlayerIndex].getName();
            playerLabel.Text = "Player: " + nextPlayerName;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (players.Count > 0)
            {
                Player currentPlayer = players[currentPlayerIndex];
                int currentBoardPosition = currentPlayer.getBoardPosition();

                if (boardPositionToPropertyMap.TryGetValue(currentBoardPosition, out Property currentProperty))
                {
                    if (currentProperty.getOwner() == null)
                    {
                        propertyPanel.BackColor = GetColorFromColorGroup(currentProperty.getColorGroup());
                        propertyNameLabel.Text = currentProperty.getName();
                        propertyPanel.BringToFront();
                        boardPositionToPropertyMap[currentBoardPosition] = currentProperty;

                        currentPlayer.addProperties(currentProperty);

                        Panel newPropertyPanel = duplicatePropertyPanel(currentProperty);
                        int newY = propertiesGroupBox.Controls.Count * (propertyPanel.Height + 10); 
                        newPropertyPanel.Location = new Point(propertyPanel.Location.X, newY);
                        propertiesGroupBox.Controls.Add(newPropertyPanel);
                        newPropertyPanel.BringToFront();
                    }
                    else
                    {
                        MessageBox.Show("This property is already owned.", "Property Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }


        private Panel duplicatePropertyPanel(Property property)
        {
            Panel duplicatedPanel = new Panel();
            duplicatedPanel.BackColor = propertyPanel.BackColor;
            duplicatedPanel.BorderStyle = propertyPanel.BorderStyle;
            duplicatedPanel.Size = propertyPanel.Size;
            duplicatedPanel.Font = propertyPanel.Font;

            Label propertyNameLabel = new Label();
            propertyNameLabel.Text = property.getName();
            propertyNameLabel.Location = propertyNameLabel.Location;
            propertyNameLabel.Font = this.propertyNameLabel.Font;

            duplicatedPanel.Controls.Add(propertyNameLabel);

            return duplicatedPanel;
        }


        private Color GetColorFromColorGroup(string colorGroup)
        {
            var colorMap = new Dictionary<string, Color>
            {
                { "Brown", Color.SaddleBrown },
                { "Light Blue", Color.LightSkyBlue },
                { "Magenta", Color.MediumVioletRed },
                { "Orange", Color.Orange },
                { "Red", Color.Red },
                { "Yellow", Color.Gold },
                { "Green", Color.MediumSeaGreen },
                { "Dark Blue", Color.DodgerBlue }
            };

            if (colorMap.TryGetValue(colorGroup, out Color color))
            {
                return color;
            }
            return Color.White;
        }

        private void InitializeProperties()
        {
            boardPositionToPropertyMap = new Dictionary<int, Property>();

            //hard coding rent values for now
            //------------- Brown ------------------
            Property mediterraneanAvenue = new Property("Mediterranean Avenue", "Brown", 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
            boardPositionToPropertyMap.Add(mediterraneanAvenue.getBoardPosition(), mediterraneanAvenue);

            Property balticAvenue = new Property("Baltic Avenue", "Brown", 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3);
            boardPositionToPropertyMap.Add(balticAvenue.getBoardPosition(), balticAvenue);



            //------------- Light Blue------------------
            Property orientalAvenue = new Property("Oriental Avenue", "Light Blue", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6);
            boardPositionToPropertyMap.Add(orientalAvenue.getBoardPosition(), orientalAvenue);

            Property vermontAvenue = new Property("Vermont Avenue", "Light Blue", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8);
            boardPositionToPropertyMap.Add(vermontAvenue.getBoardPosition(), vermontAvenue);

            Property connecticutAvenue = new Property("Connecticut Avenue", "Light Blue", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 9);
            boardPositionToPropertyMap.Add(connecticutAvenue.getBoardPosition(), connecticutAvenue);


            //------------- Magenta ------------------
            Property stCharlesPlace = new Property("St. Charles Place", "Magenta", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 11);
            boardPositionToPropertyMap.Add(stCharlesPlace.getBoardPosition(), stCharlesPlace);

            Property statesAve = new Property("States Avenue", "Magenta", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 13);
            boardPositionToPropertyMap.Add(statesAve.getBoardPosition(), statesAve);

            Property virginiaAve = new Property("Virginia Avenue", "Magenta", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 14);
            boardPositionToPropertyMap.Add(virginiaAve.getBoardPosition(), virginiaAve);


            //------------- Orange ------------------
            Property stJamesPlace = new Property("St. James Place", "Orange", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 16);
            boardPositionToPropertyMap.Add(stJamesPlace.getBoardPosition(), stJamesPlace);

            Property tennesseeAve = new Property("Tennessee Avenue", "Orange", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 18);
            boardPositionToPropertyMap.Add(tennesseeAve.getBoardPosition(), tennesseeAve);

            Property newYorkAve = new Property("New York Avenue", "Orange", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 19);
            boardPositionToPropertyMap.Add(newYorkAve.getBoardPosition(), newYorkAve);


            //------------- Red ------------------
            Property kentuckyAve = new Property("Kentucky Avenue", "Red", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 21);
            boardPositionToPropertyMap.Add(kentuckyAve.getBoardPosition(), kentuckyAve);

            Property indianaAve = new Property("Indiana Avenue", "Red", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 23);
            boardPositionToPropertyMap.Add(indianaAve.getBoardPosition(), indianaAve);

            Property illinoisAve = new Property("Illinois Avenue", "Red", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 24);
            boardPositionToPropertyMap.Add(illinoisAve.getBoardPosition(), illinoisAve);


            //------------- Yellow ------------------
            Property atlanticAve = new Property("Atlantic Avenue", "Yellow", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 26);
            boardPositionToPropertyMap.Add(atlanticAve.getBoardPosition(), atlanticAve);

            Property ventnorAve = new Property("Ventnor Avenue", "Yellow", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 27);
            boardPositionToPropertyMap.Add(ventnorAve.getBoardPosition(), ventnorAve);

            Property marvinGardens = new Property("Marvin Gardens", "Yellow", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 29);
            boardPositionToPropertyMap.Add(marvinGardens.getBoardPosition(), marvinGardens);


            //------------- Green ------------------
            Property pacificAve = new Property("Pacific Avenue", "Green", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 31);
            boardPositionToPropertyMap.Add(pacificAve.getBoardPosition(), pacificAve);

            Property northCarolinaAve = new Property("North Carolina Avenue", "Green", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 32);
            boardPositionToPropertyMap.Add(northCarolinaAve.getBoardPosition(), northCarolinaAve);

            Property pennsylvaniaAve = new Property("Pennsylvania Avenue", "Green", 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 34);
            boardPositionToPropertyMap.Add(pennsylvaniaAve.getBoardPosition(), pennsylvaniaAve);


            //------------- Dark Blue ------------------
            Property parkPlace = new Property("Park Place", "Dark Blue", 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 37);
            boardPositionToPropertyMap.Add(parkPlace.getBoardPosition(), parkPlace);

            Property boardwalk = new Property("Boardwalk", "Dark Blue", 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 39);
            boardPositionToPropertyMap.Add(boardwalk.getBoardPosition(), boardwalk);
        }
    }
}