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
            sellHouseButton = new Button();
            buyHouseButton = new Button();
            propertyPanel = new Panel();
            housePictureBox = new PictureBox();
            propertyNameLabel = new Label();
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
            playerLabel = new Label();
            propertiesPanel = new Panel();
            propertiesGroupBox.SuspendLayout();
            propertyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)housePictureBox).BeginInit();
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
            propertiesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // propertiesGroupBox
            // 
            resources.ApplyResources(propertiesGroupBox, "propertiesGroupBox");
            propertiesGroupBox.BackColor = Color.AliceBlue;
            propertiesGroupBox.Controls.Add(sellHouseButton);
            propertiesGroupBox.Controls.Add(buyHouseButton);
            propertiesGroupBox.Name = "propertiesGroupBox";
            propertiesGroupBox.TabStop = false;
            // 
            // sellHouseButton
            // 
            resources.ApplyResources(sellHouseButton, "sellHouseButton");
            sellHouseButton.BackColor = Color.Tomato;
            sellHouseButton.ForeColor = SystemColors.ControlText;
            sellHouseButton.Name = "sellHouseButton";
            sellHouseButton.UseVisualStyleBackColor = false;
            sellHouseButton.Click += sellHouseButton_Click;
            // 
            // buyHouseButton
            // 
            resources.ApplyResources(buyHouseButton, "buyHouseButton");
            buyHouseButton.BackColor = Color.Tomato;
            buyHouseButton.Name = "buyHouseButton";
            buyHouseButton.UseVisualStyleBackColor = false;
            buyHouseButton.Click += buyHouseButton_Click;
            // 
            // propertyPanel
            // 
            propertyPanel.BackColor = Color.Yellow;
            propertyPanel.BorderStyle = BorderStyle.FixedSingle;
            propertyPanel.Controls.Add(housePictureBox);
            propertyPanel.Controls.Add(propertyNameLabel);
            resources.ApplyResources(propertyPanel, "propertyPanel");
            propertyPanel.Name = "propertyPanel";
            propertyPanel.Click += propertyPanel_Click;
            // 
            // housePictureBox
            // 
            resources.ApplyResources(housePictureBox, "housePictureBox");
            housePictureBox.BackgroundImage = Properties.Resources.house;
            housePictureBox.Image = Properties.Resources.house;
            housePictureBox.Name = "housePictureBox";
            housePictureBox.TabStop = false;
            // 
            // propertyNameLabel
            // 
            resources.ApplyResources(propertyNameLabel, "propertyNameLabel");
            propertyNameLabel.Name = "propertyNameLabel";
            // 
            // balanceLabel
            // 
            resources.ApplyResources(balanceLabel, "balanceLabel");
            balanceLabel.BackColor = Color.Transparent;
            balanceLabel.ForeColor = SystemColors.ButtonHighlight;
            balanceLabel.Name = "balanceLabel";
            // 
            // balanceTextBox
            // 
            resources.ApplyResources(balanceTextBox, "balanceTextBox");
            balanceTextBox.ForeColor = SystemColors.WindowText;
            balanceTextBox.Name = "balanceTextBox";
            // 
            // buyButton
            // 
            resources.ApplyResources(buyButton, "buyButton");
            buyButton.BackColor = Color.MediumSpringGreen;
            buyButton.Name = "buyButton";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += buyButton_Click;
            // 
            // sellButton
            // 
            resources.ApplyResources(sellButton, "sellButton");
            sellButton.BackColor = Color.Yellow;
            sellButton.Name = "sellButton";
            sellButton.UseVisualStyleBackColor = false;
            sellButton.Click += sellButton_Click;
            // 
            // nextTurnButton
            // 
            resources.ApplyResources(nextTurnButton, "nextTurnButton");
            nextTurnButton.BackColor = Color.LightSkyBlue;
            nextTurnButton.ForeColor = SystemColors.ControlText;
            nextTurnButton.Name = "nextTurnButton";
            nextTurnButton.UseVisualStyleBackColor = false;
            nextTurnButton.Click += nextTurnButton_Click;
            // 
            // getOutOfJailFreeCards
            // 
            resources.ApplyResources(getOutOfJailFreeCards, "getOutOfJailFreeCards");
            getOutOfJailFreeCards.Name = "getOutOfJailFreeCards";
            getOutOfJailFreeCards.TabStop = false;
            // 
            // diceRoll1
            // 
            diceRoll1.BackColor = Color.Transparent;
            resources.ApplyResources(diceRoll1, "diceRoll1");
            diceRoll1.Name = "diceRoll1";
            diceRoll1.TabStop = false;
            // 
            // diceRoll2
            // 
            diceRoll2.BackColor = Color.Transparent;
            resources.ApplyResources(diceRoll2, "diceRoll2");
            diceRoll2.Name = "diceRoll2";
            diceRoll2.TabStop = false;
            // 
            // diceGroupBox
            // 
            resources.ApplyResources(diceGroupBox, "diceGroupBox");
            diceGroupBox.BackColor = Color.Transparent;
            diceGroupBox.Controls.Add(diceRoll2);
            diceGroupBox.Controls.Add(diceRoll1);
            diceGroupBox.ForeColor = SystemColors.ButtonFace;
            diceGroupBox.Name = "diceGroupBox";
            diceGroupBox.TabStop = false;
            // 
            // rollDiceButton
            // 
            resources.ApplyResources(rollDiceButton, "rollDiceButton");
            rollDiceButton.BackColor = Color.Tomato;
            rollDiceButton.ForeColor = SystemColors.ControlText;
            rollDiceButton.Name = "rollDiceButton";
            rollDiceButton.UseVisualStyleBackColor = false;
            rollDiceButton.Click += rollDiceButton_Click;
            // 
            // gameBoardImage
            // 
            resources.ApplyResources(gameBoardImage, "gameBoardImage");
            gameBoardImage.BorderStyle = BorderStyle.FixedSingle;
            gameBoardImage.Cursor = Cursors.No;
            gameBoardImage.Name = "gameBoardImage";
            gameBoardImage.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(topPanel);
            panel1.Controls.Add(bottomPanel);
            panel1.Controls.Add(rightPanel);
            panel1.Controls.Add(leftPanel);
            panel1.Controls.Add(gameBoardImage);
            panel1.Name = "panel1";
            // 
            // topPanel
            // 
            resources.ApplyResources(topPanel, "topPanel");
            topPanel.BackColor = Color.Transparent;
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
            topPanel.Name = "topPanel";
            // 
            // goToJailSpace
            // 
            resources.ApplyResources(goToJailSpace, "goToJailSpace");
            goToJailSpace.BackColor = Color.Transparent;
            goToJailSpace.Name = "goToJailSpace";
            goToJailSpace.TabStop = false;
            // 
            // marvinGardens
            // 
            marvinGardens.BackColor = Color.Transparent;
            resources.ApplyResources(marvinGardens, "marvinGardens");
            marvinGardens.Name = "marvinGardens";
            marvinGardens.TabStop = false;
            // 
            // waterWorks
            // 
            waterWorks.BackColor = Color.Transparent;
            resources.ApplyResources(waterWorks, "waterWorks");
            waterWorks.Name = "waterWorks";
            waterWorks.TabStop = false;
            // 
            // ventorAve
            // 
            ventorAve.BackColor = Color.Transparent;
            resources.ApplyResources(ventorAve, "ventorAve");
            ventorAve.Name = "ventorAve";
            ventorAve.TabStop = false;
            // 
            // atlanticAve
            // 
            atlanticAve.BackColor = Color.Transparent;
            resources.ApplyResources(atlanticAve, "atlanticAve");
            atlanticAve.Name = "atlanticAve";
            atlanticAve.TabStop = false;
            // 
            // boRailroad
            // 
            boRailroad.BackColor = Color.Transparent;
            resources.ApplyResources(boRailroad, "boRailroad");
            boRailroad.Name = "boRailroad";
            boRailroad.TabStop = false;
            // 
            // illinoisAve
            // 
            illinoisAve.BackColor = Color.Transparent;
            resources.ApplyResources(illinoisAve, "illinoisAve");
            illinoisAve.Name = "illinoisAve";
            illinoisAve.TabStop = false;
            // 
            // indianaAve
            // 
            indianaAve.BackColor = Color.Transparent;
            resources.ApplyResources(indianaAve, "indianaAve");
            indianaAve.Name = "indianaAve";
            indianaAve.TabStop = false;
            // 
            // chance1
            // 
            chance1.BackColor = Color.Transparent;
            resources.ApplyResources(chance1, "chance1");
            chance1.Name = "chance1";
            chance1.TabStop = false;
            // 
            // kentuckyAve
            // 
            kentuckyAve.BackColor = Color.Transparent;
            resources.ApplyResources(kentuckyAve, "kentuckyAve");
            kentuckyAve.Name = "kentuckyAve";
            kentuckyAve.TabStop = false;
            // 
            // freeParkingSpace
            // 
            resources.ApplyResources(freeParkingSpace, "freeParkingSpace");
            freeParkingSpace.Name = "freeParkingSpace";
            freeParkingSpace.TabStop = false;
            // 
            // bottomPanel
            // 
            resources.ApplyResources(bottomPanel, "bottomPanel");
            bottomPanel.BackColor = Color.Transparent;
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
            bottomPanel.Name = "bottomPanel";
            // 
            // goSpace
            // 
            resources.ApplyResources(goSpace, "goSpace");
            goSpace.BackColor = Color.Transparent;
            goSpace.Name = "goSpace";
            goSpace.TabStop = false;
            // 
            // mediterraneanAve
            // 
            mediterraneanAve.BackColor = Color.Transparent;
            resources.ApplyResources(mediterraneanAve, "mediterraneanAve");
            mediterraneanAve.Name = "mediterraneanAve";
            mediterraneanAve.TabStop = false;
            // 
            // communityChest2
            // 
            communityChest2.BackColor = Color.Transparent;
            resources.ApplyResources(communityChest2, "communityChest2");
            communityChest2.Name = "communityChest2";
            communityChest2.TabStop = false;
            // 
            // balticAve
            // 
            balticAve.BackColor = Color.Transparent;
            resources.ApplyResources(balticAve, "balticAve");
            balticAve.Name = "balticAve";
            balticAve.TabStop = false;
            // 
            // incomeTax
            // 
            incomeTax.BackColor = Color.Transparent;
            resources.ApplyResources(incomeTax, "incomeTax");
            incomeTax.Name = "incomeTax";
            incomeTax.TabStop = false;
            // 
            // readingRailroad
            // 
            readingRailroad.BackColor = Color.Transparent;
            resources.ApplyResources(readingRailroad, "readingRailroad");
            readingRailroad.Name = "readingRailroad";
            readingRailroad.TabStop = false;
            // 
            // orientalAve
            // 
            orientalAve.BackColor = Color.Transparent;
            resources.ApplyResources(orientalAve, "orientalAve");
            orientalAve.Name = "orientalAve";
            orientalAve.TabStop = false;
            // 
            // chance3
            // 
            chance3.BackColor = Color.Transparent;
            resources.ApplyResources(chance3, "chance3");
            chance3.Name = "chance3";
            chance3.TabStop = false;
            // 
            // vermontAve
            // 
            vermontAve.BackColor = Color.Transparent;
            resources.ApplyResources(vermontAve, "vermontAve");
            vermontAve.Name = "vermontAve";
            vermontAve.TabStop = false;
            // 
            // connecticutAve
            // 
            connecticutAve.BackColor = Color.Transparent;
            resources.ApplyResources(connecticutAve, "connecticutAve");
            connecticutAve.Name = "connecticutAve";
            connecticutAve.TabStop = false;
            // 
            // inJailSpace
            // 
            resources.ApplyResources(inJailSpace, "inJailSpace");
            inJailSpace.Name = "inJailSpace";
            inJailSpace.TabStop = false;
            // 
            // rightPanel
            // 
            resources.ApplyResources(rightPanel, "rightPanel");
            rightPanel.BackColor = Color.Transparent;
            rightPanel.Controls.Add(parkPlace, 0, 6);
            rightPanel.Controls.Add(chance2, 0, 5);
            rightPanel.Controls.Add(luxuryTax, 0, 7);
            rightPanel.Controls.Add(pennsylvaniaAve, 0, 3);
            rightPanel.Controls.Add(shortLine, 0, 4);
            rightPanel.Controls.Add(communityChest1, 0, 2);
            rightPanel.Controls.Add(pacificAve, 0, 0);
            rightPanel.Controls.Add(northCarolinaAve, 0, 1);
            rightPanel.Controls.Add(boardwalk, 0, 8);
            rightPanel.Name = "rightPanel";
            // 
            // parkPlace
            // 
            parkPlace.BackColor = Color.Transparent;
            resources.ApplyResources(parkPlace, "parkPlace");
            parkPlace.Name = "parkPlace";
            parkPlace.TabStop = false;
            // 
            // chance2
            // 
            chance2.BackColor = Color.Transparent;
            resources.ApplyResources(chance2, "chance2");
            chance2.Name = "chance2";
            chance2.TabStop = false;
            // 
            // luxuryTax
            // 
            luxuryTax.BackColor = Color.Transparent;
            resources.ApplyResources(luxuryTax, "luxuryTax");
            luxuryTax.Name = "luxuryTax";
            luxuryTax.TabStop = false;
            // 
            // pennsylvaniaAve
            // 
            pennsylvaniaAve.BackColor = Color.Transparent;
            resources.ApplyResources(pennsylvaniaAve, "pennsylvaniaAve");
            pennsylvaniaAve.Name = "pennsylvaniaAve";
            pennsylvaniaAve.TabStop = false;
            // 
            // shortLine
            // 
            shortLine.BackColor = Color.Transparent;
            resources.ApplyResources(shortLine, "shortLine");
            shortLine.Name = "shortLine";
            shortLine.TabStop = false;
            // 
            // communityChest1
            // 
            communityChest1.BackColor = Color.Transparent;
            resources.ApplyResources(communityChest1, "communityChest1");
            communityChest1.Name = "communityChest1";
            communityChest1.TabStop = false;
            // 
            // pacificAve
            // 
            pacificAve.BackColor = Color.Transparent;
            resources.ApplyResources(pacificAve, "pacificAve");
            pacificAve.Name = "pacificAve";
            pacificAve.TabStop = false;
            // 
            // northCarolinaAve
            // 
            northCarolinaAve.BackColor = Color.Transparent;
            resources.ApplyResources(northCarolinaAve, "northCarolinaAve");
            northCarolinaAve.Name = "northCarolinaAve";
            northCarolinaAve.TabStop = false;
            // 
            // boardwalk
            // 
            boardwalk.BackColor = Color.Transparent;
            resources.ApplyResources(boardwalk, "boardwalk");
            boardwalk.Name = "boardwalk";
            boardwalk.TabStop = false;
            // 
            // leftPanel
            // 
            resources.ApplyResources(leftPanel, "leftPanel");
            leftPanel.BackColor = Color.Transparent;
            leftPanel.Controls.Add(stCharlesPlace, 0, 8);
            leftPanel.Controls.Add(virginiaAve, 0, 5);
            leftPanel.Controls.Add(newYorkAve, 0, 0);
            leftPanel.Controls.Add(stJamesPlace, 0, 3);
            leftPanel.Controls.Add(communityChest3, 0, 2);
            leftPanel.Controls.Add(statesAve, 0, 6);
            leftPanel.Controls.Add(tennesseeAve, 0, 1);
            leftPanel.Controls.Add(pennsylvaniaRailroad, 0, 4);
            leftPanel.Controls.Add(electricCompany, 0, 7);
            leftPanel.Name = "leftPanel";
            // 
            // stCharlesPlace
            // 
            stCharlesPlace.BackColor = Color.Transparent;
            resources.ApplyResources(stCharlesPlace, "stCharlesPlace");
            stCharlesPlace.Name = "stCharlesPlace";
            stCharlesPlace.TabStop = false;
            // 
            // virginiaAve
            // 
            virginiaAve.BackColor = Color.Transparent;
            resources.ApplyResources(virginiaAve, "virginiaAve");
            virginiaAve.Name = "virginiaAve";
            virginiaAve.TabStop = false;
            // 
            // newYorkAve
            // 
            newYorkAve.BackColor = Color.Transparent;
            resources.ApplyResources(newYorkAve, "newYorkAve");
            newYorkAve.Name = "newYorkAve";
            newYorkAve.TabStop = false;
            // 
            // stJamesPlace
            // 
            stJamesPlace.BackColor = Color.Transparent;
            resources.ApplyResources(stJamesPlace, "stJamesPlace");
            stJamesPlace.Name = "stJamesPlace";
            stJamesPlace.TabStop = false;
            // 
            // communityChest3
            // 
            communityChest3.BackColor = Color.Transparent;
            resources.ApplyResources(communityChest3, "communityChest3");
            communityChest3.Name = "communityChest3";
            communityChest3.TabStop = false;
            // 
            // statesAve
            // 
            statesAve.BackColor = Color.Transparent;
            resources.ApplyResources(statesAve, "statesAve");
            statesAve.Name = "statesAve";
            statesAve.TabStop = false;
            // 
            // tennesseeAve
            // 
            tennesseeAve.BackColor = Color.Transparent;
            resources.ApplyResources(tennesseeAve, "tennesseeAve");
            tennesseeAve.Name = "tennesseeAve";
            tennesseeAve.TabStop = false;
            // 
            // pennsylvaniaRailroad
            // 
            pennsylvaniaRailroad.BackColor = Color.Transparent;
            resources.ApplyResources(pennsylvaniaRailroad, "pennsylvaniaRailroad");
            pennsylvaniaRailroad.Name = "pennsylvaniaRailroad";
            pennsylvaniaRailroad.TabStop = false;
            // 
            // electricCompany
            // 
            electricCompany.BackColor = Color.Transparent;
            resources.ApplyResources(electricCompany, "electricCompany");
            electricCompany.Name = "electricCompany";
            electricCompany.TabStop = false;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 9);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.Controls.Add(pictureBox11, 0, 6);
            tableLayoutPanel4.Controls.Add(pictureBox12, 0, 7);
            tableLayoutPanel4.Controls.Add(pictureBox13, 0, 5);
            tableLayoutPanel4.Controls.Add(pictureBox14, 0, 3);
            tableLayoutPanel4.Controls.Add(pictureBox15, 0, 4);
            tableLayoutPanel4.Controls.Add(pictureBox17, 0, 2);
            tableLayoutPanel4.Controls.Add(pictureBox18, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox19, 0, 1);
            tableLayoutPanel4.Controls.Add(pictureBox20, 0, 8);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox11, "pictureBox11");
            pictureBox11.Name = "pictureBox11";
            pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            pictureBox12.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox12, "pictureBox12");
            pictureBox12.Name = "pictureBox12";
            pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            pictureBox13.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox13, "pictureBox13");
            pictureBox13.Name = "pictureBox13";
            pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            pictureBox14.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox14, "pictureBox14");
            pictureBox14.Name = "pictureBox14";
            pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            pictureBox15.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox15, "pictureBox15");
            pictureBox15.Name = "pictureBox15";
            pictureBox15.TabStop = false;
            // 
            // pictureBox17
            // 
            pictureBox17.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox17, "pictureBox17");
            pictureBox17.Name = "pictureBox17";
            pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            pictureBox18.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox18, "pictureBox18");
            pictureBox18.Name = "pictureBox18";
            pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            pictureBox19.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox19, "pictureBox19");
            pictureBox19.Name = "pictureBox19";
            pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            pictureBox20.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox20, "pictureBox20");
            pictureBox20.Name = "pictureBox20";
            pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            pictureBox21.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox21, "pictureBox21");
            pictureBox21.Name = "pictureBox21";
            pictureBox21.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(tableLayoutPanel5, "tableLayoutPanel5");
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.Controls.Add(pictureBox22, 10, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // pictureBox22
            // 
            resources.ApplyResources(pictureBox22, "pictureBox22");
            pictureBox22.BackColor = Color.Transparent;
            pictureBox22.Name = "pictureBox22";
            pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            pictureBox23.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox23, "pictureBox23");
            pictureBox23.Name = "pictureBox23";
            pictureBox23.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(tableLayoutPanel6, "tableLayoutPanel6");
            tableLayoutPanel6.BackColor = Color.Transparent;
            tableLayoutPanel6.Controls.Add(pictureBox24, 10, 0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // pictureBox24
            // 
            resources.ApplyResources(pictureBox24, "pictureBox24");
            pictureBox24.BackColor = Color.Transparent;
            pictureBox24.Name = "pictureBox24";
            pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            pictureBox25.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox25, "pictureBox25");
            pictureBox25.Name = "pictureBox25";
            pictureBox25.TabStop = false;
            // 
            // playerLabel
            // 
            resources.ApplyResources(playerLabel, "playerLabel");
            playerLabel.BackColor = Color.Transparent;
            playerLabel.FlatStyle = FlatStyle.Flat;
            playerLabel.ForeColor = SystemColors.ButtonHighlight;
            playerLabel.Name = "playerLabel";
            // 
            // propertiesPanel
            // 
            resources.ApplyResources(propertiesPanel, "propertiesPanel");
            propertiesPanel.BackColor = Color.AliceBlue;
            propertiesPanel.BorderStyle = BorderStyle.FixedSingle;
            propertiesPanel.Controls.Add(propertyPanel);
            propertiesPanel.Name = "propertiesPanel";
            // 
            // Gameboard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(propertiesPanel);
            Controls.Add(propertiesGroupBox);
            Controls.Add(playerLabel);
            Controls.Add(panel1);
            Controls.Add(rollDiceButton);
            Controls.Add(diceGroupBox);
            Controls.Add(getOutOfJailFreeCards);
            Controls.Add(nextTurnButton);
            Controls.Add(sellButton);
            Controls.Add(buyButton);
            Controls.Add(balanceTextBox);
            Controls.Add(balanceLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Gameboard";
            propertiesGroupBox.ResumeLayout(false);
            propertyPanel.ResumeLayout(false);
            propertyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)housePictureBox).EndInit();
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
            propertiesPanel.ResumeLayout(false);
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
        private PictureBox mediterraneanAve;
        private PictureBox balticAve;
        private PictureBox readingRailroad;
        private PictureBox vermontAve;
        private PictureBox connecticutAve;
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
        private Label playerLabel;
        private Panel propertyPanel;
        private Label propertyNameLabel;
        private PictureBox housePictureBox;
        private Panel propertiesPanel;
        private Button buyHouseButton;
        private Button sellHouseButton;
    }
}
