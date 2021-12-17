using System;
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
        }
    }
}
