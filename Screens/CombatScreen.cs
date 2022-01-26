using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace AdventureGameFinal.Screens
{
    public partial class CombatScreen : UserControl
    {
        #region Global variables
        Boolean bDown, mDown, nDown, spaceDown;
        string playerAction = "waiting";
        bool playerTurn = true;
        int shieldCounter = 720;
        int specialAttackCounter = 0; //after 3 normal attacks you can use a special attack

        Pen blackPen = new Pen(Color.Black, 6);
        Pen whitePen = new Pen(Color.White, 4);
        Pen specialOutline = new Pen(Color.Black, 4);
        SolidBrush shieldBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush playerHealth = new SolidBrush(Color.Green);
        SolidBrush opponentHealth = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);

        //music variables
        System.Windows.Media.MediaPlayer music;
        System.Windows.Media.MediaPlayer specialAttackSound;
        int musicCounter = 10000;
        int musicLoop = 5900;
        #endregion

        public CombatScreen()
        {
            InitializeComponent();
        }

        private void CombatScreen_Load(object sender, EventArgs e)
        {
            //start timer
            combatTimer.Enabled = true;

            //open music file
            music = new System.Windows.Media.MediaPlayer();
            music.Open(new Uri(Application.StartupPath + "/Resources/battle_music.mp3"));
            specialAttackSound = new System.Windows.Media.MediaPlayer();
            specialAttackSound.Open(new Uri(Application.StartupPath + "/Resources/special_attack.mp3"));
        }

        private void CombatScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.B):
                    bDown = false;
                    break;
                case (Keys.N):
                    nDown = false;
                    break;
                case (Keys.M):
                    mDown = false;
                    break;
                case (Keys.Space):
                    spaceDown = false;
                    break;
            }
        }

        private void CombatScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.B):
                    playerAction = "attack";
                    break;
                case (Keys.N):
                    if(specialAttackCounter >= 3)
                    {
                        specialAttackSound.Play();
                        playerAction = "specialAttack";
                        specialAttackCounter = 0;
                    }
                    break;
                case (Keys.M):
                    playerAction = "defend";
                    break;
                case (Keys.Space):
                    spaceDown = true;
                    break;
                case (Keys.Escape):
                    //pause battle, leave without completing
                    break;
            }
        }

        private void combatTimer_Tick(object sender, EventArgs e)
        {
            //reduce shield time
            if (Form1.player.shielded)
            {
                shieldCounter -= 5;
            }
            
            //if shield time has run out, remove shield
            if(shieldCounter == 0)
            {
                Form1.player.shielded = false;
                shieldCounter = 720;
            }

            //if player turn do player action, else do opponent action
            if (playerTurn)
            {
                if(playerAction == "waiting") {}
                else
                {
                    if(playerAction == "attack")
                    {
                        specialAttackCounter++;
                    }
                    Form1.player.Combat(playerAction, Form1.playerWeapon.strength, Form1.opponent);
                    playerAction = "waiting";
                    playerTurn = false;
                }
            }
            else
            {
                Form1.opponent.Combat(Form1.player, Form1.opponent.weaponStrength, 5);
                playerTurn = true;
            }

            if(Form1.player.health <= 0)
            {
                combatTimer.Enabled = false;
                ReturnToGame();
            }
            else if(Form1.opponent.health <= 0)
            {
                combatTimer.Enabled = false;
                Form1.opponent.defeated = true;
                ReturnToGame();
            }

            MusicLoop();

            Refresh();
        }

        private void CombatScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw bg
            e.Graphics.DrawImage(Properties.Resources.forest_edge, 0, 0, 1200, 700);

            //draw white behind bars
            e.Graphics.FillRectangle(whiteBrush , 10, 10, 300  , 30);
            e.Graphics.FillRectangle(whiteBrush,this.Width - 310, 10, 300, 30);

            //draw health bars
            e.Graphics.FillRectangle(playerHealth, 10, 10, Form1.player.health * 3, 30);
            e.Graphics.FillRectangle(opponentHealth, this.Width - 310, 10, Form1.opponent.health * 3, 30);

            //draw outlines
            e.Graphics.DrawRectangle(blackPen, 7, 7, 306, 36);
            e.Graphics.DrawRectangle(blackPen, this.Width - 313, 7, 306, 36);

            //if shielded, draw shield and timer - circle
            if (Form1.player.shielded)
            {
                e.Graphics.FillPie(shieldBrush, 320, 7, 36, 36, 0, shieldCounter / 2);
                e.Graphics.DrawEllipse(blackPen, 210, 380, 200, 200);
            }

            //draw special attack warm up and outline, if charged change outline to white
            if(specialAttackCounter >= 3)
            {
                specialOutline.Color = Color.White;
            }
            else
            {
                specialOutline.Color = Color.Black;
            }
            e.Graphics.DrawEllipse(specialOutline, 50, 500, 100, 100);
            e.Graphics.FillPie(whiteBrush, 50, 500, 100, 100, 0, 120 * specialAttackCounter);
            e.Graphics.DrawString("N", new Font("Segoe Script", 20), blackBrush, 65, 545);

            //draw characters
            e.Graphics.DrawImage(Form1.player.image, 250, 400, 28 * 4, 40 * 4);
            e.Graphics.DrawImage(Form1.opponent.image, 900, 400, 28 * 4, 40 * 4);
        }

        void ReturnToGame()
        {
            Form1.player.shielded = false;
            music.Stop();
            combatTimer.Enabled = false;

            if (Form1.opponent.defeated == false)
            {
                Form1.player.health = 100;
                Form1.player.x = 600;
                Form1.player.y = 450;
                Form1.screenLetter = 4;
                Form1.screenNumber = 14;
            }

            Form f = this.FindForm();
            f.Controls.Remove(this);

            Screens.PlayScreen ns = new Screens.PlayScreen();
            ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
            f.Controls.Add(ns);

            ns.Focus();
        }

        /// <summary>
        /// Makes sure music runs continuously
        /// </summary>
        void MusicLoop()
        {
            musicCounter++;

            if (musicCounter > musicLoop)
            {
                music.Stop();
                music.Play();
                musicCounter = 0;
            }
        }
    }
}
