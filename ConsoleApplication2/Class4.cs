using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Smertnic : H
    {
        public bool allive;
        public Smertnic()
        {
            base.hp = 1;
            base.dmg = 500;
        }
    }
}

