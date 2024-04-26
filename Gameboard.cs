using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace MonopolyGame
{
    public partial class Gameboard : Form
    {
        private PictureBox[] spaces;
        private PictureBox pictureBox;
        private List<Player> players;
        private int currentPlayerIndex = 0;
        private Dictionary<Player, PictureBox> playerPieces = new Dictionary<Player, PictureBox>();
        private Dictionary<Panel, Property> panelToPropertyMap = new Dictionary<Panel, Property>();
        private Panel lastClickedPanel;
        private PropertyList propertyList = new PropertyList();

        private int rollCount = 0;
        int doublesCount = 0;
        public Gameboard(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            initializeSpacesArray();
            setupPanelsOnGameBoardImage();
            setColumnStylesForTableLayoutPanel();
            setPictureBoxProperties();
            setupPlayersOnBoard();
            initializeProperties();
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
            //populates first players information
            playerLabel.Text = "Player: " + players[0].getName();
            balanceTextBox.Text = "$" + players[0].getMoneyBalance();

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
                Gameplay gameplay = new Gameplay();
                (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

                diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
                diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");
                // changes button text in case of doubles
                buyButton.Text = "Buy";
                sellButton.Text = "Sell";

                Player currentPlayer = players[currentPlayerIndex];
                gameplay.movePiece(currentPlayer, total, playerPieces, spaces, propertyList);

                //display property price on buy button
                if (propertyList.getProperties().TryGetValue(currentPlayer.getBoardPosition(), out Property currentProperty))
                {
                    if (currentProperty.getOwner() == null)
                    {
                        buyButton.Text = "Buy " + currentProperty.getName() + "\r\nfor $" + currentProperty.getCost();
                    }
                }
                //updates money display if passing go
                balanceTextBox.Text = "$" + players[currentPlayerIndex].getMoneyBalance();

                //checks for doubles
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
                else
                {
                    rollCount++;
                }
            }
            else
            {
                MessageBox.Show("You are only alowed to move once per turn.");
            }
        }


        private void updateCurrentPlayerProperties()
        {
            Player currentPlayer = players[currentPlayerIndex];
            int newY = 35;

            propertiesPanel.Controls.Clear();

            foreach (Property property in currentPlayer.getProperties())
            {
                Panel newPropertyPanel = duplicatePropertyPanel(property);
                newPropertyPanel.Location = new Point(propertyPanel.Location.X, newY);
                propertiesPanel.Controls.Add(newPropertyPanel);
                newPropertyPanel.BringToFront();

                for (int i = 0; i < property.getHouseCount(); i++)
                {
                    PictureBox newHousePictureBox = new PictureBox();
                    newHousePictureBox.BackgroundImage = Properties.Resources.house;
                    newHousePictureBox.Size = new Size(50, 50);
                    newHousePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    newHousePictureBox.BackgroundImageLayout = ImageLayout.Stretch;

                    int x = (newPropertyPanel.Controls.Count - 1) * (newHousePictureBox.Width + 5);
                    int y = 40;

                    newHousePictureBox.Location = new Point(x, y);
                    newPropertyPanel.Controls.Add(newHousePictureBox);
                }

                newY += newPropertyPanel.Height + 10;
            }
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            if (rollCount > 0)
            {
                currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
                string nextPlayerName = players[currentPlayerIndex].getName();
                playerLabel.Text = "Player: " + nextPlayerName;
                balanceTextBox.Text = "$" + players[currentPlayerIndex].getMoneyBalance();
                buyButton.Text = "Buy";
                sellButton.Text = "Sell";

                updateCurrentPlayerProperties();

                rollCount = 0;
            }
            else if (doublesCount > 0)
            {
                MessageBox.Show("You rolled doubles. You get to roll again!");
            }
            else
            {
                MessageBox.Show("Please roll the dice before ending your turn.");
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (players.Count > 0)
            {
                Player currentPlayer = players[currentPlayerIndex];
                int currentBoardPosition = currentPlayer.getBoardPosition();

                if (propertyList.getProperties().TryGetValue(currentBoardPosition, out Property currentProperty))
                {
                    if (currentProperty.getOwner() == null)
                    {
                        if (currentPlayer.getMoneyBalance() > currentProperty.getCost())
                        {
                            propertyNameLabel.Text = currentProperty.getName();
                            propertyPanel.BringToFront();
                            propertyList.getProperties()[currentBoardPosition] = currentProperty;
                            currentPlayer.addProperties(currentProperty);
                            updateCurrentPlayerProperties();
                            AdjustGroupBoxSize();

                            //Charge player cost of prioperty
                            currentPlayer.setMoneyBalance(currentPlayer.getMoneyBalance() - currentProperty.getCost());
                            balanceTextBox.Text = "$" + players[currentPlayerIndex].getMoneyBalance();

                            buyButton.Text = "Congradulations on your purchase!";
                        }
                        else
                        {
                            MessageBox.Show("You can not afford this property.", "Property Too Expensive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This property is already owned.", "Property Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void AdjustGroupBoxSize()
        {
            propertiesPanel.AutoScroll = true;
        }

        private Panel duplicatePropertyPanel(Property property)
        {
            Panel duplicatedPanel = new Panel();
            duplicatedPanel.Size = propertyPanel.Size;
            duplicatedPanel.Font = propertyPanel.Font;
            Label propertyNameLabel = new Label();
            propertyNameLabel.Text = property.getName();
            propertyNameLabel.AutoSize = true;
            propertyNameLabel.MaximumSize = new Size(duplicatedPanel.Width - 10, 0);
            propertyNameLabel.Location = new Point(5, 5);
            propertyNameLabel.Font = new Font(propertyNameLabel.Font.FontFamily, propertyNameLabel.Font.Size + 2, propertyNameLabel.Font.Style);
            propertyNameLabel.Font = new Font(propertyNameLabel.Font, FontStyle.Bold);
            duplicatedPanel.BackColor = GetColorFromColorGroup(property.getColorGroup());

            duplicatedPanel.Paint += (sender, e) =>
            {
                e.Graphics.DrawRectangle(new Pen(Color.Black, 4), new Rectangle(0, 0, duplicatedPanel.Width - 1, duplicatedPanel.Height - 1));
            };

            duplicatedPanel.Controls.Add(propertyNameLabel);
            duplicatedPanel.Click += propertyPanel_Click;

            if (!panelToPropertyMap.ContainsKey(duplicatedPanel))
            {
                panelToPropertyMap[duplicatedPanel] = property;
            }

            return duplicatedPanel;
        }

        private Color GetColorFromColorGroup(string colorGroup)
        {
            var colorMap = new Dictionary<string, Color>
            {
                { "brown", Color.SaddleBrown },
                { "lightBlue", Color.LightSkyBlue },
                { "pink", Color.MediumVioletRed },
                { "orange", Color.Orange },
                { "red", Color.Red },
                { "yellow", Color.Gold },
                { "green", Color.MediumSeaGreen },
                { "darkBlue", Color.DodgerBlue }
            };

            if (colorMap.TryGetValue(colorGroup, out Color color))
            {
                return color;
            }
            return Color.White;
        }

        private void initializeProperties()
        {

        }

        private void propertyPanel_Click(object? sender, EventArgs e)
        {
            Panel? clickedPanel = sender as Panel;

            if (clickedPanel != null)
            {
                lastClickedPanel = clickedPanel;

                foreach (var panel in panelToPropertyMap.Keys)
                {
                    if (panel == clickedPanel)
                    {
                        using (Graphics g = panel.CreateGraphics())
                        {
                            Pen pen = new Pen(Color.Blue, 6);
                            g.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);

                            //resets sell buton if property was sold this turn
                            sellButton.Text = "Sell";
                        }
                    }
                    else
                    {
                        panel.Refresh();
                    }
                }
            }
        }

        private void buyHouseButton_Click(object sender, EventArgs e)
        {
            if (lastClickedPanel != null && panelToPropertyMap.ContainsKey(lastClickedPanel))
            {
                Property property = panelToPropertyMap[lastClickedPanel];

                if (property.getType() == "street")
                {
                    int propertyCount = 0;

                    foreach (Property prop in players[currentPlayerIndex].getProperties())
                    {
                        if (prop.getColorGroup() == property.getColorGroup())
                        {
                            propertyCount++;
                        }
                    }

                    if (property.getColorGroupSize() == propertyCount)
                    {
                        if (players[currentPlayerIndex].getMoneyBalance() > property.getHousePrice())
                        {
                            if (property.getHouseCount() < 4)
                            {
                                PictureBox newHousePictureBox = new PictureBox();
                                newHousePictureBox.BackgroundImage = Properties.Resources.house;
                                newHousePictureBox.Size = new Size(50, 50);
                                newHousePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                newHousePictureBox.BackgroundImageLayout = ImageLayout.Stretch;

                                int x = (lastClickedPanel.Controls.Count - 1) * newHousePictureBox.Width + 5;
                                int y = 40;

                                newHousePictureBox.Location = new Point(x, y);
                                lastClickedPanel.Controls.Add(newHousePictureBox);

                                property.setHouseCount(property.getHouseCount() + 1);
                                players[currentPlayerIndex].setMoneyBalance(players[currentPlayerIndex].getMoneyBalance() - property.getHousePrice());
                                balanceTextBox.Text = "$" + players[currentPlayerIndex].getMoneyBalance();
                            }
                            else if (property.getHouseCount() == 4)
                            {
                                //remove house images and add hotel image

                                property.setHouseCount(property.getHouseCount() + 1);
                                players[currentPlayerIndex].setMoneyBalance(players[currentPlayerIndex].getMoneyBalance() - property.getHousePrice());
                                balanceTextBox.Text = "$" + players[currentPlayerIndex].getMoneyBalance();
                            }
                            else
                            {
                                MessageBox.Show("You can not build anymore on this property");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can not afford to build on this property.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You must own all properties of this type before you can purchase houses");
                    }
                }
                else
                {
                    MessageBox.Show("You can not add houses to this property.");
                }

            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (lastClickedPanel != null && panelToPropertyMap.ContainsKey(lastClickedPanel))
            {
                Property property = panelToPropertyMap[lastClickedPanel];
                if (players[currentPlayerIndex].getProperties().Contains(property))
                {
                    if (property.getHouseCount() == 0)
                    {
                        players[currentPlayerIndex].setMoneyBalance(players[currentPlayerIndex].getMoneyBalance() + property.getCost());
                        players[currentPlayerIndex].removeProperties(property);
                        sellButton.Text = "Transaction Complete!";
                        updateCurrentPlayerProperties();
                        balanceTextBox.Text = "$" + players[currentPlayerIndex].getMoneyBalance();

                    }
                    else
                    {
                        MessageBox.Show("You can not sell a property with houses or hotels on it.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select the property you would like to sell.");
            }

        }

        private void sellHouseButton_Click(object sender, EventArgs e)
        {
            if (lastClickedPanel != null && panelToPropertyMap.ContainsKey(lastClickedPanel))
            {
                Property property = panelToPropertyMap[lastClickedPanel];
                
                if(property.getHouseCount() > 0)
                {
                    property.setHouseCount(property.getHouseCount() - 1);
                    players[currentPlayerIndex].setMoneyBalance(players[currentPlayerIndex].getMoneyBalance() + property.getHousePrice());
                    balanceTextBox.Text = "$" + players[currentPlayerIndex].getMoneyBalance();
                    updateCurrentPlayerProperties();
                }

            }
        }
    }
}