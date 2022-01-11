
namespace AdventureGameFinal.PlayingScreens
{
    partial class Play33
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play33));
            this.hutPictureBox = new System.Windows.Forms.PictureBox();
            this.playerSprite = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).BeginInit();
            this.SuspendLayout();
            // 
            // hutPictureBox
            // 
            this.hutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.hutPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hutPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hutPictureBox.Image")));
            this.hutPictureBox.Location = new System.Drawing.Point(871, 51);
            this.hutPictureBox.Name = "hutPictureBox";
            this.hutPictureBox.Size = new System.Drawing.Size(185, 284);
            this.hutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hutPictureBox.TabIndex = 2;
            this.hutPictureBox.TabStop = false;
            // 
            // playerSprite
            // 
            this.playerSprite.BackColor = System.Drawing.Color.Transparent;
            this.playerSprite.Image = global::AdventureGameFinal.Properties.Resources.catalystspritesheetsingle;
            this.playerSprite.Location = new System.Drawing.Point(778, 276);
            this.playerSprite.Name = "playerSprite";
            this.playerSprite.Size = new System.Drawing.Size(56, 80);
            this.playerSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerSprite.TabIndex = 3;
            this.playerSprite.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Play33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventureGameFinal.Properties.Resources.grass2__1_;
            this.Controls.Add(this.playerSprite);
            this.Controls.Add(this.hutPictureBox);
            this.DoubleBuffered = true;
            this.Name = "Play33";
            this.Size = new System.Drawing.Size(1200, 700);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Play33_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Play33_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerSprite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hutPictureBox;
        private System.Windows.Forms.PictureBox playerSprite;
        private System.Windows.Forms.Timer gameTimer;
    }
}
