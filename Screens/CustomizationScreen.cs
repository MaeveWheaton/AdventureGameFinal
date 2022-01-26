using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGameFinal.Screens
{
    public partial class CustomizationScreen : UserControl
    {
        #region Global variables
        List<PictureBox> weaponImages = new List<PictureBox>();
        Boolean rightArrowDown, leftArrowDown, spaceDown;
        int selectionState = 0;
        int selection = 4;
        #endregion

        public CustomizationScreen()
        {
            InitializeComponent();
        }

        private void CustomizationScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Right):
                    rightArrowDown = false;
                    break;
                case (Keys.Left):
                    leftArrowDown = false;
                    break;
                case (Keys.Space):
                    spaceDown = false;
                    break;
            }
        }

        private void CustomizationScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Right):
                    rightArrowDown = true;
                    break;
                case (Keys.Left):
                    leftArrowDown = true;
                    break;
                case (Keys.Space):
                    if (selection == selectionState)
                    {
                        StartGame();
                    }
                    else
                    {
                        spaceDown = true;
                    }
                    break;
                case (Keys.Escape):
                    customScreenTimer.Enabled = false;

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    MainScreen ns = new MainScreen();
                    ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                    f.Controls.Add(ns);

                    spaceDown = false;

                    ns.Focus();
                    break;
            }
        }

        private void CustomizationScreen_Load(object sender, EventArgs e)
        {
            //start tick loop
            customScreenTimer.Enabled = true;

            //set up wepons list
            weaponImages.Add(swordImage);
            weaponImages.Add(polearmImage);
            weaponImages.Add(bowImage);
            weaponImages.Add(daggersImage);

            //start with far left selected
            selectionState = 0;
            weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;
        }

        private void customScreenTimer_Tick(object sender, EventArgs e)
        {
            //change instuction label when weapon selected
            if (selection == selectionState)
            {
                instructionLabel.Text = "Space to Start";
            }
            else
            {
                instructionLabel.Text = "Space to Select";
            }

            //change selected weapon if right/left keys pressed,
            //save selection and begin game if space pressed
            switch (selectionState)
            {
                case 0: //sword selected
                    #region Case 0
                    if (rightArrowDown) //change to next selection to the right
                    {
                        ChangeCurrentSelected(1);

                        rightArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        Form1.player.weaponList = Form1.swords;
                        Form1.player.weaponType = "sword";
                        ChangeSelection();
                    }
                    #endregion
                    break;
                case 1: //polearm selected
                    #region Case 1
                    if (rightArrowDown) //change to next selection to the right
                    {
                        ChangeCurrentSelected(2);

                        rightArrowDown = false;
                    }
                    if (leftArrowDown) //change to next selection to the left
                    {
                        ChangeCurrentSelected(0);

                        leftArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        Form1.player.weaponList = Form1.polearms;
                        Form1.player.weaponType = "polearm";
                        ChangeSelection();
                    }
                    #endregion
                    break;
                case 2: //bow selected
                    #region Case 2
                    if (rightArrowDown) //change to next selection to the right
                    {
                        ChangeCurrentSelected(3);

                        rightArrowDown = false;
                    }
                    if (leftArrowDown) //change to next selection to the left
                    {
                        ChangeCurrentSelected(1);

                        leftArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        Form1.player.weaponList = Form1.bows;
                        Form1.player.weaponType = "bow";
                        ChangeSelection();
                    }
                    #endregion
                    break;
                case 3: //daggers selected
                    #region Case 3
                    if (leftArrowDown) //change to next selection to the left
                    {
                        ChangeCurrentSelected(2);

                        leftArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        Form1.player.weaponList = Form1.daggers;
                        Form1.player.weaponType = "daggers";
                        ChangeSelection();
                    }
                    #endregion
                    break;
            }
        }

        /// <summary>
        /// Change to starting playing screen
        /// </summary>
        void StartGame()
        {
            Form1.player.weapon = 0;
            Form1.playerWeapon = Form1.player.weaponList[Form1.player.weapon];
            customScreenTimer.Enabled = false;

            Form f = this.FindForm();
            f.Controls.Remove(this);

            Screens.PlayScreen ns = new Screens.PlayScreen();
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);

            spaceDown = false;

            ns.Focus();
        }

        void ChangeCurrentSelected(int state)
        {
            //remove border from current selection
            weaponImages[selectionState].BorderStyle = BorderStyle.None;

            //change selection int
            selectionState = state;

            //add border to new selection
            weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;
        }

        void ChangeSelection()
        {
            try
            {
                weaponImages[selection].BackColor = Color.Transparent;
                weaponImages[selectionState].BackColor = Color.White;
                selection = selectionState;
                spaceDown = false;
            }
            catch
            {
                weaponImages[selectionState].BackColor = Color.White;
                selection = selectionState;
                spaceDown = false;
            }            
        }
    }
}
