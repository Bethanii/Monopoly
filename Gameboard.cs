using System.Windows.Forms;

namespace MonopolyGame
{
    public partial class Gameboard : Form
    {
        private PictureBox[] spaces;
        private PictureBox dogPictureBox;
        private int currentSpaceIndex = 0;

        public Gameboard()
        {
            InitializeComponent();
            InitializeSpacesArray();
            InitializeDogPictureBox();
            SetupPanelsOnGameBoardImage();
            SetColumnStylesForTableLayoutPanel();
            SetPictureBoxProperties();
            StartOnGoSpace();
        }

        private void UpdateDogPosition()
        {
            Point goSpaceLocation = tableLayoutPanel1.PointToClient(goSpace.Parent.PointToScreen(goSpace.Location));

            int x = goSpace.Location.X - goSpaceLocation.X;
            int y = goSpace.Location.Y - goSpaceLocation.Y;

            dogPictureBox.Location = new Point(x, y);
        }


        private void SetColumnStylesForTableLayoutPanel()
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

        private void SetPictureBoxProperties()
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

        private void InitializeSpacesArray()
        {
            spaces = new PictureBox[]
            {
               goSpace, mediterraneanAve, communityChest2, balticAve, incomeTax, readingRailroad, orientalAve, chance3, vermontAve, connecticutAve,
               inJailSpace, stCharlesPlace, electricCompany, statesAve, virginiaAve, pennsylvaniaRailroad, stJamesPlace, communityChest3, tennesseeAve, newYorkAve,
               freeParkingSpace, kentuckyAve, chance1, indianaAve, illinoisAve, boRailroad, atlanticAve, ventorAve, waterWorks,
               marvinGardens, goToJailSpace, pacificAve, northCarolinaAve, communityChest1, pennsylvaniaAve, shortLine, chance2, parkPlace, luxuryTax, boardwalk
            };
        }

        private void InitializeDogPictureBox()
        {
            dogPictureBox = new PictureBox();
            dogPictureBox.BackColor = Color.White;
            dogPictureBox.Size = new Size(50, 50);
            dogPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dogPictureBox.Image = Properties.Resources.dog;
            Controls.Add(dogPictureBox);
            UpdateDogPosition();
        }


        private void StartOnGoSpace()
        {
            PictureBox goSpacePictureBox = goSpace;

            int targetX = (goSpacePictureBox.Width - dogPictureBox.Width) / 2;
            int targetY = (goSpacePictureBox.Height - dogPictureBox.Height) / 2;

            dogPictureBox.Location = new Point(targetX, targetY);
            goSpacePictureBox.Controls.Add(dogPictureBox);

            dogPictureBox.BringToFront();
        }


        private void MoveDog(int total)
        {
            currentSpaceIndex += total;
            currentSpaceIndex %= spaces.Length;

            PictureBox currentSpace = spaces[currentSpaceIndex];

            int targetX = (currentSpace.Width - dogPictureBox.Width) / 2;
            int targetY = (currentSpace.Height - dogPictureBox.Height) / 2;

            dogPictureBox.Location = new Point(targetX, targetY);
            currentSpace.Controls.Add(dogPictureBox);
        }


        private void SetupPanelsOnGameBoardImage()
        {
            bottomPanel.Parent = gameBoardImage;
            topPanel.Parent = gameBoardImage;
            leftPanel.Parent = gameBoardImage;
            rightPanel.Parent = gameBoardImage;
        }


        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Gameplay gameplay = new Gameplay();
            (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

            diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
            diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");

            //MoveDog(total);
            MoveDog(1);
        }
    }
}