
namespace AdventureGameFinal.Screens
{
    partial class CustomizationScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.swordImage = new System.Windows.Forms.PictureBox();
            this.polearmImage = new System.Windows.Forms.PictureBox();
            this.bowImage = new System.Windows.Forms.PictureBox();
            this.daggersImage = new System.Windows.Forms.PictureBox();
            this.customScreenTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.swordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polearmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daggersImage)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe Script", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(203, 58);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(788, 113);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Choose Your Weapon";
            // 
            // swordImage
            // 
            this.swordImage.BackColor = System.Drawing.Color.Transparent;
            this.swordImage.BackgroundImage = global::AdventureGameFinal.Properties.Resources.sword2;
            this.swordImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swordImage.Location = new System.Drawing.Point(157, 225);
            this.swordImage.Name = "swordImage";
            this.swordImage.Size = new System.Drawing.Size(196, 316);
            this.swordImage.TabIndex = 3;
            this.swordImage.TabStop = false;
            // 
            // polearmImage
            // 
            this.polearmImage.BackColor = System.Drawing.Color.Transparent;
            this.polearmImage.BackgroundImage = global::AdventureGameFinal.Properties.Resources.editedpolearm;
            this.polearmImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.polearmImage.Location = new System.Drawing.Point(391, 225);
            this.polearmImage.Name = "polearmImage";
            this.polearmImage.Size = new System.Drawing.Size(196, 316);
            this.polearmImage.TabIndex = 4;
            this.polearmImage.TabStop = false;
            // 
            // bowImage
            // 
            this.bowImage.BackgroundImage = global::AdventureGameFinal.Properties.Resources.bow_arrows;
            this.bowImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bowImage.Location = new System.Drawing.Point(627, 225);
            this.bowImage.Name = "bowImage";
            this.bowImage.Size = new System.Drawing.Size(196, 316);
            this.bowImage.TabIndex = 5;
            this.bowImage.TabStop = false;
            // 
            // daggersImage
            // 
            this.daggersImage.BackColor = System.Drawing.Color.Transparent;
            this.daggersImage.BackgroundImage = global::AdventureGameFinal.Properties.Resources.set_daggers;
            this.daggersImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.daggersImage.Location = new System.Drawing.Point(861, 225);
            this.daggersImage.Name = "daggersImage";
            this.daggersImage.Size = new System.Drawing.Size(196, 316);
            this.daggersImage.TabIndex = 6;
            this.daggersImage.TabStop = false;
            // 
            // customScreenTimer
            // 
            this.customScreenTimer.Interval = 20;
            this.customScreenTimer.Tick += new System.EventHandler(this.customScreenTimer_Tick);
            // 
            // CustomizationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventureGameFinal.Properties.Resources.mainscreenbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.daggersImage);
            this.Controls.Add(this.bowImage);
            this.Controls.Add(this.polearmImage);
            this.Controls.Add(this.swordImage);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Name = "CustomizationScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.CustomizationScreen_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CustomizationScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CustomizationScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.swordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polearmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daggersImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox swordImage;
        private System.Windows.Forms.PictureBox polearmImage;
        private System.Windows.Forms.PictureBox bowImage;
        private System.Windows.Forms.PictureBox daggersImage;
        private System.Windows.Forms.Timer customScreenTimer;
    }
}
