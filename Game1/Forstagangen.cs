using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Forstagangen
    {
        bool yaas;
        public Forstagangen()
        {
            bool y = true;
            yaas = y;

        }
        public bool Yaas
        {
            set { yaas = value; }
            get { return yaas; }
        }
    }
}
