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
    public partial class InstructionScreen : UserControl
    {
        public InstructionScreen()
        {
            InitializeComponent();
        }            

        private void InstructionScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Space):
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    MainScreen ns = new MainScreen();
                    ns.Location = new Point((f.Width - ns.Width) / 2, (f.Height - ns.Height) / 2);
                    f.Controls.Add(ns);

                    ns.Focus();
                    break;
            }
        }
    }
}
