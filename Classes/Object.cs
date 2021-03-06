using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameFinal.Classes
{
    public class Object
    {
        public string name, image, type;
    }

    public class Weapon : Object
    {
        public int strength;

        public Weapon(int _strength)
        {
            //for dummy and blank player weapon
            strength = _strength;
        }

        public Weapon(string _name, string _type, int _strength, string _image)
        {
            type = _type;
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
