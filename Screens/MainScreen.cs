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
                case (Keys.Space):
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
                case (Keys.Space):
                    spaceDown = true;
                    break;
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            //start tick loop
            mainScreenTimer.Enabled = true;

            //begin with start selected
            selectionState = 0;
            startLabel.BorderStyle = BorderStyle.Fixed3D;
            howToLabel.BorderStyle = BorderStyle.None;
            exitLabel.BorderStyle = BorderStyle.None;
        }

        private void mainScreenTimer_Tick(object sender, EventArgs e)
        {
            //switch selected button if down/up pressed,
            //change to corresponding screen if space pressed
            switch (selectionState)
            {
                case 0: //start selected
                    #region Case 0
                    if (downArrowDown) //change to how to selected
                    {
                        selectionState = 1;
                        howToLabel.BorderStyle = BorderStyle.Fixed3D;
                        startLabel.BorderStyle = BorderStyle.None;

                        downArrowDown = false;
                    }
                    if (spaceDown) //change to customization screen
                    {
                        mainScreenTimer.Enabled = false;

                        Form f = this.FindForm();
                        f.Controls.Remove(this);

                        Screens.CustomizationScreen ns = new Screens.CustomizationScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);

                        spaceDown = false;

                        ns.Focus();
                    }
                    #endregion
                    break;
                case 1: //how to selected
                    #region Case 1
                    if (upArrowDown) //change to start selected
                    {
                        selectionState = 0;
                        startLabel.BorderStyle = BorderStyle.Fixed3D;
                        howToLabel.BorderStyle = BorderStyle.None;

                        upArrowDown = false;
                    }
                    if (downArrowDown) //change to exit selected
                    {
                        selectionState = 2;
                        exitLabel.BorderStyle = BorderStyle.Fixed3D;
                        howToLabel.BorderStyle = BorderStyle.None;

                        downArrowDown = false;
                    }
                    if (spaceDown) //change to instuction screen
                    {
                        mainScreenTimer.Enabled = false;

                        Form f = this.FindForm();
                        f.Controls.Remove(this);

                        Screens.InstructionScreen ns = new Screens.InstructionScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);

                        spaceDown = false;

                        ns.Focus();
                    }
                    #endregion
                    break;
                case 2: //exit selected
                    #region Case 2
                    if (upArrowDown) //change to how to selected
                    {
                        selectionState = 1;
                        howToLabel.BorderStyle = BorderStyle.Fixed3D;
                        exitLabel.BorderStyle = BorderStyle.None;

                        upArrowDown = false;
                    }
                    if (spaceDown) //close application
                    {
                        Application.Exit();
                    }
                    #endregion
                    break;
            }
        }
    }
}
