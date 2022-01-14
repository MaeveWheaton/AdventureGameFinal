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
        public static Classes.Weapon playerWeapon = new Classes.Weapon();
        public static Classes.NPC bear = new Classes.NPC(800, 400, 100, Form1.swords, "opponent", "bear_monster");
        public static List<Classes.Weapon> swords = new List<Classes.Weapon>();
        public static List<Classes.Weapon> polearms = new List<Classes.Weapon>();
        public static List<Classes.Weapon> bows = new List<Classes.Weapon>();
        public static List<Classes.Weapon> daggers = new List<Classes.Weapon>();
        public static List<Classes.Weapon> catalysts = new List<Classes.Weapon>();
        public static Classes.Player player = new Classes.Player(600, 350, 5, 100, 0, Form1.swords, 0, false, "playerTest");
        string newName, newImage;
        int newStrength;
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            LoadGameData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Main Screen
            //MainScreen ns = new MainScreen();
            //Screens.PlayScreen ns = new Screens.PlayScreen();
            Screens.CombatScreen ns = new Screens.CombatScreen();
            this.Controls.Add(ns);

            ns.Location = new Point((this.Width - ns.Width) / 2, (this.Height - ns.Height) / 2);

            ns.Focus();
        }

        void LoadGameData()
        {
            XmlReader reader = XmlReader.Create("GameData.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    LoadWeapons(reader, swords, 2);

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, polearms, 1);

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, bows, 1);

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, daggers, 1);

                    reader.ReadToFollowing("name");

                    LoadWeapons(reader, catalysts, 2);

                    break;
                    
                }
            }

            player.weaponType = swords;
            playerWeapon = player.weaponType[player.weapon];
        }

        void LoadWeapons(XmlReader reader, List<Classes.Weapon> weapons, int length)
        {
            for (int i = 0; i < length; i++)
            {
                newName = reader.ReadString();

                reader.ReadToNextSibling("strength");
                newStrength = Convert.ToInt32(reader.ReadString());

                reader.ReadToNextSibling("image");
                newImage = reader.ReadString();

                Classes.Weapon w = new Classes.Weapon(newName, newStrength, newImage);
                weapons.Add(w);

                reader.ReadToNextSibling("name");
            }
        }
    }
}
