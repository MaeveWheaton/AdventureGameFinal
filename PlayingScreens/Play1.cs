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
    public partial class Play1 : UserControl
    {
        #region Global variables
        Boolean upArrowDown, downArrowDown, rightArrowDown, leftArrowDown, spaceDown;
        #endregion

        public Play1()
        {
            InitializeComponent();
        }

        private void Play1_Load(object sender, EventArgs e)
        {
            //start game timer
            gameTimer.Enabled = true;
        }

        private void Play1_KeyUp(object sender, KeyEventArgs e)
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

        private void Play1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

            if (Form1.player.x < 0)
            {

            }
            else if (Form1.player.x > 0)
            {

            }

            Refresh();
        }

        private void Play1_Paint(object sender, PaintEventArgs e)
        {
            #region trees
            for(int i = 50; i < 1050; i += 72)
            {
                e.Graphics.DrawImage(Properties.Resources.greentree, i, 20, 67, 120);
                e.Graphics.DrawImage(Properties.Resources.greentree, i + 20, 40, 67, 120);
            }
            #endregion

            e.Graphics.DrawImage(Properties.Resources.smallHouse, 700, 260, 96, 144);
            e.Graphics.DrawImage(Properties.Resources.playerTest, Form1.player.x, Form1.player.y, 28, 40);
        }
    }
}
