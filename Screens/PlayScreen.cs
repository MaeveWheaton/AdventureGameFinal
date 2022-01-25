﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AdventureGameFinal.Screens
{
    public partial class PlayScreen : UserControl
    {
        #region Global variables
        Boolean upArrowDown, downArrowDown, rightArrowDown, leftArrowDown, spaceDown;
        int previousX, previousY;

        string[] screenLetters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K" };
        int screenLetter = Form1.screenLetter;
        int screenNumber = Form1.screenNumber;
        string currentScreen;

        string conversation = "intro";
        int conversationIndex = 0;

        Point[] points = new Point[] { //path on 15E
            new Point(0, 200),
            new Point(600, 700),
            new Point(425, 700),
            new Point(0, 350) };
        Point[] points2 = new Point[] { //path on 16E
            new Point(600, 0),
            new Point(1200, 275),
            new Point(1200, 375),
            new Point(425, 0) };
        Point[] points3 = new Point[] { //shoreline on 17G
            new Point(0, 400),
            new Point(100, 600),
            new Point(0, 600)};

        List<Classes.ScreenObject> screenObjects = new List<Classes.ScreenObject>();
        System.Drawing.Bitmap[] images = { Properties.Resources.greentree, Properties.Resources.smallHouse, Properties.Resources.stall};
        int newX, newY, newWidth, newLength, newImage;

        SolidBrush pathBrush = new SolidBrush(Color.Beige);
        SolidBrush waterBrush = new SolidBrush(Color.DeepSkyBlue);
        #endregion

        public PlayScreen()
        {
            InitializeComponent();
        }

        private void PlayScreen_Load(object sender, EventArgs e)
        {
            //start game timer
            //convoTimer.Enabled = true;
            LoadScreen();
            gameTimer.Enabled = true;
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
            previousX = Form1.player.x;
            previousY = Form1.player.y;

            #region player movement
            //move at key press
            if (upArrowDown)
            {
                Form1.player.Move("up");
                upArrowDown = false;
            }
            if (downArrowDown)
            {
                Form1.player.Move("down");
                downArrowDown = false;
            }
            if (rightArrowDown)
            {
                Form1.player.Move("right");
                rightArrowDown = false;
            }
            if (leftArrowDown)
            {
                Form1.player.Move("left");
                leftArrowDown = false;
            }
            #endregion

            foreach(Classes.ScreenObject so in screenObjects)
            {
                if(Form1.player.x + 28 > so.x && Form1.player.x < so.x + so.width 
                    && Form1.player.y + 40 > so.y && Form1.player.y < so.y + so.length - 40)
                {
                    Form1.player.x = previousX;
                    Form1.player.y = previousY;
                }
            }

            #region screen change
            //check for change of screen
            if (Form1.player.x < 0)
            {
                screenLetter--;
                Form1.player.x = 1200 + Form1.player.x;
                LoadScreen();
            }
            else if (Form1.player.x > 1200)
            {
                screenLetter++;
                Form1.player.x = 0 + (Form1.player.x - 1200);
                LoadScreen();
            }
            else if (Form1.player.y < 0)
            {
                screenNumber--;
                Form1.player.y = 700 + Form1.player.y;
                LoadScreen();
            }
            else if (Form1.player.y > 700)
            {
                screenNumber++;
                Form1.player.y = 0 + (Form1.player.y - 700);
                LoadScreen();
            }
            #endregion

            Refresh();
        }

        private void PlayScreen_Paint(object sender, PaintEventArgs e)
        {            
            //draw polygon/rectangle screen objects - easier to just draw since I don't have good pictures
            #region current screen switch
            switch (currentScreen)
            {
                case "14E": //start cabin
                    //loaded
                    break;
                case "15E":
                    //path
                    e.Graphics.FillPolygon(pathBrush, points);
                    break;
                case "16E":
                    //path
                    e.Graphics.FillPolygon(pathBrush, points2);
                    break;
                case "16F": //market
                    #region 16F
                    //paths
                    e.Graphics.FillRectangle(pathBrush, 0, 275, 1200, 100); //main road
                    e.Graphics.FillRectangle(pathBrush, 620, 650, 75, 50); //middledown
                    e.Graphics.FillRectangle(pathBrush, 400, 50, 700, 600); //market

                    //buildings
                    //0 - inn
                    //1 - stable

                    //stalls
                    e.Graphics.DrawImage(Properties.Resources.stall, 470, 60, 86, 88); //clothes
                    e.Graphics.DrawImage(Properties.Resources.stall, 670, 60, 86, 88); //food
                    e.Graphics.DrawImage(Properties.Resources.stall, 870, 60, 86, 88); //armoury
                    #endregion
                    break;
                case "17F": //harbour
                    #region 17F
                    //water
                    e.Graphics.FillRectangle(waterBrush, 0, 400, 1200, 300); //water

                    //paths
                    e.Graphics.FillRectangle(pathBrush, 20, 214, 1180, 50); //houses path
                    e.Graphics.FillRectangle(pathBrush, 620, 0, 75, 400); //middle up

                    //harbour
                    e.Graphics.FillRectangle(new SolidBrush(Color.SaddleBrown), 620, 400, 75, 200);

                    //boat
                    e.Graphics.DrawImage(Properties.Resources.boat, 500, 420, 115, 261);

                    //buildings
                    for (int i = 0; i <= 400; i += 200) //top right
                    {
                        e.Graphics.DrawImage(Properties.Resources.smallHouse, 20 + i, 50, 96, 144);
                    }
                    e.Graphics.DrawImage(Properties.Resources.smallHouse, 820, 50, 96, 144);
                    #endregion
                    break;
                case "16G": //big house
                    #region 16G
                    //paths
                    e.Graphics.FillRectangle(pathBrush, 0, 275, 620, 100); //main
                    e.Graphics.FillRectangle(pathBrush, 620, 275, 75, 425); //middle up

                    //buildings
                    for (int i = 0; i < 600; i += 125) //top right
                    {
                        e.Graphics.DrawImage(Properties.Resources.smallHouse, 20 + i, 125, 96, 144);
                    }
                    e.Graphics.DrawImage(Properties.Resources.smallHouse, 700, 50, 384, 576);
                    #endregion
                    break;
                case "17G": //houses
                    #region 17G
                    //water
                    e.Graphics.FillPolygon(waterBrush, points3);
                    e.Graphics.FillRectangle(waterBrush, 0, 600, 1200, 100);

                    //paths
                    e.Graphics.FillRectangle(pathBrush, 0, 214, 1180, 50); //middle
                    e.Graphics.FillRectangle(pathBrush, 100, 455, 1020, 50); //bottom
                    e.Graphics.FillRectangle(pathBrush, 620, 0, 75, 500); //middle up

                    //buildings
                    for (int i = 0; i < 600; i += 125) //top right
                    {
                        e.Graphics.DrawImage(Properties.Resources.smallHouse, 20 + i, 50, 96, 144);
                    }

                    for (int i = 0; i < 540; i += 135) //botton right
                    {
                        e.Graphics.DrawImage(Properties.Resources.smallHouse, 100 + i, 275, 96, 144);
                    }

                    for (int i = 0; i < 400; i += 125) //top left
                    {
                        e.Graphics.DrawImage(Properties.Resources.smallHouse, 720 + i, 50, 96, 144);
                    }

                    for (int i = 0; i < 400; i += 135) //botton left
                    {
                        e.Graphics.DrawImage(Properties.Resources.smallHouse, 720 + i, 275, 96, 144);
                    }
                    #endregion
                    break;
            }
            #endregion

            //draw image screen objects
            foreach (Classes.ScreenObject so in screenObjects)
            {
                e.Graphics.DrawImage(so.image, so.x, so.y, so.width, so.length);
            }

            e.Graphics.DrawImage(Form1.player.image, Form1.player.x, Form1.player.y, 28, 40);
        }

        void LoadScreen()
        {
            screenObjects.Clear();

            currentScreen = screenNumber + screenLetters[screenLetter];
            XmlReader reader = XmlReader.Create("GameData.xml");

            reader.ReadToFollowing("screen" + currentScreen);

            while (reader.Read())
            {
                if(reader.NodeType == XmlNodeType.Text)
                {
                    newImage = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("x");
                    newX = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("y");
                    newY = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("width");
                    newWidth = Convert.ToInt32(reader.ReadString());

                    reader.ReadToNextSibling("length");
                    newLength = Convert.ToInt32(reader.ReadString());

                    Classes.ScreenObject so = new Classes.ScreenObject(images[newImage], newX, newY, newWidth, newLength);
                    screenObjects.Add(so);
                }

                //loading all objects, how do I make it stop??
                //if (reader.)
                //{
                //    break;
                //}
            }
        }
    }
}
