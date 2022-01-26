/*
 * Maeve Wheaton
 * Mr.T
 * January 26th, 2022
 * Misaploya Adventure
 * A single player adventure game where the player get to travel the land of Misaploya to take on various quests. 
 * In the beginning the player is able to choose their starting weapon and when first playing the game an introduction to how to play is given.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AdventureGameFinal
{
    public partial class Form1 : Form
    {
        #region Global variables
        //NPCs
        public static Classes.NPC bear = new Classes.NPC(800, 400, 100, "swords", Form1.swords, "opponent", false, Properties.Resources.bear_monster);
        public static Classes.NPC dummy = new Classes.NPC(300, 370, 100, "none", Form1.empty, "opponent", false, Properties.Resources.trainingdummy);
        public static Classes.NPC bartholomewI = new Classes.NPC(650, 458, "noncombatant", 0, Properties.Resources.oldmanred1);
        public static Classes.NPC opponent = new Classes.NPC();


        //Empty weapon lists and image array
        public static List<Classes.Weapon> empty = new List<Classes.Weapon>();
        public static List<Classes.Weapon> swords = new List<Classes.Weapon>();
        public static List<Classes.Weapon> polearms = new List<Classes.Weapon>();
        public static List<Classes.Weapon> bows = new List<Classes.Weapon>();
        public static List<Classes.Weapon> daggers = new List<Classes.Weapon>();
        public static List<Classes.Weapon> catalysts = new List<Classes.Weapon>();
        System.Drawing.Bitmap[] weaponImages = { Properties.Resources.sword2 };

        //Base player info
        public static Classes.Player player = new Classes.Player(600, 450, 10, 100, 0, "", empty, 0, false, Properties.Resources.playerTest);
        public static Classes.Weapon playerWeapon = new Classes.Weapon();
        public static List<Classes.Item> playerItems = new List<Classes.Item>();

        //Screen values
        public static int screenLetter = 4;
        public static int screenNumber = 14;

        //Weapon loading variables
        string newName, newImage;
        int newStrength;

        //Tracks whether data was loaded or created new
        public static bool loaded = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
            LoadGameData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Main Screen
            MainScreen ns = new MainScreen();
            //Screens.PlayScreen ns = new Screens.PlayScreen();
            this.Controls.Add(ns);

            ns.Location = new Point((this.Width - ns.Width) / 2, (this.Height - ns.Height) / 2);

            ns.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePlayerData();
        }

        /// <summary>
        /// Loads weapon lists
        /// </summary>
        void LoadGameData()
        {
            XmlReader reader = XmlReader.Create("GameData.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    LoadWeapons(reader, swords, 2, "sword");

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, polearms, 1, "polearm");

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, bows, 1, "bow");

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, daggers, 1, "daggers");

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, catalysts, 2, "catalyst");

                    break;

                }
            }

            reader.Close();

            empty.Add(new Classes.Weapon());
            player.weaponList = empty;
            playerWeapon = player.weaponList[player.weapon];
        }

        /// <summary>
        /// Loads a set of weapons
        /// </summary>
        /// <param name="reader">reader</param>
        /// <param name="weapons">weapon list to load</param>
        /// <param name="length">number of weapons to be loaded</param>
        /// <param name="type">type of weapon</param>
        void LoadWeapons(XmlReader reader, List<Classes.Weapon> weapons, int length, string type)
        {
            for (int i = 0; i < length; i++)
            {
                newName = reader.ReadString();

                reader.ReadToNextSibling("strength");
                newStrength = Convert.ToInt32(reader.ReadString());

                reader.ReadToNextSibling("image");
                newImage = reader.ReadString();

                Classes.Weapon w = new Classes.Weapon(newName, type, newStrength, newImage);
                weapons.Add(w);

                reader.ReadToNextSibling("name");
            }
        }

        /// <summary>
        /// Saves player data
        /// </summary>
        void SavePlayerData()
        {
            //Open the XML file and place it in writer
            XmlWriter writer = XmlWriter.Create("PlayerData.xml");

            //Write the root element
            writer.WriteStartElement("Players");

            //Write player1 element
            writer.WriteStartElement("Player1");

            //int _x, int _y, int _speed, int _health, int _money, List<Weapon> _weaponType, int _weapon, bool _shielded, string _image
            //Write sub-elements
            writer.WriteElementString("x", Convert.ToString(player.x));
            writer.WriteElementString("y", Convert.ToString(player.y));
            writer.WriteElementString("health", Convert.ToString(player.health));
            writer.WriteElementString("weaponType", Convert.ToString(player.weaponType));
            writer.WriteElementString("weapon", Convert.ToString(player.weapon));
            writer.WriteElementString("screenLetter", Convert.ToString(screenLetter));
            writer.WriteElementString("screenNumber", Convert.ToString(screenNumber));

            // end player1 element
            writer.WriteEndElement();

            //write bartholomew I element
            writer.WriteStartElement("bartholomewI");

            //write defeated and health
            writer.WriteElementString("convoValue", Convert.ToString(bartholomewI.convoValue));

            //end dummy element
            writer.WriteEndElement();

            //write dummy element
            writer.WriteStartElement("Dummy");

            //write dummy health and defeated bool
            writer.WriteElementString("health", Convert.ToString(dummy.health));
            writer.WriteElementString("defeated", Convert.ToString(dummy.defeated));

            //end dummy element
            writer.WriteEndElement();

            // end the root element
            writer.WriteEndElement();

            //Write the XML to file and close the writer
            writer.Close();
        }
    }
}
