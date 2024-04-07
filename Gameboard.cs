namespace MonopolyGame
{
    public partial class Gameboard : Form
    {
        public Gameboard()
        {
            InitializeComponent();
            SetColumnStylesForTableLayoutPanel();
            SetPictureBoxProperties();
            InitializeSpacesArray();
            InitializeDogPictureBox();
            StartOnFreeParking();
            //      UpdateDogPosition();
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

        private void SetColumnStylesForTableLayoutPanel()
        {
            tableLayoutPanel3.ColumnStyles.Clear();
            tableLayoutPanel2.ColumnStyles.Clear();
            tableLayoutPanel4.RowStyles.Clear();

            int numberOfColumns = 11;
            float columnWidth = tableLayoutPanel3.Width / numberOfColumns;
            float rowHeight = tableLayoutPanel4.Height / numberOfColumns;

            for (int i = 0; i < numberOfColumns; i++)
            {
                tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / numberOfColumns));
            }
        }

        private void SetPictureBoxProperties()
        {
            foreach (Control control in tableLayoutPanel3.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Dock = DockStyle.Fill;
                }
            }

            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Dock = DockStyle.Fill;
                }
            }

            foreach (Control control in tableLayoutPanel4.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Dock = DockStyle.Fill;
                }
            }
        }

        /*    private void rollDiceButton_Click(object sender, EventArgs e)
            {
                Gameplay gameplay = new Gameplay();

                (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

                diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
                diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");
            } */

        private PictureBox[] spaces;
        private PictureBox dogPictureBox;
        private int currentSpaceIndex = 0;

        private void InitializeSpacesArray()
        {
            spaces = new PictureBox[]
            {
                freeParking, kentuckyAve, chance1, indianaAve, illinoisAve, boRailroad, atlanticAve, ventorAve, marvinGardens, goToJail
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
            Point freeParkingPosition = tableLayoutPanel2.PointToScreen(freeParking.Location);
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

            Point freeParkingPosition = tableLayoutPanel2.PointToScreen(freeParking.Location);
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

            Point targetPosition = tableLayoutPanel2.PointToScreen(spaces[currentSpaceIndex].Location);
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
    }
}