using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGameFinal
{
    public partial class MainScreen : UserControl
    {
        #region Global variables
        Boolean upArrowDown, downArrowDown, spaceDown;
        int selectionState = 0;
        #endregion

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Up):
                    upArrowDown = false;
                    break;
                case (Keys.Down):
                    downArrowDown = false;
                    break;
                case (Keys.B):
                    spaceDown = false;
                    break;
            }
        }

        private void MainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Up):
                    upArrowDown = true;
                    break;
                case (Keys.Down):
                    downArrowDown = true;
                    break;
                case (Keys.B):
                    spaceDown = true;
                    break;
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            mainScreenTimer.Enabled = true;
            startLabel.BorderStyle = BorderStyle.Fixed3D;
        }

        private void mainScreenTimer_Tick(object sender, EventArgs e)
        {
            if (downArrowDown)
            {
                selectionState = 1;
                howToLabel.BorderStyle = BorderStyle.Fixed3D;
                startLabel.BorderStyle = BorderStyle.None;

                downArrowDown = false;
            }
            if (upArrowDown)
            {
                selectionState = 0;
                startLabel.BorderStyle = BorderStyle.Fixed3D;
                howToLabel.BorderStyle = BorderStyle.None;

                upArrowDown = false;
            }
            
            if(spaceDown)
            {
                if(selectionState == 0)
                {
                    mainScreenTimer.Enabled = false;

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    //CustomizationScreen cs = new CustomizationScreen();
                    //gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
                    //f.Controls.Add(gs);

                    //bDown = false;

                    //gs.Focus();
                }
                else
                {

                }
            }
        }

        
    }
}
