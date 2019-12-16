using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Fonster
    {
        int höjd;
        int bredd;
        
        public Fonster(int b, int h)
        {
            höjd = h;
            bredd = b;
        }

        public int Höjd
        {
            set { höjd = value; }
            get { return höjd; }
        }
        public int Bredd
        {
            set { bredd = value; }
            get { return bredd; }
        }
    }
}
