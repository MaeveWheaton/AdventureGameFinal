using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace AdventureGameFinal.Classes
{
    class ScreenObject
    {
        public int x, y, width, length;
        public System.Drawing.Bitmap image;

        public ScreenObject(System.Drawing.Bitmap _image, int _x, int _y, int _width, int _length) 
        {
            image = _image;
            x = _x;
            y = _y;
            width = _width;
            length = _length;
        }
    }
}
