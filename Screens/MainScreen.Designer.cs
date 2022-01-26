
namespace AdventureGameFinal
{
    partial class MainScreen
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
            this.startLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.howToLabel = new System.Windows.Forms.Label();
            this.mainScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exitLabel = new System.Windows.Forms.Label();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.loadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(325, 231);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(629, 95);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start New Game";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(277, 100);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(660, 113);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Adventure Game";
            // 
            // howToLabel
            // 
            this.howToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.howToLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howToLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToLabel.Location = new System.Drawing.Point(363, 422);
            this.howToLabel.Name = "howToLabel";
            this.howToLabel.Size = new System.Drawing.Size(517, 95);
            this.howToLabel.TabIndex = 2;
            this.howToLabel.Text = "How To Play";
            this.howToLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainScreenTimer
            // 
            this.mainScreenTimer.Enabled = true;
            this.mainScreenTimer.Interval = 20;
            this.mainScreenTimer.Tick += new System.EventHandler(this.mainScreenTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AdventureGameFinal.Properties.Resources.catalystspritesheetsingle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(72, 458);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 186);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // exitLabel
            // 
            this.exitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.Location = new System.Drawing.Point(389, 517);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(448, 95);
            this.exitLabel.TabIndex = 4;
            this.exitLabel.Text = "Exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // spaceLabel
            // 
            this.spaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceLabel.BackColor = System.Drawing.Color.Transparent;
            this.spaceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spaceLabel.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceLabel.ForeColor = System.Drawing.Color.Black;
            this.spaceLabel.Location = new System.Drawing.Point(363, 613);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(517, 64);
            this.spaceLabel.TabIndex = 5;
            this.spaceLabel.Text = "Press space to select";
            this.spaceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadLabel
            // 
            this.loadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadLabel.Location = new System.Drawing.Point(389, 327);
            this.loadLabel.Name = "loadLabel";
            this.loadLabel.Size = new System.Drawing.Size(448, 95);
            this.loadLabel.TabIndex = 6;
            this.loadLabel.Text = "Load Game";
            this.loadLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AdventureGameFinal.Properties.Resources.mainscreenbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.loadLabel);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.howToLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1200, 701);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label howToLabel;
        private System.Windows.Forms.Timer mainScreenTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Label loadLabel;
    }
}
