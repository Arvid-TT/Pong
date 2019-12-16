using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Boll
    {
        Rectangle rek;
        int x;
        int y;
        public Boll(Rectangle r)
        {
            rek = r;
            x = 0;
            y = 0;
        }
        public Rectangle Rek
        {
            set { rek = value; }
            get { return rek; }
        }
        public int X
        {
            set { x = value; }
            get { return x; }

        }
        public int Y
        {
            set { y = value; }
            get { return y; }
        }
    }
}
