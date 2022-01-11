using System;
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

            

            Refresh();
        }

        private void Play33_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.catalystspritesheetsingle, Form1.player.x, Form1.player.y);
        }
    }
}
