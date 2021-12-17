﻿using System;
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
                    spaceDown = true;
                    break;
                case (Keys.Escape):
                    Application.Exit();
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
            weaponImages.Add(catalystImage);

            //start with far left selected
            selectionState = 0;
            weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;
        }

        private void customScreenTimer_Tick(object sender, EventArgs e)
        {
            switch (selectionState)
            {
                case 0: //sword selected
                    if (rightArrowDown) //change to next selection to the right
                    {
                        //remove border from current selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.None;

                        //change selection int
                        selectionState = 1;

                        //add border to new selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;

                        rightArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        //player.weapon = "mainSword";
                        StartGame();
                    }
                    break;
                case 1: //polearm selected
                    if (rightArrowDown) //change to next selection to the right
                    {
                        //remove border from current selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.None;

                        //change selection int
                        selectionState = 2;

                        //add border to new selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;

                        rightArrowDown = false;
                    }
                    if (leftArrowDown) //change to next selection to the left
                    {
                        //remove border from current selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.None;

                        //change selection int
                        selectionState = 0;

                        //add border to new selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;

                        leftArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        //player.weapon = "mainPolearm";
                        StartGame();
                    }
                    break;
                case 2: //bow selected
                    if (rightArrowDown) //change to next selection to the right
                    {
                        //remove border from current selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.None;

                        //change selection int
                        selectionState = 3;

                        //add border to new selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;

                        rightArrowDown = false;
                    }
                    if (leftArrowDown) //change to next selection to the left
                    {
                        //remove border from current selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.None;

                        //change selection int
                        selectionState = 1;

                        //add border to new selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;

                        leftArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        //player.weapon = "mainBow";
                        StartGame();
                    }
                    break;
                case 3: //catalyst selected
                    if (leftArrowDown) //change to next selection to the left
                    {
                        //remove border from current selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.None;

                        //change selection int
                        selectionState = 2;

                        //add border to new selection
                        weaponImages[selectionState].BorderStyle = BorderStyle.Fixed3D;

                        leftArrowDown = false;
                    }
                    if (spaceDown) //save selection, change to play screen
                    {
                        //player.weapon = "mainCatalyst";
                        StartGame();
                    }
                    break;
            }
        }

        /// <summary>
        /// Change to starting playing screen
        /// </summary>
        void StartGame()
        {
            customScreenTimer.Enabled = false;

            Form f = this.FindForm();
            f.Controls.Remove(this);

            Playing_Screens._33 ns = new Playing_Screens._33();
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);

            spaceDown = false;

            ns.Focus();
        }
    }
}
