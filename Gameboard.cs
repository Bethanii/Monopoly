namespace MonopolyGame
{
    public partial class Gameboard : Form
    {
        public Gameboard()
        {
            InitializeComponent();
            SetColumnStylesForTableLayoutPanel();
            SetPictureBoxProperties();
        }

        private void SetColumnStylesForTableLayoutPanel()
        {
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel2.ColumnStyles.Clear();

            int numberOfColumns = 11;
            float columnWidth = tableLayoutPanel1.Width / numberOfColumns;

            for (int i = 0; i < numberOfColumns; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / numberOfColumns));
            }
        }

        private void SetPictureBoxProperties()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
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
        }

        private void gameBoardImage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void diceRoll2_Click(object sender, EventArgs e)
        {

        }

        private void diceRoll1_Click(object sender, EventArgs e)
        {
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            Gameplay gameplay = new Gameplay();

            (int dice1, int dice2, int total) = gameplay.getDiceRollCount();

            diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
            diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

        }
    }
}