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
            SetColumnStylesForTableLayoutPanel();
            SetPictureBoxProperties();
            InitializeSpacesArray();
            InitializeDogPictureBox();
            StartOnFreeParking();
        }

        private void SetColumnStylesForTableLayoutPanel()
        {
            bottomPanel.ColumnStyles.Clear();
            topPanel.ColumnStyles.Clear();
            leftPanel.RowStyles.Clear();
            rightPanel.RowStyles.Clear();

            int numberOfColumns = 9;
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
                leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / numberOfColumns));
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / numberOfColumns));
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
                chance1, indianaAve, illinoisAve, boRailroad, atlanticAve, ventorAve, waterWorks, marvinGardens
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

        private void StartOnFreeParking()
        {
            Point freeParkingPosition = topPanel.PointToScreen(chance1.Location);
            freeParkingPosition = dogPictureBox.Parent.PointToClient(freeParkingPosition);
            dogPictureBox.Location = freeParkingPosition;
            dogPictureBox.BringToFront();
        }

        private void UpdateDogPosition()
        {
            /*    Point freeParkingPosition = tableLayoutPanel2.PointToScreen(freeParking.Location);
                freeParkingPosition = dogPictureBox.Parent.PointToClient(freeParkingPosition);
                dogPictureBox.Location = freeParkingPosition;

                dogPictureBox.Parent.Controls.SetChildIndex(dogPictureBox, 0); */

            Point freeParkingPosition = topPanel.PointToScreen(chance1.Location);
            freeParkingPosition = dogPictureBox.Parent.PointToClient(freeParkingPosition);
            dogPictureBox.Location = freeParkingPosition;
            dogPictureBox.BringToFront();
        }

        private void MoveDog(int total)
        {
            currentSpaceIndex += total;

            if (currentSpaceIndex >= spaces.Length)
            {
                currentSpaceIndex %= spaces.Length;
            }

            Point targetPosition = topPanel.PointToScreen(spaces[currentSpaceIndex].Location);
            targetPosition = dogPictureBox.Parent.PointToClient(targetPosition);
            dogPictureBox.Location = targetPosition;

            dogPictureBox.BringToFront();
        }


        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Gameplay gameplay = new Gameplay();
            (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

            diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
            diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");

            currentSpaceIndex += total;

            if (currentSpaceIndex >= spaces.Length)
            {
                currentSpaceIndex %= spaces.Length;
            }

            MoveDog(total);
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statesAve_Click(object sender, EventArgs e)
        {

        }

        /*       private void SetColumnStylesForTableLayoutPanel()
       {
           tableLayoutPanel3.ColumnStyles.Clear();
           tableLayoutPanel2.ColumnStyles.Clear();

           int numberOfColumns = 11;
           float columnWidth = tableLayoutPanel3.Width / numberOfColumns;

           for (int i = 0; i < numberOfColumns; i++)
           {
               tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
           }

           for (int i = 0; i < numberOfColumns; i++)
           {
               tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
           }
       } */

        /*    private void rollDiceButton_Click(object sender, EventArgs e)
            {
                Gameplay gameplay = new Gameplay();

                (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

                diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
                diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");
            } */
    }
}