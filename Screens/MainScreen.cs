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
using System.Xml;

namespace AdventureGameFinal
{
    public partial class MainScreen : UserControl
    {
        #region Global variables
        Boolean upArrowDown, downArrowDown, spaceDown;
        int selectionState = 0;

        //music variables
        System.Windows.Media.MediaPlayer music;
        System.Windows.Media.MediaPlayer selectionChangeBeep;
        System.Windows.Media.MediaPlayer selectionCompletedSound;
        int musicCounter = 10000;
        int musicLoop = 3500;
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

            music = new System.Windows.Media.MediaPlayer();
            music.Open(new Uri(Application.StartupPath + "/Resources/background_music.mp3"));
            selectionChangeBeep = new System.Windows.Media.MediaPlayer();
            selectionChangeBeep.Open(new Uri(Application.StartupPath + "/Resources/menu_beep.mp3"));
            selectionCompletedSound = new System.Windows.Media.MediaPlayer();
            selectionCompletedSound.Open(new Uri(Application.StartupPath + "/Resources/select_granted.mp3"));
        }

        private void mainScreenTimer_Tick(object sender, EventArgs e)
        {
            //switch selected button if down/up pressed,
            //change to corresponding screen if space pressed
            switch (selectionState)
            {
                case 0: //start selected
                    #region Case 0
                    if (downArrowDown) //change to load selected
                    {
                        //change selection and visuals
                        selectionState = 1;
                        loadLabel.BorderStyle = BorderStyle.Fixed3D;
                        startLabel.BorderStyle = BorderStyle.None;

                        //play sound
                        selectionChangeBeep.Play();

                        downArrowDown = false;
                    }
                    if (spaceDown) //change to customization screen
                    {
                        //play sound
                        selectionCompletedSound.Play();
                        music.Stop();

                        //stop timer
                        mainScreenTimer.Enabled = false;
                        Form1.loaded = false;

                        //change to customization screen
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
                case 1: //load selected
                    #region Case 1
                    if (upArrowDown) //change to start selected
                    {
                        //change selection and visuals
                        selectionState = 0;
                        startLabel.BorderStyle = BorderStyle.Fixed3D;
                        loadLabel.BorderStyle = BorderStyle.None;

                        //play sound
                        selectionChangeBeep.Play();

                        upArrowDown = false;
                    }
                    if (downArrowDown) //change to how to selected
                    {
                        //change selection and visuals
                        selectionState = 2;
                        howToLabel.BorderStyle = BorderStyle.Fixed3D;
                        loadLabel.BorderStyle = BorderStyle.None;

                        //play sound
                        selectionChangeBeep.Play();

                        downArrowDown = false;
                    }
                    if (spaceDown) //change to play screen
                    {
                        //play sound
                        selectionCompletedSound.Play();
                        music.Stop();

                        //stop timer
                        mainScreenTimer.Enabled = false;
                        Form1.loaded = true;

                        //load data
                        LoadPlayerData();

                        //change to play screen
                        Form f = this.FindForm();
                        f.Controls.Remove(this);

                        Screens.PlayScreen ns = new Screens.PlayScreen();
                        ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                        f.Controls.Add(ns);

                        spaceDown = false;

                        ns.Focus();
                    }
                    #endregion
                    break;
                case 2: //how to selected
                    #region Case 2
                    if (upArrowDown) //change to load selected
                    {
                        //change selection and visuals
                        selectionState = 1;
                        loadLabel.BorderStyle = BorderStyle.Fixed3D;
                        howToLabel.BorderStyle = BorderStyle.None;

                        //play sound
                        selectionChangeBeep.Play();

                        upArrowDown = false;
                    }
                    if (downArrowDown) //change to exit selected
                    {
                        //change selection and visuals
                        selectionState = 3;
                        exitLabel.BorderStyle = BorderStyle.Fixed3D;
                        howToLabel.BorderStyle = BorderStyle.None;

                        //play sound
                        selectionChangeBeep.Play();

                        downArrowDown = false;
                    }
                    if (spaceDown) //change to instuction screen
                    {
                        //play sound
                        selectionCompletedSound.Play();
                        music.Stop();

                        //stop timer
                        mainScreenTimer.Enabled = false;
                        
                        //change to instruction screen
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
                case 3: //exit selected
                    #region Case 3
                    if (upArrowDown) //change to how to selected
                    {
                        //change selection and visuals
                        selectionState = 2;
                        howToLabel.BorderStyle = BorderStyle.Fixed3D;
                        exitLabel.BorderStyle = BorderStyle.None;

                        //play sound
                        selectionChangeBeep.Play();

                        upArrowDown = false;
                    }
                    if (spaceDown) //close application
                    {
                        music.Stop();
                        Application.Exit();
                    }
                    #endregion
                    break;
            }

            MusicLoop();

            Refresh();
        }

        /// <summary>
        /// Loads saved player data
        /// </summary>
        void LoadPlayerData()
        {
            XmlReader reader = XmlReader.Create("PlayerData.xml");

            while (reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Text)
                {
                    Form1.player.x = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("y");
                    Form1.player.y = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("weaponType");
                    Form1.player.weaponType = reader.ReadString();

                    reader.ReadToNextSibling("weapon");
                    Form1.player.weapon = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("screenLetter");
                    Form1.screenLetter = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("screenNumber");
                    Form1.screenNumber = Convert.ToInt32(reader.ReadString());

                    reader.ReadToFollowing("bartholomewI");
                    reader.ReadToFollowing("convoValue");
                    Form1.bartholomewI.convoValue = Convert.ToInt32(reader.ReadString());

                    reader.ReadToFollowing("health");
                    Form1.dummy.health = Convert.ToInt32(reader.ReadString());

                    reader.ReadToFollowing("defeated");
                    Form1.dummy.defeated = Convert.ToBoolean(reader.ReadString());
                }
            }

            reader.Close();

            switch (Form1.player.weaponType)
            {
                case "sword":
                    Form1.player.weaponList = Form1.swords;
                    break;
                case "polearm":
                    Form1.player.weaponList = Form1.polearms;
                    break;
                case "bow":
                    Form1.player.weaponList = Form1.bows;
                    break;
                case "daggers":
                    Form1.player.weaponList = Form1.daggers;
                    break;
                case "catalyst":
                    Form1.player.weaponList = Form1.catalysts;
                    break;
            }

            Form1.playerWeapon = Form1.player.weaponList[Form1.player.weapon];
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
