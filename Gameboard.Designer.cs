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
            gameBoard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gameBoard).BeginInit();
            SuspendLayout();
            // 
            // gameBoard
            // 
            gameBoard.Image = (Image)resources.GetObject("gameBoard.Image");
            gameBoard.Location = new Point(12, -10);
            gameBoard.MaximumSize = new Size(800, 800);
            gameBoard.Name = "gameBoard";
            gameBoard.Size = new Size(784, 759);
            gameBoard.SizeMode = PictureBoxSizeMode.StretchImage;
            gameBoard.TabIndex = 0;
            gameBoard.TabStop = false;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 761);
            Controls.Add(gameBoard);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gameBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
