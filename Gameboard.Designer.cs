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
            topPanel = new TableLayoutPanel();
            goToJailSpace = new PictureBox();
            marvinGardens = new PictureBox();
            waterWorks = new PictureBox();
            ventorAve = new PictureBox();
            atlanticAve = new PictureBox();
            boRailroad = new PictureBox();
            illinoisAve = new PictureBox();
            indianaAve = new PictureBox();
            chance1 = new PictureBox();
            kentuckyAve = new PictureBox();
            freeParkingSpace = new PictureBox();
            bottomPanel = new TableLayoutPanel();
            goSpace = new PictureBox();
            mediterraneanAve = new PictureBox();
            communityChest2 = new PictureBox();
            balticAve = new PictureBox();
            incomeTax = new PictureBox();
            readingRailroad = new PictureBox();
            orientalAve = new PictureBox();
            chance3 = new PictureBox();
            vermontAve = new PictureBox();
            connecticutAve = new PictureBox();
            inJailSpace = new PictureBox();
            rightPanel = new TableLayoutPanel();
            parkPlace = new PictureBox();
            chance2 = new PictureBox();
            luxuryTax = new PictureBox();
            pennsylvaniaAve = new PictureBox();
            shortLine = new PictureBox();
            communityChest1 = new PictureBox();
            pacificAve = new PictureBox();
            northCarolinaAve = new PictureBox();
            boardwalk = new PictureBox();
            leftPanel = new TableLayoutPanel();
            stCharlesPlace = new PictureBox();
            virginiaAve = new PictureBox();
            newYorkAve = new PictureBox();
            stJamesPlace = new PictureBox();
            communityChest3 = new PictureBox();
            statesAve = new PictureBox();
            tennesseeAve = new PictureBox();
            pennsylvaniaRailroad = new PictureBox();
            electricCompany = new PictureBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox11 = new PictureBox();
            pictureBox12 = new PictureBox();
            pictureBox13 = new PictureBox();
            pictureBox14 = new PictureBox();
            pictureBox15 = new PictureBox();
            pictureBox17 = new PictureBox();
            pictureBox18 = new PictureBox();
            pictureBox19 = new PictureBox();
            pictureBox20 = new PictureBox();
            pictureBox21 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox22 = new PictureBox();
            pictureBox23 = new PictureBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            pictureBox24 = new PictureBox();
            pictureBox25 = new PictureBox();
            PlayerTurnLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).BeginInit();
            diceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            panel1.SuspendLayout();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)goToJailSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)marvinGardens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)waterWorks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventorAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atlanticAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)illinoisAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indianaAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kentuckyAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)freeParkingSpace).BeginInit();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)goSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediterraneanAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communityChest2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)balticAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)incomeTax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readingRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orientalAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vermontAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connecticutAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inJailSpace).BeginInit();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parkPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)luxuryTax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pennsylvaniaAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shortLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communityChest1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pacificAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)northCarolinaAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boardwalk).BeginInit();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)stCharlesPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)virginiaAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)newYorkAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stJamesPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communityChest3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)statesAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tennesseeAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pennsylvaniaRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)electricCompany).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox22).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox24).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).BeginInit();
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
            buyButton.Click += buyButton_Click;
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
            nextTurnButton.Click += nextTurnButton_Click;
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
            gameBoardImage.Size = new Size(592, 575);
            gameBoardImage.TabIndex = 2;
            gameBoardImage.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(topPanel);
            panel1.Controls.Add(bottomPanel);
            panel1.Controls.Add(rightPanel);
            panel1.Controls.Add(leftPanel);
            panel1.Controls.Add(gameBoardImage);
            panel1.Location = new Point(292, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 575);
            panel1.TabIndex = 23;
            // 
            // topPanel
            // 
            topPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topPanel.BackColor = Color.Transparent;
            topPanel.ColumnCount = 11;
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.901638F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.098362F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 56F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            topPanel.Controls.Add(goToJailSpace, 10, 0);
            topPanel.Controls.Add(marvinGardens, 9, 0);
            topPanel.Controls.Add(waterWorks, 8, 0);
            topPanel.Controls.Add(ventorAve, 7, 0);
            topPanel.Controls.Add(atlanticAve, 6, 0);
            topPanel.Controls.Add(boRailroad, 5, 0);
            topPanel.Controls.Add(illinoisAve, 4, 0);
            topPanel.Controls.Add(indianaAve, 3, 0);
            topPanel.Controls.Add(chance1, 2, 0);
            topPanel.Controls.Add(kentuckyAve, 1, 0);
            topPanel.Controls.Add(freeParkingSpace, 0, 0);
            topPanel.Location = new Point(42, 3);
            topPanel.MinimumSize = new Size(320, 100);
            topPanel.Name = "topPanel";
            topPanel.RowCount = 1;
            topPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.Size = new Size(519, 100);
            topPanel.TabIndex = 43;
            // 
            // goToJailSpace
            // 
            goToJailSpace.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            goToJailSpace.BackColor = Color.Transparent;
            goToJailSpace.Location = new Point(470, 3);
            goToJailSpace.Name = "goToJailSpace";
            goToJailSpace.Size = new Size(46, 94);
            goToJailSpace.TabIndex = 41;
            goToJailSpace.TabStop = false;
            // 
            // marvinGardens
            // 
            marvinGardens.BackColor = Color.Transparent;
            marvinGardens.Location = new Point(431, 3);
            marvinGardens.Name = "marvinGardens";
            marvinGardens.Size = new Size(33, 94);
            marvinGardens.TabIndex = 38;
            marvinGardens.TabStop = false;
            // 
            // waterWorks
            // 
            waterWorks.BackColor = Color.Transparent;
            waterWorks.Location = new Point(386, 3);
            waterWorks.Name = "waterWorks";
            waterWorks.Size = new Size(39, 94);
            waterWorks.TabIndex = 38;
            waterWorks.TabStop = false;
            // 
            // ventorAve
            // 
            ventorAve.BackColor = Color.Transparent;
            ventorAve.Location = new Point(352, 3);
            ventorAve.Name = "ventorAve";
            ventorAve.Size = new Size(28, 94);
            ventorAve.TabIndex = 38;
            ventorAve.TabStop = false;
            // 
            // atlanticAve
            // 
            atlanticAve.BackColor = Color.Transparent;
            atlanticAve.Location = new Point(305, 3);
            atlanticAve.Name = "atlanticAve";
            atlanticAve.Size = new Size(41, 94);
            atlanticAve.TabIndex = 38;
            atlanticAve.TabStop = false;
            // 
            // boRailroad
            // 
            boRailroad.BackColor = Color.Transparent;
            boRailroad.Location = new Point(262, 3);
            boRailroad.Name = "boRailroad";
            boRailroad.Size = new Size(37, 94);
            boRailroad.TabIndex = 38;
            boRailroad.TabStop = false;
            // 
            // illinoisAve
            // 
            illinoisAve.BackColor = Color.Transparent;
            illinoisAve.Location = new Point(218, 3);
            illinoisAve.Name = "illinoisAve";
            illinoisAve.Size = new Size(38, 94);
            illinoisAve.TabIndex = 42;
            illinoisAve.TabStop = false;
            // 
            // indianaAve
            // 
            indianaAve.BackColor = Color.Transparent;
            indianaAve.Location = new Point(168, 3);
            indianaAve.Name = "indianaAve";
            indianaAve.Size = new Size(44, 94);
            indianaAve.TabIndex = 38;
            indianaAve.TabStop = false;
            // 
            // chance1
            // 
            chance1.BackColor = Color.Transparent;
            chance1.Location = new Point(112, 3);
            chance1.Name = "chance1";
            chance1.Size = new Size(50, 94);
            chance1.TabIndex = 39;
            chance1.TabStop = false;
            // 
            // kentuckyAve
            // 
            kentuckyAve.BackColor = Color.Transparent;
            kentuckyAve.Location = new Point(53, 3);
            kentuckyAve.Name = "kentuckyAve";
            kentuckyAve.Size = new Size(53, 94);
            kentuckyAve.TabIndex = 38;
            kentuckyAve.TabStop = false;
            // 
            // freeParkingSpace
            // 
            freeParkingSpace.Location = new Point(3, 3);
            freeParkingSpace.Name = "freeParkingSpace";
            freeParkingSpace.Size = new Size(44, 94);
            freeParkingSpace.TabIndex = 38;
            freeParkingSpace.TabStop = false;
            // 
            // bottomPanel
            // 
            bottomPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bottomPanel.BackColor = Color.Transparent;
            bottomPanel.ColumnCount = 11;
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.242424F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.757576F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 53F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 47F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 41F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            bottomPanel.Controls.Add(goSpace, 10, 0);
            bottomPanel.Controls.Add(mediterraneanAve, 9, 0);
            bottomPanel.Controls.Add(communityChest2, 8, 0);
            bottomPanel.Controls.Add(balticAve, 7, 0);
            bottomPanel.Controls.Add(incomeTax, 6, 0);
            bottomPanel.Controls.Add(readingRailroad, 5, 0);
            bottomPanel.Controls.Add(orientalAve, 4, 0);
            bottomPanel.Controls.Add(chance3, 3, 0);
            bottomPanel.Controls.Add(vermontAve, 2, 0);
            bottomPanel.Controls.Add(connecticutAve, 1, 0);
            bottomPanel.Controls.Add(inJailSpace, 0, 0);
            bottomPanel.Location = new Point(39, 460);
            bottomPanel.MinimumSize = new Size(320, 100);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.RowCount = 1;
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.Size = new Size(525, 115);
            bottomPanel.TabIndex = 37;
            // 
            // goSpace
            // 
            goSpace.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            goSpace.BackColor = Color.Transparent;
            goSpace.Location = new Point(476, 3);
            goSpace.Name = "goSpace";
            goSpace.Size = new Size(46, 109);
            goSpace.TabIndex = 41;
            goSpace.TabStop = false;
            // 
            // mediterraneanAve
            // 
            mediterraneanAve.BackColor = Color.Transparent;
            mediterraneanAve.Location = new Point(435, 3);
            mediterraneanAve.Name = "mediterraneanAve";
            mediterraneanAve.Size = new Size(35, 109);
            mediterraneanAve.TabIndex = 38;
            mediterraneanAve.TabStop = false;
            // 
            // communityChest2
            // 
            communityChest2.BackColor = Color.Transparent;
            communityChest2.Location = new Point(388, 3);
            communityChest2.Name = "communityChest2";
            communityChest2.Size = new Size(41, 109);
            communityChest2.TabIndex = 38;
            communityChest2.TabStop = false;
            // 
            // balticAve
            // 
            balticAve.BackColor = Color.Transparent;
            balticAve.Location = new Point(346, 3);
            balticAve.Name = "balticAve";
            balticAve.Size = new Size(36, 109);
            balticAve.TabIndex = 38;
            balticAve.TabStop = false;
            // 
            // incomeTax
            // 
            incomeTax.BackColor = Color.Transparent;
            incomeTax.Location = new Point(311, 3);
            incomeTax.Name = "incomeTax";
            incomeTax.Size = new Size(29, 109);
            incomeTax.TabIndex = 38;
            incomeTax.TabStop = false;
            // 
            // readingRailroad
            // 
            readingRailroad.BackColor = Color.Transparent;
            readingRailroad.Location = new Point(270, 3);
            readingRailroad.Name = "readingRailroad";
            readingRailroad.Size = new Size(35, 109);
            readingRailroad.TabIndex = 38;
            readingRailroad.TabStop = false;
            // 
            // orientalAve
            // 
            orientalAve.BackColor = Color.Transparent;
            orientalAve.Location = new Point(220, 3);
            orientalAve.Name = "orientalAve";
            orientalAve.Size = new Size(44, 109);
            orientalAve.TabIndex = 42;
            orientalAve.TabStop = false;
            // 
            // chance3
            // 
            chance3.BackColor = Color.Transparent;
            chance3.Location = new Point(167, 3);
            chance3.Name = "chance3";
            chance3.Size = new Size(47, 109);
            chance3.TabIndex = 38;
            chance3.TabStop = false;
            // 
            // vermontAve
            // 
            vermontAve.BackColor = Color.Transparent;
            vermontAve.Location = new Point(114, 3);
            vermontAve.Name = "vermontAve";
            vermontAve.Size = new Size(47, 109);
            vermontAve.TabIndex = 39;
            vermontAve.TabStop = false;
            // 
            // connecticutAve
            // 
            connecticutAve.BackColor = Color.Transparent;
            connecticutAve.Location = new Point(52, 3);
            connecticutAve.Name = "connecticutAve";
            connecticutAve.Size = new Size(56, 109);
            connecticutAve.TabIndex = 38;
            connecticutAve.TabStop = false;
            // 
            // inJailSpace
            // 
            inJailSpace.Location = new Point(3, 3);
            inJailSpace.Name = "inJailSpace";
            inJailSpace.Size = new Size(43, 109);
            inJailSpace.TabIndex = 38;
            inJailSpace.TabStop = false;
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightPanel.BackColor = Color.Transparent;
            rightPanel.ColumnCount = 1;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rightPanel.Controls.Add(parkPlace, 0, 6);
            rightPanel.Controls.Add(chance2, 0, 5);
            rightPanel.Controls.Add(luxuryTax, 0, 7);
            rightPanel.Controls.Add(pennsylvaniaAve, 0, 3);
            rightPanel.Controls.Add(shortLine, 0, 4);
            rightPanel.Controls.Add(communityChest1, 0, 2);
            rightPanel.Controls.Add(pacificAve, 0, 0);
            rightPanel.Controls.Add(northCarolinaAve, 0, 1);
            rightPanel.Controls.Add(boardwalk, 0, 8);
            rightPanel.Location = new Point(453, 106);
            rightPanel.Name = "rightPanel";
            rightPanel.RowCount = 8;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 51.31579F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.68421F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rightPanel.Size = new Size(108, 351);
            rightPanel.TabIndex = 35;
            // 
            // parkPlace
            // 
            parkPlace.BackColor = Color.Transparent;
            parkPlace.Location = new Point(3, 266);
            parkPlace.Name = "parkPlace";
            parkPlace.Size = new Size(102, 26);
            parkPlace.TabIndex = 42;
            parkPlace.TabStop = false;
            // 
            // chance2
            // 
            chance2.BackColor = Color.Transparent;
            chance2.Location = new Point(3, 228);
            chance2.Name = "chance2";
            chance2.Size = new Size(102, 32);
            chance2.TabIndex = 37;
            chance2.TabStop = false;
            // 
            // luxuryTax
            // 
            luxuryTax.BackColor = Color.Transparent;
            luxuryTax.Location = new Point(3, 298);
            luxuryTax.Name = "luxuryTax";
            luxuryTax.Size = new Size(102, 29);
            luxuryTax.TabIndex = 36;
            luxuryTax.TabStop = false;
            // 
            // pennsylvaniaAve
            // 
            pennsylvaniaAve.BackColor = Color.Transparent;
            pennsylvaniaAve.Location = new Point(3, 142);
            pennsylvaniaAve.Name = "pennsylvaniaAve";
            pennsylvaniaAve.Size = new Size(102, 35);
            pennsylvaniaAve.TabIndex = 38;
            pennsylvaniaAve.TabStop = false;
            // 
            // shortLine
            // 
            shortLine.BackColor = Color.Transparent;
            shortLine.Location = new Point(3, 183);
            shortLine.Name = "shortLine";
            shortLine.Size = new Size(102, 37);
            shortLine.TabIndex = 38;
            shortLine.TabStop = false;
            // 
            // communityChest1
            // 
            communityChest1.BackColor = Color.Transparent;
            communityChest1.Location = new Point(3, 108);
            communityChest1.Name = "communityChest1";
            communityChest1.Size = new Size(102, 28);
            communityChest1.TabIndex = 39;
            communityChest1.TabStop = false;
            // 
            // pacificAve
            // 
            pacificAve.BackColor = Color.Transparent;
            pacificAve.Location = new Point(3, 3);
            pacificAve.Name = "pacificAve";
            pacificAve.Size = new Size(102, 48);
            pacificAve.TabIndex = 40;
            pacificAve.TabStop = false;
            // 
            // northCarolinaAve
            // 
            northCarolinaAve.BackColor = Color.Transparent;
            northCarolinaAve.Location = new Point(3, 57);
            northCarolinaAve.Name = "northCarolinaAve";
            northCarolinaAve.Size = new Size(102, 45);
            northCarolinaAve.TabIndex = 39;
            northCarolinaAve.TabStop = false;
            // 
            // boardwalk
            // 
            boardwalk.BackColor = Color.Transparent;
            boardwalk.Location = new Point(3, 333);
            boardwalk.Name = "boardwalk";
            boardwalk.Size = new Size(102, 15);
            boardwalk.TabIndex = 44;
            boardwalk.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            leftPanel.BackColor = Color.Transparent;
            leftPanel.ColumnCount = 1;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftPanel.Controls.Add(stCharlesPlace, 0, 8);
            leftPanel.Controls.Add(virginiaAve, 0, 5);
            leftPanel.Controls.Add(newYorkAve, 0, 0);
            leftPanel.Controls.Add(stJamesPlace, 0, 3);
            leftPanel.Controls.Add(communityChest3, 0, 2);
            leftPanel.Controls.Add(statesAve, 0, 6);
            leftPanel.Controls.Add(tennesseeAve, 0, 1);
            leftPanel.Controls.Add(pennsylvaniaRailroad, 0, 4);
            leftPanel.Controls.Add(electricCompany, 0, 7);
            leftPanel.Location = new Point(18, 114);
            leftPanel.Name = "leftPanel";
            leftPanel.RowCount = 9;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            leftPanel.Size = new Size(107, 340);
            leftPanel.TabIndex = 34;
            // 
            // stCharlesPlace
            // 
            stCharlesPlace.BackColor = Color.Transparent;
            stCharlesPlace.Location = new Point(3, 307);
            stCharlesPlace.Name = "stCharlesPlace";
            stCharlesPlace.Size = new Size(101, 30);
            stCharlesPlace.TabIndex = 42;
            stCharlesPlace.TabStop = false;
            // 
            // virginiaAve
            // 
            virginiaAve.BackColor = Color.Transparent;
            virginiaAve.Location = new Point(3, 182);
            virginiaAve.Name = "virginiaAve";
            virginiaAve.Size = new Size(101, 36);
            virginiaAve.TabIndex = 37;
            virginiaAve.TabStop = false;
            // 
            // newYorkAve
            // 
            newYorkAve.BackColor = Color.Transparent;
            newYorkAve.Location = new Point(3, 3);
            newYorkAve.Name = "newYorkAve";
            newYorkAve.Size = new Size(101, 26);
            newYorkAve.TabIndex = 0;
            newYorkAve.TabStop = false;
            // 
            // stJamesPlace
            // 
            stJamesPlace.BackColor = Color.Transparent;
            stJamesPlace.Location = new Point(3, 104);
            stJamesPlace.Name = "stJamesPlace";
            stJamesPlace.Size = new Size(101, 28);
            stJamesPlace.TabIndex = 36;
            stJamesPlace.TabStop = false;
            // 
            // communityChest3
            // 
            communityChest3.BackColor = Color.Transparent;
            communityChest3.Location = new Point(3, 68);
            communityChest3.Name = "communityChest3";
            communityChest3.Size = new Size(101, 30);
            communityChest3.TabIndex = 2;
            communityChest3.TabStop = false;
            // 
            // statesAve
            // 
            statesAve.BackColor = Color.Transparent;
            statesAve.Location = new Point(3, 224);
            statesAve.Name = "statesAve";
            statesAve.Size = new Size(101, 35);
            statesAve.TabIndex = 38;
            statesAve.TabStop = false;
            // 
            // tennesseeAve
            // 
            tennesseeAve.BackColor = Color.Transparent;
            tennesseeAve.Location = new Point(3, 35);
            tennesseeAve.Name = "tennesseeAve";
            tennesseeAve.Size = new Size(101, 27);
            tennesseeAve.TabIndex = 1;
            tennesseeAve.TabStop = false;
            // 
            // pennsylvaniaRailroad
            // 
            pennsylvaniaRailroad.BackColor = Color.Transparent;
            pennsylvaniaRailroad.Location = new Point(3, 138);
            pennsylvaniaRailroad.Name = "pennsylvaniaRailroad";
            pennsylvaniaRailroad.Size = new Size(101, 38);
            pennsylvaniaRailroad.TabIndex = 35;
            pennsylvaniaRailroad.TabStop = false;
            // 
            // electricCompany
            // 
            electricCompany.BackColor = Color.Transparent;
            electricCompany.Location = new Point(3, 265);
            electricCompany.Name = "electricCompany";
            electricCompany.Size = new Size(101, 36);
            electricCompany.TabIndex = 42;
            electricCompany.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 9);
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(pictureBox11, 0, 6);
            tableLayoutPanel4.Controls.Add(pictureBox12, 0, 7);
            tableLayoutPanel4.Controls.Add(pictureBox13, 0, 5);
            tableLayoutPanel4.Controls.Add(pictureBox14, 0, 3);
            tableLayoutPanel4.Controls.Add(pictureBox15, 0, 4);
            tableLayoutPanel4.Controls.Add(pictureBox17, 0, 2);
            tableLayoutPanel4.Controls.Add(pictureBox18, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox19, 0, 1);
            tableLayoutPanel4.Controls.Add(pictureBox20, 0, 8);
            tableLayoutPanel4.Location = new Point(95, 183);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 51.31579F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 48.68421F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel4.Size = new Size(102, 14);
            tableLayoutPanel4.TabIndex = 43;
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            pictureBox11.Location = new Point(3, -91);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(96, 26);
            pictureBox11.TabIndex = 42;
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            pictureBox12.Location = new Point(3, -59);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(96, 29);
            pictureBox12.TabIndex = 36;
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            pictureBox13.Location = new Point(3, -129);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(96, 32);
            pictureBox13.TabIndex = 37;
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Transparent;
            pictureBox14.Location = new Point(3, -215);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(96, 35);
            pictureBox14.TabIndex = 38;
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            pictureBox15.Location = new Point(3, -174);
            pictureBox15.Name = "pictureBox15";
            pictureBox15.Size = new Size(96, 37);
            pictureBox15.TabIndex = 38;
            pictureBox15.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.Transparent;
            pictureBox17.Location = new Point(3, -249);
            pictureBox17.Name = "pictureBox17";
            pictureBox17.Size = new Size(96, 28);
            pictureBox17.TabIndex = 39;
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.Transparent;
            pictureBox18.Location = new Point(3, 3);
            pictureBox18.Name = "pictureBox18";
            pictureBox18.Size = new Size(96, 1);
            pictureBox18.TabIndex = 40;
            pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = Color.Transparent;
            pictureBox19.Location = new Point(3, -126);
            pictureBox19.Name = "pictureBox19";
            pictureBox19.Size = new Size(96, 1);
            pictureBox19.TabIndex = 39;
            pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.BackColor = Color.Transparent;
            pictureBox20.Location = new Point(3, -24);
            pictureBox20.Name = "pictureBox20";
            pictureBox20.Size = new Size(96, 36);
            pictureBox20.TabIndex = 38;
            pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = Color.Transparent;
            pictureBox21.Location = new Point(3, 3);
            pictureBox21.Name = "pictureBox21";
            pictureBox21.Size = new Size(102, 26);
            pictureBox21.TabIndex = 42;
            pictureBox21.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 11;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.901638F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.098362F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(pictureBox22, 10, 0);
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // pictureBox22
            // 
            pictureBox22.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox22.BackColor = Color.Transparent;
            pictureBox22.Location = new Point(184, 3);
            pictureBox22.Name = "pictureBox22";
            pictureBox22.Size = new Size(14, 94);
            pictureBox22.TabIndex = 41;
            pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            pictureBox23.BackColor = Color.Transparent;
            pictureBox23.Location = new Point(164, 3);
            pictureBox23.Name = "pictureBox23";
            pictureBox23.Size = new Size(14, 94);
            pictureBox23.TabIndex = 38;
            pictureBox23.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel6.ColumnCount = 11;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.901638F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.098362F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Controls.Add(pictureBox24, 10, 0);
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(200, 100);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // pictureBox24
            // 
            pictureBox24.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox24.BackColor = Color.Transparent;
            pictureBox24.Location = new Point(184, 3);
            pictureBox24.Name = "pictureBox24";
            pictureBox24.Size = new Size(14, 94);
            pictureBox24.TabIndex = 41;
            pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            pictureBox25.BackColor = Color.Transparent;
            pictureBox25.Location = new Point(164, 3);
            pictureBox25.Name = "pictureBox25";
            pictureBox25.Size = new Size(14, 94);
            pictureBox25.TabIndex = 38;
            pictureBox25.TabStop = false;
            // 
            // PlayerTurnLabel
            // 
            PlayerTurnLabel.AutoSize = true;
            PlayerTurnLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PlayerTurnLabel.Location = new Point(941, 579);
            PlayerTurnLabel.Name = "PlayerTurnLabel";
            PlayerTurnLabel.Size = new Size(69, 30);
            PlayerTurnLabel.TabIndex = 24;
            PlayerTurnLabel.Text = "Player";
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
            Controls.Add(PlayerTurnLabel);
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
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).EndInit();
            diceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            panel1.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)goToJailSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)marvinGardens).EndInit();
            ((System.ComponentModel.ISupportInitialize)waterWorks).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventorAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)atlanticAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)boRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)illinoisAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)indianaAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kentuckyAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)freeParkingSpace).EndInit();
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)goSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediterraneanAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)communityChest2).EndInit();
            ((System.ComponentModel.ISupportInitialize)balticAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)incomeTax).EndInit();
            ((System.ComponentModel.ISupportInitialize)readingRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)orientalAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance3).EndInit();
            ((System.ComponentModel.ISupportInitialize)vermontAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)connecticutAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)inJailSpace).EndInit();
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)parkPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance2).EndInit();
            ((System.ComponentModel.ISupportInitialize)luxuryTax).EndInit();
            ((System.ComponentModel.ISupportInitialize)pennsylvaniaAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)shortLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)communityChest1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pacificAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)northCarolinaAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)boardwalk).EndInit();
            leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)stCharlesPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)virginiaAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)newYorkAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)stJamesPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)communityChest3).EndInit();
            ((System.ComponentModel.ISupportInitialize)statesAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)tennesseeAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)pennsylvaniaRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)electricCompany).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox15).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox17).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox18).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox19).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox20).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox21).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox22).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox23).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox24).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox25).EndInit();
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
        private TableLayoutPanel leftPanel;
        private PictureBox virginiaAve;
        private PictureBox pennsylvaniaRailroad;
        private PictureBox communityChest3;
        private PictureBox tennesseeAve;
        private PictureBox newYorkAve;
        private PictureBox stJamesPlace;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox luxuryTax;
        private TableLayoutPanel rightPanel;
        private PictureBox chance2;
        private PictureBox pennsylvaniaAve;
        private PictureBox northCarolinaAve;
        private PictureBox shortLine;
        private PictureBox communityChest1;
        private PictureBox pacificAve;
        private TableLayoutPanel bottomPanel;
        private PictureBox communityChest2;
        private PictureBox incomeTax;
        private PictureBox chance3;
        private PictureBox connecticutAbe;
        private PictureBox mediterraneanAve;
        private PictureBox balticAve;
        private PictureBox readingRailroad;
        private PictureBox vermontAve;
        private PictureBox connecticutAve;
        private PictureBox pictureBox16;
        private PictureBox orientalAve;
        private PictureBox electricCompany;
        private PictureBox stCharlesPlace;
        private PictureBox parkPlace;
        private PictureBox goSpace;
        private PictureBox inJailSpace;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private TableLayoutPanel topPanel;
        private PictureBox goToJailSpace;
        private PictureBox marvinGardens;
        private PictureBox waterWorks;
        private PictureBox ventorAve;
        private PictureBox atlanticAve;
        private PictureBox boRailroad;
        private PictureBox illinoisAve;
        private PictureBox indianaAve;
        private PictureBox chance1;
        private PictureBox kentuckyAve;
        private PictureBox freeParkingSpace;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox boardwalk;
        private Label PlayerTurnLabel;
    }
}
