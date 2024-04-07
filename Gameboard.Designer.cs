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
            PictureBox waterWorks;
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
            goToJailSpace = new PictureBox();
            freeParkingSpace = new PictureBox();
            bottomPanel = new TableLayoutPanel();
            goSpace = new PictureBox();
            mediterraneanAve = new PictureBox();
            communityChest2 = new PictureBox();
            inJailSpace = new PictureBox();
            balticAve = new PictureBox();
            incomeTax = new PictureBox();
            readingRailroad = new PictureBox();
            orientalAve = new PictureBox();
            chance3 = new PictureBox();
            vermontAve = new PictureBox();
            connecticutAve = new PictureBox();
            rightPanel = new TableLayoutPanel();
            parkPlace = new PictureBox();
            luxuryTax = new PictureBox();
            chance2 = new PictureBox();
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
            topPanel = new TableLayoutPanel();
            kentuckyAve = new PictureBox();
            illinoisAve = new PictureBox();
            indianaAve = new PictureBox();
            boRailroad = new PictureBox();
            ventorAve = new PictureBox();
            atlanticAve = new PictureBox();
            marvinGardens = new PictureBox();
            chance1 = new PictureBox();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            waterWorks = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)waterWorks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).BeginInit();
            diceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)goToJailSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)freeParkingSpace).BeginInit();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)goSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mediterraneanAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)communityChest2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inJailSpace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)balticAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)incomeTax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)readingRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orientalAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vermontAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)connecticutAve).BeginInit();
            rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)parkPlace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)luxuryTax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance2).BeginInit();
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
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kentuckyAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)illinoisAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)indianaAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boRailroad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventorAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atlanticAve).BeginInit();
            ((System.ComponentModel.ISupportInitialize)marvinGardens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chance1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // waterWorks
            // 
            waterWorks.BackColor = Color.IndianRed;
            waterWorks.Location = new Point(398, 3);
            waterWorks.Name = "waterWorks";
            waterWorks.Size = new Size(28, 94);
            waterWorks.SizeMode = PictureBoxSizeMode.StretchImage;
            waterWorks.TabIndex = 29;
            waterWorks.TabStop = false;
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
            panel1.Controls.Add(bottomPanel);
            panel1.Controls.Add(rightPanel);
            panel1.Controls.Add(leftPanel);
            panel1.Controls.Add(gameBoardImage);
            panel1.Location = new Point(292, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 575);
            panel1.TabIndex = 23;
            // 
            // goToJailSpace
            // 
            goToJailSpace.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            goToJailSpace.BackColor = Color.Red;
            goToJailSpace.Location = new Point(461, 3);
            goToJailSpace.Name = "goToJailSpace";
            goToJailSpace.Size = new Size(14, 94);
            goToJailSpace.TabIndex = 38;
            goToJailSpace.TabStop = false;
            // 
            // freeParkingSpace
            // 
            freeParkingSpace.BackColor = Color.Red;
            freeParkingSpace.Location = new Point(3, 3);
            freeParkingSpace.Name = "freeParkingSpace";
            freeParkingSpace.Size = new Size(62, 94);
            freeParkingSpace.TabIndex = 39;
            freeParkingSpace.TabStop = false;
            // 
            // bottomPanel
            // 
            bottomPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bottomPanel.ColumnCount = 11;
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.901638F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.098362F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 34F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 31F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            bottomPanel.Controls.Add(goSpace, 10, 0);
            bottomPanel.Controls.Add(mediterraneanAve, 9, 0);
            bottomPanel.Controls.Add(communityChest2, 8, 0);
            bottomPanel.Controls.Add(inJailSpace, 0, 0);
            bottomPanel.Controls.Add(balticAve, 7, 0);
            bottomPanel.Controls.Add(incomeTax, 6, 0);
            bottomPanel.Controls.Add(readingRailroad, 5, 0);
            bottomPanel.Controls.Add(orientalAve, 4, 0);
            bottomPanel.Controls.Add(chance3, 3, 0);
            bottomPanel.Controls.Add(vermontAve, 2, 0);
            bottomPanel.Controls.Add(connecticutAve, 1, 0);
            bottomPanel.Location = new Point(21, 476);
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
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            bottomPanel.Size = new Size(540, 100);
            bottomPanel.TabIndex = 37;
            // 
            // goSpace
            // 
            goSpace.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            goSpace.BackColor = Color.Red;
            goSpace.Location = new Point(522, 3);
            goSpace.Name = "goSpace";
            goSpace.Size = new Size(15, 94);
            goSpace.TabIndex = 41;
            goSpace.TabStop = false;
            // 
            // mediterraneanAve
            // 
            mediterraneanAve.BackColor = Color.Yellow;
            mediterraneanAve.Location = new Point(502, 3);
            mediterraneanAve.Name = "mediterraneanAve";
            mediterraneanAve.Size = new Size(14, 94);
            mediterraneanAve.TabIndex = 38;
            mediterraneanAve.TabStop = false;
            // 
            // communityChest2
            // 
            communityChest2.BackColor = Color.Magenta;
            communityChest2.Location = new Point(445, 3);
            communityChest2.Name = "communityChest2";
            communityChest2.Size = new Size(51, 94);
            communityChest2.TabIndex = 38;
            communityChest2.TabStop = false;
            // 
            // inJailSpace
            // 
            inJailSpace.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inJailSpace.BackColor = Color.Red;
            inJailSpace.Location = new Point(3, 3);
            inJailSpace.Name = "inJailSpace";
            inJailSpace.Size = new Size(105, 94);
            inJailSpace.TabIndex = 40;
            inJailSpace.TabStop = false;
            // 
            // balticAve
            // 
            balticAve.BackColor = Color.Yellow;
            balticAve.Location = new Point(410, 3);
            balticAve.Name = "balticAve";
            balticAve.Size = new Size(25, 94);
            balticAve.TabIndex = 38;
            balticAve.TabStop = false;
            // 
            // incomeTax
            // 
            incomeTax.BackColor = Color.Magenta;
            incomeTax.Location = new Point(379, 3);
            incomeTax.Name = "incomeTax";
            incomeTax.Size = new Size(25, 94);
            incomeTax.TabIndex = 38;
            incomeTax.TabStop = false;
            // 
            // readingRailroad
            // 
            readingRailroad.BackColor = Color.Yellow;
            readingRailroad.Location = new Point(345, 3);
            readingRailroad.Name = "readingRailroad";
            readingRailroad.Size = new Size(25, 94);
            readingRailroad.TabIndex = 38;
            readingRailroad.TabStop = false;
            // 
            // orientalAve
            // 
            orientalAve.BackColor = Color.Magenta;
            orientalAve.Location = new Point(314, 3);
            orientalAve.Name = "orientalAve";
            orientalAve.Size = new Size(25, 94);
            orientalAve.TabIndex = 42;
            orientalAve.TabStop = false;
            // 
            // chance3
            // 
            chance3.BackColor = Color.Yellow;
            chance3.Location = new Point(280, 3);
            chance3.Name = "chance3";
            chance3.Size = new Size(28, 94);
            chance3.TabIndex = 38;
            chance3.TabStop = false;
            // 
            // vermontAve
            // 
            vermontAve.BackColor = Color.Magenta;
            vermontAve.Location = new Point(244, 3);
            vermontAve.Name = "vermontAve";
            vermontAve.Size = new Size(27, 94);
            vermontAve.TabIndex = 39;
            vermontAve.TabStop = false;
            // 
            // connecticutAve
            // 
            connecticutAve.BackColor = Color.Yellow;
            connecticutAve.Location = new Point(114, 3);
            connecticutAve.Name = "connecticutAve";
            connecticutAve.Size = new Size(105, 94);
            connecticutAve.TabIndex = 38;
            connecticutAve.TabStop = false;
            // 
            // rightPanel
            // 
            rightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rightPanel.ColumnCount = 1;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rightPanel.Controls.Add(parkPlace, 0, 6);
            rightPanel.Controls.Add(luxuryTax, 0, 7);
            rightPanel.Controls.Add(chance2, 0, 5);
            rightPanel.Controls.Add(pennsylvaniaAve, 0, 3);
            rightPanel.Controls.Add(shortLine, 0, 4);
            rightPanel.Controls.Add(communityChest1, 0, 2);
            rightPanel.Controls.Add(pacificAve, 0, 0);
            rightPanel.Controls.Add(northCarolinaAve, 0, 1);
            rightPanel.Controls.Add(boardwalk, 0, 8);
            rightPanel.Location = new Point(453, 114);
            rightPanel.Name = "rightPanel";
            rightPanel.RowCount = 9;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 51.31579F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 48.68421F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            rightPanel.Size = new Size(108, 337);
            rightPanel.TabIndex = 35;
            // 
            // parkPlace
            // 
            parkPlace.BackColor = Color.Lime;
            parkPlace.Location = new Point(3, 230);
            parkPlace.Name = "parkPlace";
            parkPlace.Size = new Size(102, 26);
            parkPlace.TabIndex = 42;
            parkPlace.TabStop = false;
            // 
            // luxuryTax
            // 
            luxuryTax.BackColor = Color.MediumSlateBlue;
            luxuryTax.Location = new Point(3, 262);
            luxuryTax.Name = "luxuryTax";
            luxuryTax.Size = new Size(102, 29);
            luxuryTax.TabIndex = 36;
            luxuryTax.TabStop = false;
            // 
            // chance2
            // 
            chance2.BackColor = Color.MediumSlateBlue;
            chance2.Location = new Point(3, 192);
            chance2.Name = "chance2";
            chance2.Size = new Size(102, 32);
            chance2.TabIndex = 37;
            chance2.TabStop = false;
            // 
            // pennsylvaniaAve
            // 
            pennsylvaniaAve.BackColor = Color.MediumSlateBlue;
            pennsylvaniaAve.Location = new Point(3, 106);
            pennsylvaniaAve.Name = "pennsylvaniaAve";
            pennsylvaniaAve.Size = new Size(102, 35);
            pennsylvaniaAve.TabIndex = 38;
            pennsylvaniaAve.TabStop = false;
            // 
            // shortLine
            // 
            shortLine.BackColor = Color.Lime;
            shortLine.Location = new Point(3, 147);
            shortLine.Name = "shortLine";
            shortLine.Size = new Size(102, 37);
            shortLine.TabIndex = 38;
            shortLine.TabStop = false;
            // 
            // communityChest1
            // 
            communityChest1.BackColor = Color.Lime;
            communityChest1.Location = new Point(3, 72);
            communityChest1.Name = "communityChest1";
            communityChest1.Size = new Size(102, 28);
            communityChest1.TabIndex = 39;
            communityChest1.TabStop = false;
            // 
            // pacificAve
            // 
            pacificAve.BackColor = Color.Lime;
            pacificAve.Location = new Point(3, 3);
            pacificAve.Name = "pacificAve";
            pacificAve.Size = new Size(102, 29);
            pacificAve.TabIndex = 40;
            pacificAve.TabStop = false;
            // 
            // northCarolinaAve
            // 
            northCarolinaAve.BackColor = Color.MediumSlateBlue;
            northCarolinaAve.Location = new Point(3, 38);
            northCarolinaAve.Name = "northCarolinaAve";
            northCarolinaAve.Size = new Size(102, 28);
            northCarolinaAve.TabIndex = 39;
            northCarolinaAve.TabStop = false;
            // 
            // boardwalk
            // 
            boardwalk.BackColor = Color.Lime;
            boardwalk.Location = new Point(3, 297);
            boardwalk.Name = "boardwalk";
            boardwalk.Size = new Size(102, 37);
            boardwalk.TabIndex = 38;
            boardwalk.TabStop = false;
            // 
            // leftPanel
            // 
            leftPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            stCharlesPlace.BackColor = Color.Cyan;
            stCharlesPlace.Location = new Point(3, 307);
            stCharlesPlace.Name = "stCharlesPlace";
            stCharlesPlace.Size = new Size(101, 30);
            stCharlesPlace.TabIndex = 42;
            stCharlesPlace.TabStop = false;
            // 
            // virginiaAve
            // 
            virginiaAve.BackColor = Color.NavajoWhite;
            virginiaAve.Location = new Point(3, 182);
            virginiaAve.Name = "virginiaAve";
            virginiaAve.Size = new Size(101, 36);
            virginiaAve.TabIndex = 37;
            virginiaAve.TabStop = false;
            // 
            // newYorkAve
            // 
            newYorkAve.BackColor = Color.Cyan;
            newYorkAve.Location = new Point(3, 3);
            newYorkAve.Name = "newYorkAve";
            newYorkAve.Size = new Size(101, 26);
            newYorkAve.TabIndex = 0;
            newYorkAve.TabStop = false;
            // 
            // stJamesPlace
            // 
            stJamesPlace.BackColor = Color.NavajoWhite;
            stJamesPlace.Location = new Point(3, 104);
            stJamesPlace.Name = "stJamesPlace";
            stJamesPlace.Size = new Size(101, 28);
            stJamesPlace.TabIndex = 36;
            stJamesPlace.TabStop = false;
            // 
            // communityChest3
            // 
            communityChest3.BackColor = Color.Cyan;
            communityChest3.Location = new Point(3, 68);
            communityChest3.Name = "communityChest3";
            communityChest3.Size = new Size(101, 30);
            communityChest3.TabIndex = 2;
            communityChest3.TabStop = false;
            // 
            // statesAve
            // 
            statesAve.BackColor = Color.Cyan;
            statesAve.Location = new Point(3, 224);
            statesAve.Name = "statesAve";
            statesAve.Size = new Size(101, 35);
            statesAve.TabIndex = 38;
            statesAve.TabStop = false;
            // 
            // tennesseeAve
            // 
            tennesseeAve.BackColor = Color.NavajoWhite;
            tennesseeAve.Location = new Point(3, 35);
            tennesseeAve.Name = "tennesseeAve";
            tennesseeAve.Size = new Size(101, 27);
            tennesseeAve.TabIndex = 1;
            tennesseeAve.TabStop = false;
            // 
            // pennsylvaniaRailroad
            // 
            pennsylvaniaRailroad.BackColor = Color.Cyan;
            pennsylvaniaRailroad.Location = new Point(3, 138);
            pennsylvaniaRailroad.Name = "pennsylvaniaRailroad";
            pennsylvaniaRailroad.Size = new Size(101, 38);
            pennsylvaniaRailroad.TabIndex = 35;
            pennsylvaniaRailroad.TabStop = false;
            // 
            // electricCompany
            // 
            electricCompany.BackColor = Color.NavajoWhite;
            electricCompany.Location = new Point(3, 265);
            electricCompany.Name = "electricCompany";
            electricCompany.Size = new Size(101, 36);
            electricCompany.TabIndex = 42;
            electricCompany.TabStop = false;
            // 
            // topPanel
            // 
            topPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topPanel.BackColor = SystemColors.ActiveCaptionText;
            topPanel.ColumnCount = 11;
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            topPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            topPanel.Controls.Add(goToJailSpace, 10, 0);
            topPanel.Controls.Add(chance1, 2, 0);
            topPanel.Controls.Add(marvinGardens, 9, 0);
            topPanel.Controls.Add(waterWorks, 8, 0);
            topPanel.Controls.Add(ventorAve, 7, 0);
            topPanel.Controls.Add(atlanticAve, 6, 0);
            topPanel.Controls.Add(boRailroad, 5, 0);
            topPanel.Controls.Add(illinoisAve, 4, 0);
            topPanel.Controls.Add(indianaAve, 3, 0);
            topPanel.Controls.Add(freeParkingSpace, 0, 0);
            topPanel.Controls.Add(kentuckyAve, 1, 0);
            topPanel.Location = new Point(331, 29);
            topPanel.MinimumSize = new Size(320, 100);
            topPanel.Name = "topPanel";
            topPanel.RowCount = 1;
            topPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            topPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            topPanel.Size = new Size(478, 100);
            topPanel.TabIndex = 30;
            // 
            // kentuckyAve
            // 
            kentuckyAve.BackColor = Color.DarkTurquoise;
            kentuckyAve.Location = new Point(75, 3);
            kentuckyAve.Name = "kentuckyAve";
            kentuckyAve.Size = new Size(66, 94);
            kentuckyAve.TabIndex = 39;
            kentuckyAve.TabStop = false;
            // 
            // illinoisAve
            // 
            illinoisAve.BackColor = Color.IndianRed;
            illinoisAve.Location = new Point(242, 3);
            illinoisAve.Name = "illinoisAve";
            illinoisAve.Size = new Size(36, 94);
            illinoisAve.SizeMode = PictureBoxSizeMode.StretchImage;
            illinoisAve.TabIndex = 28;
            illinoisAve.TabStop = false;
            // 
            // indianaAve
            // 
            indianaAve.BackColor = Color.DarkTurquoise;
            indianaAve.Location = new Point(197, 3);
            indianaAve.Name = "indianaAve";
            indianaAve.Size = new Size(39, 94);
            indianaAve.SizeMode = PictureBoxSizeMode.StretchImage;
            indianaAve.TabIndex = 22;
            indianaAve.TabStop = false;
            // 
            // boRailroad
            // 
            boRailroad.BackColor = Color.DarkTurquoise;
            boRailroad.Location = new Point(284, 3);
            boRailroad.Name = "boRailroad";
            boRailroad.Size = new Size(34, 94);
            boRailroad.SizeMode = PictureBoxSizeMode.StretchImage;
            boRailroad.TabIndex = 25;
            boRailroad.TabStop = false;
            // 
            // ventorAve
            // 
            ventorAve.BackColor = Color.DarkTurquoise;
            ventorAve.Location = new Point(361, 3);
            ventorAve.Name = "ventorAve";
            ventorAve.Size = new Size(31, 94);
            ventorAve.SizeMode = PictureBoxSizeMode.StretchImage;
            ventorAve.TabIndex = 26;
            ventorAve.TabStop = false;
            // 
            // atlanticAve
            // 
            atlanticAve.BackColor = Color.IndianRed;
            atlanticAve.Location = new Point(324, 3);
            atlanticAve.Name = "atlanticAve";
            atlanticAve.Size = new Size(31, 94);
            atlanticAve.SizeMode = PictureBoxSizeMode.StretchImage;
            atlanticAve.TabIndex = 27;
            atlanticAve.TabStop = false;
            // 
            // marvinGardens
            // 
            marvinGardens.BackColor = Color.DarkTurquoise;
            marvinGardens.Location = new Point(441, 3);
            marvinGardens.Name = "marvinGardens";
            marvinGardens.Size = new Size(14, 94);
            marvinGardens.SizeMode = PictureBoxSizeMode.StretchImage;
            marvinGardens.TabIndex = 30;
            marvinGardens.TabStop = false;
            // 
            // chance1
            // 
            chance1.BackColor = Color.IndianRed;
            chance1.Location = new Point(160, 3);
            chance1.Name = "chance1";
            chance1.Size = new Size(31, 94);
            chance1.SizeMode = PictureBoxSizeMode.StretchImage;
            chance1.TabIndex = 23;
            chance1.TabStop = false;
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
            // Gameboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1245, 637);
            Controls.Add(topPanel);
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
            ((System.ComponentModel.ISupportInitialize)waterWorks).EndInit();
            ((System.ComponentModel.ISupportInitialize)getOutOfJailFreeCards).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll1).EndInit();
            ((System.ComponentModel.ISupportInitialize)diceRoll2).EndInit();
            diceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)goToJailSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)freeParkingSpace).EndInit();
            bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)goSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)mediterraneanAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)communityChest2).EndInit();
            ((System.ComponentModel.ISupportInitialize)inJailSpace).EndInit();
            ((System.ComponentModel.ISupportInitialize)balticAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)incomeTax).EndInit();
            ((System.ComponentModel.ISupportInitialize)readingRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)orientalAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance3).EndInit();
            ((System.ComponentModel.ISupportInitialize)vermontAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)connecticutAve).EndInit();
            rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)parkPlace).EndInit();
            ((System.ComponentModel.ISupportInitialize)luxuryTax).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance2).EndInit();
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
            topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kentuckyAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)illinoisAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)indianaAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)boRailroad).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventorAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)atlanticAve).EndInit();
            ((System.ComponentModel.ISupportInitialize)marvinGardens).EndInit();
            ((System.ComponentModel.ISupportInitialize)chance1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox ventorAve;
        private PictureBox atlanticAve;
        private PictureBox boRailroad;
        private PictureBox indianaAve;
        private PictureBox chance1;
        private PictureBox illinoisAve;
        private PictureBox waterWorks;
        private PictureBox marvinGardens;
        private TableLayoutPanel topPanel;
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
        private PictureBox boardwalk;
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
        private PictureBox goToJailSpace;
        private PictureBox inJailSpace;
        private PictureBox freeParkingSpace;
        private PictureBox kentuckyAve;
        private PictureBox orientalAve;
        private PictureBox electricCompany;
        private PictureBox stCharlesPlace;
        private PictureBox parkPlace;
        private PictureBox goSpace;
    }
}
