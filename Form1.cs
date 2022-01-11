﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGameFinal
{
    public partial class Form1 : Form
    {
        #region Global variables
        public static Classes.Character player = new Classes.Player(1100, 350, 5, 100, 0, "TBD", false);
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start the program centred on the Main Screen
            MainScreen ns = new MainScreen();
            this.Controls.Add(ns);

            ns.Location = new Point((this.Width - ns.Width) / 2, (this.Height - ns.Height) / 2);

            ns.Focus();
        }
    }
}
