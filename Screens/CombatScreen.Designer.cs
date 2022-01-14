
namespace AdventureGameFinal.Screens
{
    partial class CombatScreen
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
            this.combatTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // combatTimer
            // 
            this.combatTimer.Interval = 50;
            this.combatTimer.Tick += new System.EventHandler(this.combatTimer_Tick);
            // 
            // CombatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "CombatScreen";
            this.Size = new System.Drawing.Size(1200, 700);
            this.Load += new System.EventHandler(this.CombatScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CombatScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CombatScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.CombatScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer combatTimer;
    }
}
