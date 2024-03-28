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
            groupBox1 = new GroupBox();
            gameBoardImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(727, 308);
            groupBox1.MaximumSize = new Size(310, 338);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 338);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Properties";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gameBoardImage
            // 
            gameBoardImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameBoardImage.BackgroundImage = (Image)resources.GetObject("gameBoardImage.BackgroundImage");
            gameBoardImage.BackgroundImageLayout = ImageLayout.Stretch;
            gameBoardImage.Location = new Point(52, 67);
            gameBoardImage.MaximumSize = new Size(1000, 1000);
            gameBoardImage.Name = "gameBoardImage";
            gameBoardImage.Size = new Size(555, 555);
            gameBoardImage.TabIndex = 2;
            gameBoardImage.TabStop = false;
            // 
            // Gameboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 671);
            Controls.Add(gameBoardImage);
            Controls.Add(groupBox1);
            Name = "Gameboard";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gameBoardImage).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private PictureBox gameBoardImage;
    }
}
