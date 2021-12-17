
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
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startLabel.AutoSize = true;
            this.startLabel.BackColor = System.Drawing.Color.Transparent;
            this.startLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(396, 256);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(400, 95);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Start Game";
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(278, 99);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(660, 113);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Adventure Game";
            // 
            // howToLabel
            // 
            this.howToLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.howToLabel.AutoSize = true;
            this.howToLabel.BackColor = System.Drawing.Color.Transparent;
            this.howToLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.howToLabel.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToLabel.Location = new System.Drawing.Point(366, 394);
            this.howToLabel.Name = "howToLabel";
            this.howToLabel.Size = new System.Drawing.Size(442, 95);
            this.howToLabel.TabIndex = 2;
            this.howToLabel.Text = "How To Play";
            // 
            // mainScreenTimer
            // 
            this.mainScreenTimer.Enabled = true;
            this.mainScreenTimer.Interval = 20;
            this.mainScreenTimer.Tick += new System.EventHandler(this.mainScreenTimer_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventureGameFinal.Properties.Resources.mainscreenbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.howToLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startLabel);
            this.DoubleBuffered = true;
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.MainScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label howToLabel;
        private System.Windows.Forms.Timer mainScreenTimer;
    }
}
