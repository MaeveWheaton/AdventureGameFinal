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

namespace AdventureGameFinal.Screens
{
    public partial class InstructionScreen : UserControl
    {
        #region Global variables
        //music variables
        System.Windows.Media.MediaPlayer music;
        int musicCounter = 10000;
        int musicLoop = 2450;
        #endregion
        public InstructionScreen()
        {
            InitializeComponent();
        }

        private void InstructionScreen_Load(object sender, EventArgs e)
        {
            //open music file
            music = new System.Windows.Media.MediaPlayer();
            music.Open(new Uri(Application.StartupPath + "/Resources/soft_music.mp3"));
            music.Play();
        }

        private void InstructionScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Space):
                    //stop music
                    music.Stop();

                    //change to main screen
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    MainScreen ns = new MainScreen();
                    ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                    f.Controls.Add(ns);

                    ns.Focus();
                    break;
            }
        }

        private void howToTimer_Tick(object sender, EventArgs e)
        {
            //loop music
            MusicLoop();
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
