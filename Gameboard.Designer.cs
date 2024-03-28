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
            label1 = new Label();
            sellButton = new Button();
            nextTurnButton = new Button();
            getOutOfJailFreeCards = new PictureBox();
            diceRoll1 = new PictureBox();
            diceRoll2 = new PictureBox();
            groupBox1 = new GroupBox();
            rollDiceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gameBoardImage
            // 
            gameBoardImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameBoardImage.BackgroundImage = (Image)resources.GetObject("gameBoardImage.BackgroundImage");
            gameBoardImage.BackgroundImageLayout = ImageLayout.Stretch;
            gameBoardImage.Cursor = Cursors.No;
            gameBoardImage.Location = new Point(292, 12);
            gameBoardImage.MaximumSize = new Size(840, 840);
            gameBoardImage.MinimumSize = new Size(565, 565);
            gameBoardImage.Name = "gameBoardImage";
            gameBoardImage.Size = new Size(601, 569);
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
            propertiesGroupBox.Location = new Point(939, 146);
            propertiesGroupBox.Name = "propertiesGroupBox";
            propertiesGroupBox.Size = new Size(294, 422);
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
            label2.Location = new Point(939, 32);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 10;
            label2.Text = "Balance:";
            label2.Click += label2_Click_1;
            // 
            // balanceTextBox
            // 
            balanceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            balanceTextBox.Enabled = false;
            balanceTextBox.ForeColor = SystemColors.WindowText;
            balanceTextBox.Location = new Point(939, 63);
            balanceTextBox.Multiline = true;
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Size = new Size(294, 45);
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
            buyButton.Location = new Point(12, 41);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(224, 52);
            buyButton.TabIndex = 12;
            buyButton.Text = "Buy";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 430);
            label1.MaximumSize = new Size(208, 23);
            label1.Name = "label1";
            label1.Size = new Size(208, 19);
            label1.TabIndex = 13;
            label1.Text = "Get Out of Jail Free Cards:";
            label1.Click += label1_Click_1;
            // 
            // sellButton
            // 
            sellButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sellButton.BackColor = Color.Yellow;
            sellButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            sellButton.Location = new Point(12, 99);
            sellButton.Name = "sellButton";
            sellButton.Size = new Size(224, 52);
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
            nextTurnButton.Location = new Point(12, 157);
            nextTurnButton.Name = "nextTurnButton";
            nextTurnButton.Size = new Size(224, 52);
            nextTurnButton.TabIndex = 16;
            nextTurnButton.Text = "Next Turn";
            nextTurnButton.UseVisualStyleBackColor = false;
            // 
            // getOutOfJailFreeCards
            // 
            getOutOfJailFreeCards.Anchor = AnchorStyles.Left;
            getOutOfJailFreeCards.BackgroundImage = (Image)resources.GetObject("getOutOfJailFreeCards.BackgroundImage");
            getOutOfJailFreeCards.BackgroundImageLayout = ImageLayout.Stretch;
            getOutOfJailFreeCards.Location = new Point(12, 465);
            getOutOfJailFreeCards.MaximumSize = new Size(218, 226);
            getOutOfJailFreeCards.Name = "getOutOfJailFreeCards";
            getOutOfJailFreeCards.Size = new Size(218, 116);
            getOutOfJailFreeCards.TabIndex = 17;
            getOutOfJailFreeCards.TabStop = false;
            // 
            // diceRoll1
            // 
            diceRoll1.BackColor = Color.Transparent;
            diceRoll1.BackgroundImage = (Image)resources.GetObject("diceRoll1.BackgroundImage");
            diceRoll1.BackgroundImageLayout = ImageLayout.Stretch;
            diceRoll1.Location = new Point(26, 24);
            diceRoll1.Name = "diceRoll1";
            diceRoll1.Size = new Size(83, 79);
            diceRoll1.TabIndex = 18;
            diceRoll1.TabStop = false;
            diceRoll1.Click += diceRoll1_Click;
            // 
            // diceRoll2
            // 
            diceRoll2.BackColor = Color.Transparent;
            diceRoll2.BackgroundImage = (Image)resources.GetObject("diceRoll2.BackgroundImage");
            diceRoll2.BackgroundImageLayout = ImageLayout.Stretch;
            diceRoll2.Location = new Point(115, 24);
            diceRoll2.Name = "diceRoll2";
            diceRoll2.Size = new Size(83, 79);
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
            groupBox1.Location = new Point(12, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 119);
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
            rollDiceButton.Location = new Point(56, 352);
            rollDiceButton.Name = "rollDiceButton";
            rollDiceButton.Size = new Size(131, 43);
            rollDiceButton.TabIndex = 21;
            rollDiceButton.Text = "Roll Dice";
            rollDiceButton.UseVisualStyleBackColor = false;
            rollDiceButton.Click += button1_Click_2;
            // 
            // Gameboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1245, 654);
            Controls.Add(rollDiceButton);
            Controls.Add(groupBox1);
            Controls.Add(getOutOfJailFreeCards);
            Controls.Add(nextTurnButton);
            Controls.Add(sellButton);
            Controls.Add(label1);
            Controls.Add(buyButton);
            Controls.Add(balanceTextBox);
            Controls.Add(propertiesGroupBox);
            Controls.Add(label2);
            Controls.Add(gameBoardImage);
            Name = "Gameboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox gameBoardImage;
        private GroupBox propertiesGroupBox;
        private Label label2;
        private TextBox balanceTextBox;
        private Button buyButton;
        private Label label1;
        private Button sellButton;
        private Button nextTurnButton;
        private PictureBox getOutOfJailFreeCards;
        private PictureBox diceRoll1;
        private PictureBox diceRoll2;
        private GroupBox groupBox1;
        private Button rollDiceButton;
    }
}
