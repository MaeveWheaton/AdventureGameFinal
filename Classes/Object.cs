using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameFinal.Classes
{
    public class Object
    {
        public string name, image;
    }

    public class Weapon : Object
    {
        public int strength;

        public Weapon()
        {

        }

        public Weapon(string _name, int _strength, string _image)
        {
            name = _name;
            strength = _strength;
            image = _image;
        }
    }

    public class Item : Object
    {
        public int hpGain;
        public System.Drawing.Bitmap image;

        public Item(int _hpGain, System.Drawing.Bitmap _image)
        {
            hpGain = _hpGain;
            image = _image;
        }
    }
}
