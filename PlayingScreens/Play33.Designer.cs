﻿
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
            this.hutPictureBox = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hutPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hutPictureBox
            // 
            this.hutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.hutPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hutPictureBox.Image = global::AdventureGameFinal.Properties.Resources.greentree;
            this.hutPictureBox.Location = new System.Drawing.Point(702, 169);
            this.hutPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.hutPictureBox.Name = "hutPictureBox";
            this.hutPictureBox.Size = new System.Drawing.Size(67, 120);
            this.hutPictureBox.TabIndex = 2;
            this.hutPictureBox.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Play33
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::AdventureGameFinal.Properties.Resources.grass2__1_;
            this.Controls.Add(this.hutPictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Play33";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.Play33_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Play33_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Play33_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Play33_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hutPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hutPictureBox;
        private System.Windows.Forms.Timer gameTimer;
    }
}
