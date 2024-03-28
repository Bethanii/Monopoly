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
            textBox1 = new TextBox();
            buyButton = new Button();
            label1 = new Label();
            sellButton = new Button();
            nextTurnButton = new Button();
            getOutOfJailFreeCards = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).BeginInit();
            SuspendLayout();
            // 
            // gameBoardImage
            // 
            gameBoardImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameBoardImage.BackgroundImage = (Image)resources.GetObject("gameBoardImage.BackgroundImage");
            gameBoardImage.BackgroundImageLayout = ImageLayout.Stretch;
            gameBoardImage.Cursor = Cursors.No;
            gameBoardImage.Location = new Point(289, 12);
            gameBoardImage.MaximumSize = new Size(840, 840);
            gameBoardImage.MinimumSize = new Size(565, 565);
            gameBoardImage.Name = "gameBoardImage";
            gameBoardImage.Size = new Size(565, 565);
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
            propertiesGroupBox.Location = new Point(884, 140);
            propertiesGroupBox.Name = "propertiesGroupBox";
            propertiesGroupBox.Size = new Size(328, 422);
            propertiesGroupBox.TabIndex = 8;
            propertiesGroupBox.TabStop = false;
            propertiesGroupBox.Text = "Properties";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(884, 41);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 10;
            label2.Text = "Balance:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.Location = new Point(884, 72);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 45);
            textBox1.TabIndex = 11;
            // 
            // buyButton
            // 
            buyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 397);
            label1.MaximumSize = new Size(208, 23);
            label1.Name = "label1";
            label1.Size = new Size(208, 23);
            label1.TabIndex = 13;
            label1.Text = "Get Out of Jail Free Cards:";
            label1.Click += label1_Click_1;
            // 
            // sellButton
            // 
            sellButton.Anchor = AnchorStyles.Left;
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
            nextTurnButton.Anchor = AnchorStyles.Left;
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
            getOutOfJailFreeCards.Location = new Point(28, 423);
            getOutOfJailFreeCards.MaximumSize = new Size(208, 216);
            getOutOfJailFreeCards.Name = "getOutOfJailFreeCards";
            getOutOfJailFreeCards.Size = new Size(208, 116);
            getOutOfJailFreeCards.TabIndex = 17;
            getOutOfJailFreeCards.TabStop = false;
            // 
            // Gameboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1245, 654);
            Controls.Add(getOutOfJailFreeCards);
            Controls.Add(nextTurnButton);
            Controls.Add(sellButton);
            Controls.Add(label1);
            Controls.Add(buyButton);
            Controls.Add(textBox1);
            Controls.Add(propertiesGroupBox);
            Controls.Add(label2);
            Controls.Add(gameBoardImage);
            Name = "Gameboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox gameBoardImage;
        private GroupBox propertiesGroupBox;
        private Label label2;
        private TextBox textBox1;
        private Button buyButton;
        private Label label1;
        private Button sellButton;
        private Button nextTurnButton;
        private PictureBox getOutOfJailFreeCards;
    }
}
