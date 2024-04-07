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
            PictureBox atlanticAve;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameboard));
            propertiesGroupBox = new GroupBox();
            balanceLabel = new Label();
            balanceTextBox = new TextBox();
            buyButton = new Button();
            sellButton = new Button();
            nextTurnButton = new Button();
            getOutOfJailFreeCards = new PictureBox();
            diceRoll1 = new PictureBox();
            diceRoll2 = new PictureBox();
            diceGroupBox = new GroupBox();
            rollDiceButton = new Button();
            gameBoardImage = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            stCharlesPlace = new PictureBox();
            electricCompany = new PictureBox();
            virginiaAve = new PictureBox();
            communityChest2 = new PictureBox();
            tennesseeAve = new PictureBox();
            newYorkAve = new PictureBox();
            stJamesPlace = new PictureBox();
            pennsylvaniaRailroad = new PictureBox();
            statesAve = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            mediteraneanAve = new PictureBox();
            inJail = new PictureBox();
            connecticutAve = new PictureBox();
            goSpace = new PictureBox();
            readingRailroad = new PictureBox();
            incomeTax = new PictureBox();
            balticAve = new PictureBox();
            orientalAve = new PictureBox();
            chance2 = new PictureBox();
            communityChest = new PictureBox();
            pictureBox1 = new PictureBox();
            boRailroad = new PictureBox();
            illinoisAve = new PictureBox();
            indianaAve = new PictureBox();
            kentuckyAve = new PictureBox();
            freeParking = new PictureBox();
            chance1 = new PictureBox();
            ventorAve = new PictureBox();
            marvinGardens = new PictureBox();
            goToJail = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            atlanticAve = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)atlanticAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).BeginInit();
            diceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stCharlesPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)electricCompany).BeginInit();
            ((System.ComponentModel.ISupportInitialize)virginiaAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communityChest2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tennesseeAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newYorkAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stJamesPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pennsylvaniaRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statesAve).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediteraneanAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inJail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connecticutAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readingRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)incomeTax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)balticAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orientalAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communityChest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)illinoisAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indianaAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kentuckyAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)freeParking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventorAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)marvinGardens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goToJail).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // atlanticAve
            // 
            atlanticAve.BackColor = Color.IndianRed;
            atlanticAve.Location = new Point(281, 3);
            atlanticAve.Name = "atlanticAve";
            atlanticAve.Size = new Size(29, 94);
            atlanticAve.SizeMode = PictureBoxSizeMode.StretchImage;
            atlanticAve.TabIndex = 29;
            atlanticAve.TabStop = false;
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
            // balanceLabel
            // 
            balanceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            balanceLabel.BackColor = Color.Transparent;
            balanceLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            balanceLabel.ForeColor = SystemColors.ButtonHighlight;
            balanceLabel.Location = new Point(939, 32);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(91, 28);
            balanceLabel.TabIndex = 10;
            balanceLabel.Text = "Balance:";
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
            // 
            // diceGroupBox
            // 
            diceGroupBox.Anchor = AnchorStyles.Left;
            diceGroupBox.BackColor = Color.Transparent;
            diceGroupBox.Controls.Add(diceRoll2);
            diceGroupBox.Controls.Add(diceRoll1);
            diceGroupBox.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            diceGroupBox.ForeColor = SystemColors.ButtonFace;
            diceGroupBox.Location = new Point(12, 243);
            diceGroupBox.Name = "diceGroupBox";
            diceGroupBox.Size = new Size(224, 119);
            diceGroupBox.TabIndex = 20;
            diceGroupBox.TabStop = false;
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
            gameBoardImage.Location = new Point(0, 0);
            gameBoardImage.MinimumSize = new Size(565, 565);
            gameBoardImage.Name = "gameBoardImage";
            gameBoardImage.Size = new Size(592, 576);
            gameBoardImage.TabIndex = 2;
            gameBoardImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(gameBoardImage);
            panel1.Location = new Point(292, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 575);
            panel1.TabIndex = 23;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(stCharlesPlace, 0, 8);
            tableLayoutPanel4.Controls.Add(electricCompany, 0, 7);
            tableLayoutPanel4.Controls.Add(virginiaAve, 0, 5);
            tableLayoutPanel4.Controls.Add(communityChest2, 0, 2);
            tableLayoutPanel4.Controls.Add(tennesseeAve, 0, 1);
            tableLayoutPanel4.Controls.Add(newYorkAve, 0, 0);
            tableLayoutPanel4.Controls.Add(stJamesPlace, 0, 3);
            tableLayoutPanel4.Controls.Add(pennsylvaniaRailroad, 0, 4);
            tableLayoutPanel4.Controls.Add(statesAve, 0, 6);
            tableLayoutPanel4.Location = new Point(18, 92);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            tableLayoutPanel4.Size = new Size(102, 405);
            tableLayoutPanel4.TabIndex = 34;
            // 
            // stCharlesPlace
            // 
            stCharlesPlace.BackColor = Color.Cyan;
            stCharlesPlace.Location = new Point(3, 359);
            stCharlesPlace.Name = "stCharlesPlace";
            stCharlesPlace.Size = new Size(96, 43);
            stCharlesPlace.TabIndex = 40;
            stCharlesPlace.TabStop = false;
            // 
            // electricCompany
            // 
            electricCompany.BackColor = Color.NavajoWhite;
            electricCompany.Location = new Point(3, 318);
            electricCompany.Name = "electricCompany";
            electricCompany.Size = new Size(96, 35);
            electricCompany.TabIndex = 39;
            electricCompany.TabStop = false;
            // 
            // virginiaAve
            // 
            virginiaAve.BackColor = Color.NavajoWhite;
            virginiaAve.Location = new Point(3, 233);
            virginiaAve.Name = "virginiaAve";
            virginiaAve.Size = new Size(96, 33);
            virginiaAve.TabIndex = 37;
            virginiaAve.TabStop = false;
            // 
            // communityChest2
            // 
            communityChest2.BackColor = Color.Cyan;
            communityChest2.Location = new Point(3, 102);
            communityChest2.Name = "communityChest2";
            communityChest2.Size = new Size(96, 36);
            communityChest2.TabIndex = 2;
            communityChest2.TabStop = false;
            // 
            // tennesseeAve
            // 
            tennesseeAve.BackColor = Color.NavajoWhite;
            tennesseeAve.Location = new Point(3, 59);
            tennesseeAve.Name = "tennesseeAve";
            tennesseeAve.Size = new Size(96, 37);
            tennesseeAve.TabIndex = 1;
            tennesseeAve.TabStop = false;
            // 
            // newYorkAve
            // 
            newYorkAve.BackColor = Color.Cyan;
            newYorkAve.Location = new Point(3, 3);
            newYorkAve.Name = "newYorkAve";
            newYorkAve.Size = new Size(96, 50);
            newYorkAve.TabIndex = 0;
            newYorkAve.TabStop = false;
            // 
            // stJamesPlace
            // 
            stJamesPlace.BackColor = Color.NavajoWhite;
            stJamesPlace.Location = new Point(3, 144);
            stJamesPlace.Name = "stJamesPlace";
            stJamesPlace.Size = new Size(96, 39);
            stJamesPlace.TabIndex = 36;
            stJamesPlace.TabStop = false;
            // 
            // pennsylvaniaRailroad
            // 
            pennsylvaniaRailroad.BackColor = Color.Cyan;
            pennsylvaniaRailroad.Location = new Point(3, 189);
            pennsylvaniaRailroad.Name = "pennsylvaniaRailroad";
            pennsylvaniaRailroad.Size = new Size(96, 38);
            pennsylvaniaRailroad.TabIndex = 35;
            pennsylvaniaRailroad.TabStop = false;
            // 
            // statesAve
            // 
            statesAve.BackColor = Color.Cyan;
            statesAve.Location = new Point(3, 272);
            statesAve.Name = "statesAve";
            statesAve.Size = new Size(96, 40);
            statesAve.TabIndex = 38;
            statesAve.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel3.ColumnCount = 11;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 49F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel3.Controls.Add(pictureBox2, 0, 0);
            tableLayoutPanel3.Controls.Add(mediteraneanAve, 9, 0);
            tableLayoutPanel3.Controls.Add(inJail, 0, 0);
            tableLayoutPanel3.Controls.Add(connecticutAve, 0, 0);
            tableLayoutPanel3.Controls.Add(goSpace, 10, 0);
            tableLayoutPanel3.Controls.Add(readingRailroad, 4, 0);
            tableLayoutPanel3.Controls.Add(incomeTax, 5, 0);
            tableLayoutPanel3.Controls.Add(balticAve, 6, 0);
            tableLayoutPanel3.Controls.Add(orientalAve, 3, 0);
            tableLayoutPanel3.Controls.Add(chance2, 2, 0);
            tableLayoutPanel3.Controls.Add(communityChest, 8, 0);
            tableLayoutPanel3.Location = new Point(79, 491);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(440, 84);
            tableLayoutPanel3.TabIndex = 33;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MediumVioletRed;
            pictureBox2.Location = new Point(42, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 36;
            pictureBox2.TabStop = false;
            // 
            // mediteraneanAve
            // 
            mediteraneanAve.BackColor = Color.DarkTurquoise;
            mediteraneanAve.Location = new Point(342, 3);
            mediteraneanAve.Name = "mediteraneanAve";
            mediteraneanAve.Size = new Size(43, 78);
            mediteraneanAve.SizeMode = PictureBoxSizeMode.StretchImage;
            mediteraneanAve.TabIndex = 35;
            mediteraneanAve.TabStop = false;
            // 
            // inJail
            // 
            inJail.BackColor = Color.HotPink;
            inJail.Location = new Point(3, 3);
            inJail.Name = "inJail";
            inJail.Size = new Size(1, 78);
            inJail.SizeMode = PictureBoxSizeMode.StretchImage;
            inJail.TabIndex = 34;
            inJail.TabStop = false;
            // 
            // connecticutAve
            // 
            connecticutAve.BackColor = Color.DarkTurquoise;
            connecticutAve.Location = new Point(-11, 3);
            connecticutAve.Name = "connecticutAve";
            connecticutAve.Size = new Size(1, 78);
            connecticutAve.SizeMode = PictureBoxSizeMode.StretchImage;
            connecticutAve.TabIndex = 33;
            connecticutAve.TabStop = false;
            // 
            // goSpace
            // 
            goSpace.BackColor = Color.Violet;
            goSpace.Location = new Point(391, 3);
            goSpace.Name = "goSpace";
            goSpace.Size = new Size(43, 78);
            goSpace.SizeMode = PictureBoxSizeMode.StretchImage;
            goSpace.TabIndex = 30;
            goSpace.TabStop = false;
            // 
            // readingRailroad
            // 
            readingRailroad.BackColor = Color.HotPink;
            readingRailroad.Location = new Point(171, 3);
            readingRailroad.Name = "readingRailroad";
            readingRailroad.Size = new Size(34, 78);
            readingRailroad.SizeMode = PictureBoxSizeMode.StretchImage;
            readingRailroad.TabIndex = 25;
            readingRailroad.TabStop = false;
            // 
            // incomeTax
            // 
            incomeTax.BackColor = Color.IndianRed;
            incomeTax.Location = new Point(211, 3);
            incomeTax.Name = "incomeTax";
            incomeTax.Size = new Size(41, 78);
            incomeTax.SizeMode = PictureBoxSizeMode.StretchImage;
            incomeTax.TabIndex = 27;
            incomeTax.TabStop = false;
            // 
            // balticAve
            // 
            balticAve.BackColor = Color.MediumVioletRed;
            balticAve.Location = new Point(258, 3);
            balticAve.Name = "balticAve";
            balticAve.Size = new Size(34, 78);
            balticAve.SizeMode = PictureBoxSizeMode.StretchImage;
            balticAve.TabIndex = 26;
            balticAve.TabStop = false;
            // 
            // orientalAve
            // 
            orientalAve.BackColor = Color.IndianRed;
            orientalAve.Location = new Point(126, 3);
            orientalAve.Name = "orientalAve";
            orientalAve.Size = new Size(39, 78);
            orientalAve.SizeMode = PictureBoxSizeMode.StretchImage;
            orientalAve.TabIndex = 28;
            orientalAve.TabStop = false;
            // 
            // chance2
            // 
            chance2.BackColor = Color.LightYellow;
            chance2.Location = new Point(79, 3);
            chance2.Name = "chance2";
            chance2.Size = new Size(41, 78);
            chance2.SizeMode = PictureBoxSizeMode.StretchImage;
            chance2.TabIndex = 23;
            chance2.TabStop = false;
            // 
            // communityChest
            // 
            communityChest.BackColor = Color.IndianRed;
            communityChest.Location = new Point(298, 3);
            communityChest.Name = "communityChest";
            communityChest.Size = new Size(38, 78);
            communityChest.SizeMode = PictureBoxSizeMode.StretchImage;
            communityChest.TabIndex = 29;
            communityChest.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // boRailroad
            // 
            boRailroad.BackColor = Color.DarkTurquoise;
            boRailroad.Location = new Point(233, 3);
            boRailroad.Name = "boRailroad";
            boRailroad.Size = new Size(42, 94);
            boRailroad.SizeMode = PictureBoxSizeMode.StretchImage;
            boRailroad.TabIndex = 26;
            boRailroad.TabStop = false;
            // 
            // illinoisAve
            // 
            illinoisAve.BackColor = Color.IndianRed;
            illinoisAve.Location = new Point(187, 3);
            illinoisAve.Name = "illinoisAve";
            illinoisAve.Size = new Size(40, 94);
            illinoisAve.SizeMode = PictureBoxSizeMode.StretchImage;
            illinoisAve.TabIndex = 27;
            illinoisAve.TabStop = false;
            // 
            // indianaAve
            // 
            indianaAve.BackColor = Color.DarkTurquoise;
            indianaAve.Location = new Point(143, 3);
            indianaAve.Name = "indianaAve";
            indianaAve.Size = new Size(38, 94);
            indianaAve.SizeMode = PictureBoxSizeMode.StretchImage;
            indianaAve.TabIndex = 25;
            indianaAve.TabStop = false;
            // 
            // kentuckyAve
            // 
            kentuckyAve.BackColor = Color.DarkTurquoise;
            kentuckyAve.Location = new Point(44, 3);
            kentuckyAve.Name = "kentuckyAve";
            kentuckyAve.Size = new Size(46, 94);
            kentuckyAve.SizeMode = PictureBoxSizeMode.StretchImage;
            kentuckyAve.TabIndex = 22;
            kentuckyAve.TabStop = false;
            // 
            // freeParking
            // 
            freeParking.BackColor = Color.IndianRed;
            freeParking.Location = new Point(-61, 3);
            freeParking.Name = "freeParking";
            freeParking.Size = new Size(99, 94);
            freeParking.SizeMode = PictureBoxSizeMode.StretchImage;
            freeParking.TabIndex = 23;
            freeParking.TabStop = false;
            // 
            // chance1
            // 
            chance1.BackColor = Color.IndianRed;
            chance1.Location = new Point(96, 3);
            chance1.Name = "chance1";
            chance1.Size = new Size(41, 94);
            chance1.SizeMode = PictureBoxSizeMode.StretchImage;
            chance1.TabIndex = 28;
            chance1.TabStop = false;
            // 
            // ventorAve
            // 
            ventorAve.BackColor = Color.DarkTurquoise;
            ventorAve.Location = new Point(316, 3);
            ventorAve.Name = "ventorAve";
            ventorAve.Size = new Size(40, 94);
            ventorAve.SizeMode = PictureBoxSizeMode.StretchImage;
            ventorAve.TabIndex = 30;
            ventorAve.TabStop = false;
            // 
            // marvinGardens
            // 
            marvinGardens.BackColor = Color.IndianRed;
            marvinGardens.Location = new Point(363, 3);
            marvinGardens.Name = "marvinGardens";
            marvinGardens.Size = new Size(30, 94);
            marvinGardens.SizeMode = PictureBoxSizeMode.StretchImage;
            marvinGardens.TabIndex = 31;
            marvinGardens.TabStop = false;
            // 
            // goToJail
            // 
            goToJail.BackColor = Color.DarkTurquoise;
            goToJail.Location = new Point(399, 3);
            goToJail.Name = "goToJail";
            goToJail.Size = new Size(35, 94);
            goToJail.SizeMode = PictureBoxSizeMode.StretchImage;
            goToJail.TabIndex = 32;
            goToJail.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = SystemColors.ActiveCaptionText;
            tableLayoutPanel2.ColumnCount = 11;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 46F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.Controls.Add(goToJail, 10, 0);
            tableLayoutPanel2.Controls.Add(atlanticAve, 7, 0);
            tableLayoutPanel2.Controls.Add(chance1, 3, 0);
            tableLayoutPanel2.Controls.Add(freeParking, 1, 0);
            tableLayoutPanel2.Controls.Add(kentuckyAve, 2, 0);
            tableLayoutPanel2.Controls.Add(indianaAve, 4, 0);
            tableLayoutPanel2.Controls.Add(boRailroad, 6, 0);
            tableLayoutPanel2.Controls.Add(illinoisAve, 5, 0);
            tableLayoutPanel2.Controls.Add(marvinGardens, 9, 0);
            tableLayoutPanel2.Controls.Add(ventorAve, 8, 0);
            tableLayoutPanel2.Location = new Point(371, 29);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(437, 100);
            tableLayoutPanel2.TabIndex = 30;
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
            Controls.Add(diceGroupBox);
            Controls.Add(getOutOfJailFreeCards);
            Controls.Add(nextTurnButton);
            Controls.Add(sellButton);
            Controls.Add(buyButton);
            Controls.Add(balanceTextBox);
            Controls.Add(propertiesGroupBox);
            Controls.Add(balanceLabel);
            Name = "Gameboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)atlanticAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).EndInit();
            diceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stCharlesPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)electricCompany).EndInit();
            ((System.ComponentModel.ISupportInitialize)virginiaAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)communityChest2).EndInit();
            ((System.ComponentModel.ISupportInitialize)tennesseeAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)newYorkAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)stJamesPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)pennsylvaniaRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)statesAve).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediteraneanAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)inJail).EndInit();
            ((System.ComponentModel.ISupportInitialize)connecticutAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)goSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)readingRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)incomeTax).EndInit();
            ((System.ComponentModel.ISupportInitialize)balticAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)orientalAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance2).EndInit();
            ((System.ComponentModel.ISupportInitialize)communityChest).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)boRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)illinoisAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)indianaAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)kentuckyAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)freeParking).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventorAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)marvinGardens).EndInit();
            ((System.ComponentModel.ISupportInitialize)goToJail).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox propertiesGroupBox;
        private Label balanceLabel;
        private TextBox balanceTextBox;
        private Button buyButton;
        private Button sellButton;
        private Button nextTurnButton;
        private PictureBox getOutOfJailFreeCards;
        private PictureBox diceRoll1;
        private PictureBox diceRoll2;
        private GroupBox diceGroupBox;
        private Button rollDiceButton;
        private PictureBox gameBoardImage;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox statesAve;
        private PictureBox electricCompany;
        private PictureBox stCharlesPlace;
        private TableLayoutPanel tableLayoutPanel3;
        private PictureBox goSpace;
        private PictureBox communityChest;
        private PictureBox chance2;
        private PictureBox readingRailroad;
        private PictureBox incomeTax;
        private PictureBox balticAve;
        private PictureBox orientalAve;
        private PictureBox boRailroad;
        private PictureBox illinoisAve;
        private PictureBox indianaAve;
        private PictureBox kentuckyAve;
        private PictureBox freeParking;
        private PictureBox chance1;
        private PictureBox atlanticAve;
        private PictureBox ventorAve;
        private PictureBox marvinGardens;
        private PictureBox goToJail;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox connecticutAve;
        private PictureBox inJail;
        private PictureBox mediteraneanAve;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox virginiaAve;
        private PictureBox pennsylvaniaRailroad;
        private PictureBox communityChest2;
        private PictureBox tennesseeAve;
        private PictureBox newYorkAve;
        private PictureBox stJamesPlace;
        private PictureBox pictureBox2;
    }
}
