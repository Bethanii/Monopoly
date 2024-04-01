using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MonopolyGame
{
    partial class Gameboard
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox gameBoard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameboard));
            gameBoardImage = new PictureBox();
            propertiesGroupBox = new GroupBox();
            label2 = new Label();
            balanceTextBox = new TextBox();
            buyButton = new Button();
            sellButton = new Button();
            nextTurnButton = new Button();
            getOutOfJailFreeCards = new PictureBox();
            diceRoll1 = new PictureBox();
            diceRoll2 = new PictureBox();
            groupBox1 = new GroupBox();
            rollDiceButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gameBoardImage
            // 
            gameBoardImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameBoardImage.BackgroundImage = (Image)resources.GetObject("gameBoardImage.BackgroundImage");
            gameBoardImage.BackgroundImageLayout = ImageLayout.Stretch;
            gameBoardImage.Cursor = Cursors.No;
            gameBoardImage.Location = new Point(417, 20);
            gameBoardImage.Margin = new Padding(4, 5, 4, 5);
            gameBoardImage.MaximumSize = new Size(1200, 1400);
            gameBoardImage.MinimumSize = new Size(807, 942);
            gameBoardImage.Name = "gameBoardImage";
            gameBoardImage.Size = new Size(859, 948);
            gameBoardImage.TabIndex = 2;
            gameBoardImage.TabStop = false;
            gameBoardImage.Click += gameBoardImage_Click;
            // 
            // propertiesGroupBox
            // 
            propertiesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            propertiesGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            propertiesGroupBox.BackColor = Color.AliceBlue;
            propertiesGroupBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            propertiesGroupBox.Location = new Point(1341, 243);
            propertiesGroupBox.Margin = new Padding(4, 5, 4, 5);
            propertiesGroupBox.Name = "propertiesGroupBox";
            propertiesGroupBox.Padding = new Padding(4, 5, 4, 5);
            propertiesGroupBox.Size = new Size(420, 703);
            propertiesGroupBox.TabIndex = 8;
            propertiesGroupBox.TabStop = false;
            propertiesGroupBox.Text = "Properties";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1341, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 47);
            label2.TabIndex = 10;
            label2.Text = "Balance:";
            label2.Click += label2_Click_1;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            balanceTextBox.Enabled = false;
            balanceTextBox.ForeColor = SystemColors.WindowText;
            balanceTextBox.Location = new Point(1341, 105);
            balanceTextBox.Margin = new Padding(4, 5, 4, 5);
            balanceTextBox.Multiline = true;
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(418, 72);
            balanceTextBox.TabIndex = 11;
            balanceTextBox.Text = "\r\n";
            balanceTextBox.TextAlign = HorizontalAlignment.Center;
            balanceTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // buyButton
            // 
            buyButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buyButton.BackColor = Color.MediumSpringGreen;
            buyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buyButton.Location = new Point(17, 68);
            buyButton.Margin = new Padding(4, 5, 4, 5);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(320, 87);
            buyButton.TabIndex = 12;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += button1_Click;
            // 
            // sellButton
            // 
            sellButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sellButton.BackColor = Color.Yellow;
            sellButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sellButton.Location = new Point(17, 165);
            sellButton.Margin = new Padding(4, 5, 4, 5);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(320, 87);
            sellButton.TabIndex = 15;
            sellButton.Text = "Sell";
            sellButton.UseVisualStyleBackColor = false;
            sellButton.Click += button1_Click_1;
            // 
            // nextTurnButton
            // 
            nextTurnButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nextTurnButton.BackColor = Color.LightSkyBlue;
            nextTurnButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nextTurnButton.ForeColor = SystemColors.ControlText;
            nextTurnButton.Location = new Point(17, 262);
            nextTurnButton.Margin = new Padding(4, 5, 4, 5);
            nextTurnButton.Name = "nextTurnButton";
            nextTurnButton.Size = new Size(320, 87);
            nextTurnButton.TabIndex = 16;
            nextTurnButton.Text = "Next Turn";
            nextTurnButton.UseVisualStyleBackColor = false;
            // 
            // getOutOfJailFreeCards
            // 
            getOutOfJailFreeCards.Anchor = AnchorStyles.Left;
            getOutOfJailFreeCards.BackgroundImage = (Image)resources.GetObject("getOutOfJailFreeCards.BackgroundImage");
            getOutOfJailFreeCards.BackgroundImageLayout = ImageLayout.Stretch;
            getOutOfJailFreeCards.Location = new Point(17, 775);
            getOutOfJailFreeCards.Margin = new Padding(4, 5, 4, 5);
            getOutOfJailFreeCards.MaximumSize = new Size(311, 377);
            getOutOfJailFreeCards.Name = "getOutOfJailFreeCards";
            getOutOfJailFreeCards.Size = new Size(311, 193);
            getOutOfJailFreeCards.TabIndex = 17;
            getOutOfJailFreeCards.TabStop = false;
            // 
            // diceRoll1
            // 
            diceRoll1.BackColor = Color.Transparent;
            diceRoll1.BackgroundImage = (Image)resources.GetObject("diceRoll1.BackgroundImage");
            diceRoll1.BackgroundImageLayout = ImageLayout.Stretch;
            diceRoll1.Location = new Point(37, 40);
            diceRoll1.Margin = new Padding(4, 5, 4, 5);
            diceRoll1.Name = "diceRoll1";
            diceRoll1.Size = new Size(119, 132);
            diceRoll1.TabIndex = 18;
            diceRoll1.TabStop = false;
            diceRoll1.Click += diceRoll1_Click;
            // 
            // diceRoll2
            // 
            diceRoll2.BackColor = Color.Transparent;
            diceRoll2.BackgroundImage = (Image)resources.GetObject("diceRoll2.BackgroundImage");
            diceRoll2.BackgroundImageLayout = ImageLayout.Stretch;
            diceRoll2.Location = new Point(164, 40);
            diceRoll2.Margin = new Padding(4, 5, 4, 5);
            diceRoll2.Name = "diceRoll2";
            diceRoll2.Size = new Size(119, 132);
            diceRoll2.TabIndex = 19;
            diceRoll2.TabStop = false;
            diceRoll2.Click += diceRoll2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(diceRoll2);
            groupBox1.Controls.Add(diceRoll1);
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(17, 405);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(320, 198);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // rollDiceButton
            // 
            rollDiceButton.Anchor = AnchorStyles.Left;
            rollDiceButton.BackColor = Color.Tomato;
            rollDiceButton.BackgroundImageLayout = ImageLayout.Stretch;
            rollDiceButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            rollDiceButton.ForeColor = SystemColors.ControlText;
            rollDiceButton.Location = new Point(80, 587);
            rollDiceButton.Margin = new Padding(4, 5, 4, 5);
            rollDiceButton.Name = "rollDiceButton";
            rollDiceButton.Size = new Size(187, 72);
            rollDiceButton.TabIndex = 21;
            rollDiceButton.Text = "Roll Dice";
            rollDiceButton.UseVisualStyleBackColor = false;
            rollDiceButton.Click += rollDiceButton_Click;
            this.rollDiceButton.Click += new System.EventHandler(this.rollDiceButton_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(369, 218);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Gameboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1779, 1090);
            Controls.Add(pictureBox1);
            Controls.Add(rollDiceButton);
            Controls.Add(groupBox1);
            Controls.Add(getOutOfJailFreeCards);
            Controls.Add(nextTurnButton);
            Controls.Add(sellButton);
            Controls.Add(buyButton);
            Controls.Add(balanceTextBox);
            Controls.Add(propertiesGroupBox);
            Controls.Add(label2);
            Controls.Add(gameBoardImage);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Gameboard";
            Text = "Form1";
      //      Load += Gameboard_Load;
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox gameBoardImage;
        private GroupBox propertiesGroupBox;
        private Label label2;
        private TextBox balanceTextBox;
        private Button buyButton;
        private Button sellButton;
        private Button nextTurnButton;
        private PictureBox getOutOfJailFreeCards;
        private PictureBox diceRoll1;
        private PictureBox diceRoll2;
        private GroupBox groupBox1;
        private Button rollDiceButton;
        private PictureBox pictureBox1;
    }
}
