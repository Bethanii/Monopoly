namespace MonopolyGame
{
    partial class StartMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Panel1 = new Panel();
            panel2 = new Panel();
            carButton = new Button();
            ironButton = new Button();
            shoeButton = new Button();
            wheelbarrowButton = new Button();
            thimbleButton = new Button();
            hatButton = new Button();
            dogButton = new Button();
            shipButton = new Button();
            startGameButton = new Button();
            button17 = new Button();
            label3 = new Label();
            label1 = new Label();
            playerNameTextBox = new TextBox();
            Panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Transparent;
            Panel1.Controls.Add(panel2);
            Panel1.Controls.Add(startGameButton);
            Panel1.Controls.Add(button17);
            Panel1.Controls.Add(label3);
            Panel1.Controls.Add(label1);
            Panel1.Controls.Add(playerNameTextBox);
            Panel1.Location = new Point(10, 10);
            Panel1.Margin = new Padding(0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(360, 560);
            Panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(carButton);
            panel2.Controls.Add(ironButton);
            panel2.Controls.Add(shoeButton);
            panel2.Controls.Add(wheelbarrowButton);
            panel2.Controls.Add(thimbleButton);
            panel2.Controls.Add(hatButton);
            panel2.Controls.Add(dogButton);
            panel2.Controls.Add(shipButton);
            panel2.Location = new Point(44, 192);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 100);
            panel2.TabIndex = 26;
            // 
            // carButton
            // 
            carButton.BackColor = Color.WhiteSmoke;
            carButton.BackgroundImage = Properties.Resources.raceCar;
            carButton.BackgroundImageLayout = ImageLayout.Center;
            carButton.FlatAppearance.BorderColor = Color.White;
            carButton.FlatAppearance.BorderSize = 0;
            carButton.FlatStyle = FlatStyle.Flat;
            carButton.Location = new Point(14, 57);
            carButton.Name = "carButton";
            carButton.RightToLeft = RightToLeft.No;
            carButton.Size = new Size(40, 40);
            carButton.TabIndex = 20;
            carButton.UseVisualStyleBackColor = false;
            carButton.Click += carButton_Click;
            // 
            // ironButton
            // 
            ironButton.BackColor = Color.White;
            ironButton.BackgroundImage = Properties.Resources.iron;
            ironButton.FlatAppearance.BorderColor = Color.Blue;
            ironButton.FlatAppearance.BorderSize = 0;
            ironButton.FlatStyle = FlatStyle.Flat;
            ironButton.Location = new Point(207, -1);
            ironButton.Name = "ironButton";
            ironButton.RightToLeft = RightToLeft.No;
            ironButton.Size = new Size(40, 40);
            ironButton.TabIndex = 16;
            ironButton.UseVisualStyleBackColor = false;
            ironButton.Click += ironButton_Click;
            // 
            // shoeButton
            // 
            shoeButton.BackColor = Color.WhiteSmoke;
            shoeButton.BackgroundImage = Properties.Resources.shoe;
            shoeButton.FlatAppearance.BorderColor = Color.White;
            shoeButton.FlatAppearance.BorderSize = 0;
            shoeButton.FlatStyle = FlatStyle.Flat;
            shoeButton.Location = new Point(79, 57);
            shoeButton.Name = "shoeButton";
            shoeButton.RightToLeft = RightToLeft.No;
            shoeButton.Size = new Size(40, 40);
            shoeButton.TabIndex = 19;
            shoeButton.UseVisualStyleBackColor = false;
            shoeButton.Click += shoeButton_Click;
            // 
            // wheelbarrowButton
            // 
            wheelbarrowButton.BackColor = Color.WhiteSmoke;
            wheelbarrowButton.BackgroundImage = Properties.Resources.wheelbarrow;
            wheelbarrowButton.BackgroundImageLayout = ImageLayout.Center;
            wheelbarrowButton.FlatAppearance.BorderColor = Color.Blue;
            wheelbarrowButton.FlatAppearance.BorderSize = 0;
            wheelbarrowButton.FlatStyle = FlatStyle.Flat;
            wheelbarrowButton.Location = new Point(207, 57);
            wheelbarrowButton.Name = "wheelbarrowButton";
            wheelbarrowButton.RightToLeft = RightToLeft.No;
            wheelbarrowButton.Size = new Size(40, 40);
            wheelbarrowButton.TabIndex = 18;
            wheelbarrowButton.UseVisualStyleBackColor = false;
            wheelbarrowButton.Click += wheelbarrowButton_Click;
            // 
            // thimbleButton
            // 
            thimbleButton.BackColor = Color.WhiteSmoke;
            thimbleButton.BackgroundImage = Properties.Resources.thimble;
            thimbleButton.FlatAppearance.BorderColor = Color.Blue;
            thimbleButton.FlatAppearance.BorderSize = 0;
            thimbleButton.FlatStyle = FlatStyle.Flat;
            thimbleButton.Location = new Point(144, 57);
            thimbleButton.Name = "thimbleButton";
            thimbleButton.RightToLeft = RightToLeft.No;
            thimbleButton.Size = new Size(40, 40);
            thimbleButton.TabIndex = 17;
            thimbleButton.UseVisualStyleBackColor = false;
            thimbleButton.Click += thimbleButton_Click;
            // 
            // hatButton
            // 
            hatButton.BackColor = Color.WhiteSmoke;
            hatButton.BackgroundImage = Properties.Resources.hat;
            hatButton.BackgroundImageLayout = ImageLayout.Center;
            hatButton.FlatAppearance.BorderColor = Color.Blue;
            hatButton.FlatAppearance.BorderSize = 0;
            hatButton.FlatStyle = FlatStyle.Flat;
            hatButton.Location = new Point(144, -1);
            hatButton.Name = "hatButton";
            hatButton.RightToLeft = RightToLeft.No;
            hatButton.Size = new Size(40, 40);
            hatButton.TabIndex = 15;
            hatButton.UseVisualStyleBackColor = false;
            hatButton.Click += hatButton_Click;
            // 
            // dogButton
            // 
            dogButton.BackColor = Color.WhiteSmoke;
            dogButton.BackgroundImage = Properties.Resources.dog;
            dogButton.FlatAppearance.BorderColor = Color.Blue;
            dogButton.FlatAppearance.BorderSize = 0;
            dogButton.FlatStyle = FlatStyle.Flat;
            dogButton.Location = new Point(79, 0);
            dogButton.Name = "dogButton";
            dogButton.RightToLeft = RightToLeft.No;
            dogButton.Size = new Size(40, 40);
            dogButton.TabIndex = 14;
            dogButton.UseVisualStyleBackColor = false;
            dogButton.Click += dogButton_Click;
            // 
            // shipButton
            // 
            shipButton.BackColor = Color.WhiteSmoke;
            shipButton.BackgroundImageLayout = ImageLayout.Center;
            shipButton.FlatAppearance.BorderColor = Color.Blue;
            shipButton.FlatAppearance.BorderSize = 0;
            shipButton.FlatStyle = FlatStyle.Flat;
            shipButton.Image = Properties.Resources.battleShip;
            shipButton.Location = new Point(14, -1);
            shipButton.Name = "shipButton";
            shipButton.RightToLeft = RightToLeft.No;
            shipButton.Size = new Size(40, 40);
            shipButton.TabIndex = 13;
            shipButton.UseVisualStyleBackColor = false;
            shipButton.Click += shipButton_Click;
            // 
            // startGameButton
            // 
            startGameButton.BackColor = Color.Navy;
            startGameButton.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            startGameButton.ForeColor = Color.Gold;
            startGameButton.Location = new Point(96, 368);
            startGameButton.Margin = new Padding(0);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(155, 40);
            startGameButton.TabIndex = 22;
            startGameButton.Text = "Start Game";
            startGameButton.TextAlign = ContentAlignment.TopCenter;
            startGameButton.UseVisualStyleBackColor = false;
            startGameButton.Click += startGameButton_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.Navy;
            button17.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = Color.Goldenrod;
            button17.Location = new Point(58, 322);
            button17.Margin = new Padding(0);
            button17.Name = "button17";
            button17.Size = new Size(233, 40);
            button17.TabIndex = 21;
            button17.Text = "Add Player";
            button17.TextAlign = ContentAlignment.TopCenter;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Goldenrod;
            label3.Location = new Point(94, 159);
            label3.Name = "label3";
            label3.Size = new Size(157, 30);
            label3.TabIndex = 11;
            label3.Text = "Select Your Piece";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Goldenrod;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(264, 30);
            label1.TabIndex = 1;
            label1.Text = "Select Your Player Name";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            playerNameTextBox.Font = new Font("Sitka Banner", 18F, FontStyle.Bold, GraphicsUnit.Point);
            playerNameTextBox.Location = new Point(82, 89);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(180, 38);
            playerNameTextBox.TabIndex = 0;
            playerNameTextBox.TextChanged += playerNameTextBox_TextChanged;
            // 
            // StartMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(384, 480);
            Controls.Add(Panel1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "StartMenu";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Monopoly";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel1;
        private Label label1;
        private TextBox playerNameTextBox;
        private Label label3;
        private Button carButton;
        private Button shoeButton;
        private Button wheelbarrowButton;
        private Button thimbleButton;
        private Button ironButton;
        private Button hatButton;
        private Button dogButton;
        private Button shipButton;
        private Button startGameButton;
        private Button button17;
        private Panel panel2;
    }
}