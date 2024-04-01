using MonopolyGame.Properties;

namespace MonopolyGame
{
    public partial class Gameboard : Form
    {
        public Gameboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gameBoardImage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
            Random random = new Random();

            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);

            diceRoll1.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice1}");
            diceRoll2.BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject($"dice_{dice2}");
        }
    }
}