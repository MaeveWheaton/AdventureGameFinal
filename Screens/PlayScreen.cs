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
    public partial class PlayScreen : UserControl
    {
        #region Global variables
        Boolean upArrowDown, downArrowDown, rightArrowDown, leftArrowDown, spaceDown;
        string[] screenLetters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
        int screenLetter = 4;
        int screenNumber = 14;
        string currentScreen;
        string conversation = "intro";
        int conversationIndex = 0;
        #endregion

        public PlayScreen()
        {
            InitializeComponent();
        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {
            //start game timer
            convoTimer.Enabled = true;
        }

        private void PlayScreen_KeyUp(object sender, KeyEventArgs e)
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

        private void PlayScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
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

        private void convoTimer_Tick(object sender, EventArgs e)
        {
            switch (conversation)
            {
                case "intro":
                    #region intro
                    textLabel.Visible = true;
                    characterImage.Visible = true;

                    switch (conversationIndex)
                    {
                        case 0:
                            textLabel.Text = "Welcome to Misaploya. You have just graduated from your training, " +
                                "you are now free to roam the world and take on quests to make a name for yourself. \nSpace to continue";
                            break;
                        case 1:
                            textLabel.Text = "You have been provided with a map of Misaploya to aid you in your travels. " +
                                "Press space while travelling to look at it (not available yet). " +
                                "It is suggested that you start small and work your way up to harder quests, visit the town to the southwest to find some smaller quests, " +
                                "but by all means, if you think you can take on something harder there are three main quests marked on your map. \nSpace to continue";
                            break;
                        case 2:
                            textLabel.Text = "If a quest should be too much for you, you will be brought back here to recover. Now off you go, good luck. \nSpace to start";
                            break;
                        case 3:
                            conversationIndex = 0;
                            textLabel.Visible = false;
                            characterImage.Visible = false;
                            convoTimer.Enabled = false;
                            gameTimer.Enabled = true;
                            break;
                    }

                    if (spaceDown)
                    {
                        conversationIndex++;
                    }

                    #endregion
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region player movement code
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
                screenLetter--;
                Form1.player.x = 1200 + Form1.player.x;
            }
            else if (Form1.player.x > 1200)
            {
                screenLetter++;
                Form1.player.x = 0 + (Form1.player.x - 1200);
            }
            else if (Form1.player.y < 0)
            {
                screenNumber--;
                Form1.player.y = 700 + Form1.player.y;
            }
            else if (Form1.player.y > 700)
            {
                screenNumber++;
                Form1.player.y = 0 + (Form1.player.y - 700);
            }
            #endregion


            Refresh();
        }

        private void PlayScreen_Paint(object sender, PaintEventArgs e)
        {
            currentScreen = screenNumber + screenLetters[screenLetter];
            switch (currentScreen)
            {
                case "14E":
                    #region trees
                    for (int i = 50; i < 1050; i += 72)
                    {
                        e.Graphics.DrawImage(Properties.Resources.greentree, i, 20, 67, 120);
                        e.Graphics.DrawImage(Properties.Resources.greentree, i + 20, 40, 67, 120);
                    }
                    #endregion

                    e.Graphics.DrawImage(Properties.Resources.smallHouse, 700, 260, 96, 144);
                    break;

            }

            e.Graphics.DrawImage(Properties.Resources.playerTest, Form1.player.x, Form1.player.y, 28, 40);
        }
    }
}
