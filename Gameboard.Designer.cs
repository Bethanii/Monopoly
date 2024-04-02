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
            gameBoardImage = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox21 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox11 = new PictureBox();
            pictureBox16 = new PictureBox();
            pictureBox5 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox8 = new PictureBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox22 = new PictureBox();
            pictureBox23 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            pictureBox26 = new PictureBox();
            pictureBox27 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).BeginInit();
            SuspendLayout();
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
            rollDiceButton.Click += rollDiceButton_Click;
            // 
            // gameBoardImage
            // 
            gameBoardImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameBoardImage.BackgroundImage = (Image)resources.GetObject("gameBoardImage.BackgroundImage");
            gameBoardImage.BackgroundImageLayout = ImageLayout.Stretch;
            gameBoardImage.Cursor = Cursors.No;
            gameBoardImage.Location = new Point(0, -3);
            gameBoardImage.MinimumSize = new Size(565, 565);
            gameBoardImage.Name = "gameBoardImage";
            gameBoardImage.Size = new Size(594, 578);
            gameBoardImage.TabIndex = 2;
            gameBoardImage.TabStop = false;
            gameBoardImage.Click += gameBoardImage_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(gameBoardImage);
            panel1.Location = new Point(292, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 575);
            panel1.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.50794F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.15873F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel1.Controls.Add(pictureBox6, 5, 0);
            tableLayoutPanel1.Controls.Add(pictureBox23, 7, 0);
            tableLayoutPanel1.Controls.Add(pictureBox21, 8, 0);
            tableLayoutPanel1.Controls.Add(pictureBox3, 10, 0);
            tableLayoutPanel1.Controls.Add(pictureBox20, 6, 0);
            tableLayoutPanel1.Controls.Add(pictureBox19, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox7, 3, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox18, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox11, 9, 0);
            tableLayoutPanel1.Controls.Add(pictureBox16, 4, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 497);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(594, 78);
            tableLayoutPanel1.TabIndex = 29;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = Color.DarkTurquoise;
            pictureBox21.Location = new Point(443, 3);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(45, 72);
            pictureBox21.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox21.TabIndex = 31;
            pictureBox21.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Location = new Point(535, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 72);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.BackColor = Color.Gold;
            pictureBox20.Location = new Point(334, 3);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(56, 72);
            pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox20.TabIndex = 30;
            pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = Color.IndianRed;
            pictureBox19.Location = new Point(116, 3);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(50, 72);
            pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox19.TabIndex = 25;
            pictureBox19.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.DarkTurquoise;
            pictureBox6.Location = new Point(282, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(46, 72);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.MidnightBlue;
            pictureBox7.Location = new Point(172, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(54, 72);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 22;
            pictureBox7.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Teal;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 72);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.SaddleBrown;
            pictureBox18.Location = new Point(65, 3);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(45, 72);
            pictureBox18.TabIndex = 24;
            pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.IndianRed;
            pictureBox17.Location = new Point(93, 3);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(99, 94);
            pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox17.TabIndex = 23;
            pictureBox17.TabStop = false;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Gold;
            pictureBox11.Location = new Point(494, 3);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(35, 72);
            pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox11.TabIndex = 30;
            pictureBox11.TabStop = false;
            // 
            // pictureBox16
            // 
            pictureBox16.BackColor = Color.IndianRed;
            pictureBox16.Location = new Point(232, 3);
            pictureBox16.Name = "pictureBox16";
            pictureBox16.Size = new Size(44, 72);
            pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox16.TabIndex = 16;
            pictureBox16.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.SkyBlue;
            pictureBox5.Location = new Point(384, 657);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 73);
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Location = new Point(129, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 73);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.IndianRed;
            pictureBox8.Location = new Point(-117, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(44, 73);
            pictureBox8.TabIndex = 7;
            pictureBox8.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.Size = new Size(200, 100);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.IndianRed;
            pictureBox9.Location = new Point(129, 3);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(69, 67);
            pictureBox9.TabIndex = 9;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.IndianRed;
            pictureBox10.Location = new Point(3, 3);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(1, 67);
            pictureBox10.TabIndex = 8;
            pictureBox10.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel2.ColumnCount = 11;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 61F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(pictureBox27, 10, 0);
            tableLayoutPanel2.Controls.Add(pictureBox26, 9, 0);
            tableLayoutPanel2.Controls.Add(pictureBox25, 8, 0);
            tableLayoutPanel2.Controls.Add(pictureBox24, 7, 0);
            tableLayoutPanel2.Controls.Add(pictureBox15, 3, 0);
            tableLayoutPanel2.Controls.Add(pictureBox4, 0, 0);
            tableLayoutPanel2.Controls.Add(pictureBox17, 1, 0);
            tableLayoutPanel2.Controls.Add(pictureBox22, 2, 0);
            tableLayoutPanel2.Controls.Add(pictureBox12, 4, 0);
            tableLayoutPanel2.Controls.Add(pictureBox14, 5, 0);
            tableLayoutPanel2.Controls.Add(pictureBox13, 6, 0);
            tableLayoutPanel2.Location = new Point(292, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(591, 100);
            tableLayoutPanel2.TabIndex = 30;
            // 
            // pictureBox22
            // 
            pictureBox22.BackColor = Color.DarkTurquoise;
            pictureBox22.Location = new Point(198, 3);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(55, 94);
            pictureBox22.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox22.TabIndex = 22;
            pictureBox22.TabStop = false;
            pictureBox22.Click += pictureBox22_Click;
            // 
            // pictureBox23
            // 
            pictureBox23.BackColor = Color.IndianRed;
            pictureBox23.Location = new Point(396, 3);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(41, 72);
            pictureBox23.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox23.TabIndex = 24;
            pictureBox23.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkTurquoise;
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 94);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.DarkTurquoise;
            pictureBox12.Location = new Point(454, 3);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(14, 94);
            pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox12.TabIndex = 25;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.DarkTurquoise;
            pictureBox13.Location = new Point(494, 3);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(14, 94);
            pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox13.TabIndex = 26;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.IndianRed;
            pictureBox14.Location = new Point(474, 3);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(14, 94);
            pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox14.TabIndex = 27;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.IndianRed;
            pictureBox15.Location = new Point(259, 3);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(189, 94);
            pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox15.TabIndex = 28;
            pictureBox15.TabStop = false;
            // 
            // pictureBox24
            // 
            pictureBox24.BackColor = Color.IndianRed;
            pictureBox24.Location = new Point(514, 3);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(14, 94);
            pictureBox24.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox24.TabIndex = 29;
            pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            pictureBox25.BackColor = Color.DarkTurquoise;
            pictureBox25.Location = new Point(534, 3);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(14, 94);
            pictureBox25.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox25.TabIndex = 30;
            pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            pictureBox26.BackColor = Color.IndianRed;
            pictureBox26.Location = new Point(554, 3);
            pictureBox26.Name = "pictureBox26";
            pictureBox26.Size = new Size(14, 94);
            pictureBox26.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox26.TabIndex = 31;
            pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            pictureBox27.BackColor = Color.DarkTurquoise;
            pictureBox27.Location = new Point(574, 3);
            pictureBox27.Name = "pictureBox27";
            pictureBox27.Size = new Size(14, 94);
            pictureBox27.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox27.TabIndex = 32;
            pictureBox27.TabStop = false;
            // 
            // Gameboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1245, 637);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(rollDiceButton);
            Controls.Add(groupBox1);
            Controls.Add(getOutOfJailFreeCards);
            Controls.Add(nextTurnButton);
            Controls.Add(sellButton);
            Controls.Add(buyButton);
            Controls.Add(balanceTextBox);
            Controls.Add(propertiesGroupBox);
            Controls.Add(label2);
            Name = "Gameboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox16).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox26).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox27).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private PictureBox gameBoardImage;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox8;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private TableLayoutPanel tableLayoutPanel9;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox21;
        private PictureBox pictureBox20;
        private PictureBox pictureBox11;
        private PictureBox pictureBox23;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox22;
        private PictureBox pictureBox27;
        private PictureBox pictureBox26;
        private PictureBox pictureBox25;
        private PictureBox pictureBox24;
    }
}
