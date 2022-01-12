﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGameFinal.PlayingScreens
{
    public partial class Play33 : UserControl
    {
        #region Global variables
        Boolean upArrowDown, downArrowDown, rightArrowDown, leftArrowDown, spaceDown;
        Point p = new Point();


        #endregion

        

        public Play33()
        {
            InitializeComponent();
        }


        private void Play33_Load(object sender, EventArgs e)
        {
            //start game timer
            gameTimer.Enabled = true;
        }

        private void Play33_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Up):
                    upArrowDown = false;
                    break;
                case (Keys.Down):
                    downArrowDown = false;
                    break;
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

        private void Play33_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Up):
                    upArrowDown = true;
                    break;
                case (Keys.Down):
                    downArrowDown = true;
                    break;
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

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region attempt diagonal movement
                //if (upArrowDown && rightArrowDown)
                //{
                //    Form1.player.Move("rightup");
                //    upArrowDown = false;
                //    rightArrowDown = false;
                //}
                //else if (downArrowDown && rightArrowDown)
                //{
                //    Form1.player.Move("rightdown");
                //    downArrowDown = false;
                //    rightArrowDown = false;
                //}
                //else if (upArrowDown && leftArrowDown)
                //{
                //    Form1.player.Move("leftup");
                //    upArrowDown = false;
                //    leftArrowDown = false;
                //}
                //else if (downArrowDown && leftArrowDown)
                //{
                //    Form1.player.Move("leftdown");
                //    downArrowDown = false;
                //    leftArrowDown = false;
                //}
                #endregion
            
            if (upArrowDown)
            {
                Form1.player.Move("up");
                upArrowDown = false;
            }
            else if (downArrowDown)
            {
                Form1.player.Move("down");
                downArrowDown = false;
            }
            else if (rightArrowDown)
            {
                Form1.player.Move("right");
                rightArrowDown = false;
            }
            else if (leftArrowDown)
            {
                Form1.player.Move("left");
                leftArrowDown = false;
            }

            if(Form1.player.x < 0)
            {

            }
            else if (Form1.player.x > 0)
            {

            }

            Refresh();
        }

        private void Play33_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.smallHouse, 329, 18, 96, 144);
            e.Graphics.DrawImage(Properties.Resources.playerTest, Form1.player.x, Form1.player.y, 28, 40);
        }
    }
}
