
namespace AdventureGameFinal.Screens
{
    partial class PlayScreen
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.textLabel = new System.Windows.Forms.Label();
            this.characterImage = new System.Windows.Forms.PictureBox();
            this.convoTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.White;
            this.textLabel.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(0, 600);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(1200, 100);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Welcome to Misaploya. you have completed your beginners training.  You are now fr" +
    "ee to roam the world and complete quests. I would suggest starting with visiting" +
    " the town to the southwest.";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textLabel.Visible = false;
            // 
            // characterImage
            // 
            this.characterImage.Image = global::AdventureGameFinal.Properties.Resources.catalystspritesheetsingle;
            this.characterImage.InitialImage = null;
            this.characterImage.Location = new System.Drawing.Point(954, 407);
            this.characterImage.Name = "characterImage";
            this.characterImage.Size = new System.Drawing.Size(159, 238);
            this.characterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImage.TabIndex = 2;
            this.characterImage.TabStop = false;
            this.characterImage.Visible = false;
            // 
            // convoTimer
            // 
            this.convoTimer.Tick += new System.EventHandler(this.convoTimer_Tick);
            // 
            // PlayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::AdventureGameFinal.Properties.Resources.grass2__1_;
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.characterImage);
            this.DoubleBuffered = true;
            this.Name = "PlayScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.PlayScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PlayScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PlayScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.characterImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.PictureBox characterImage;
        private System.Windows.Forms.Timer convoTimer;
    }
}
