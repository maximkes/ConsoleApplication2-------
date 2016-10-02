using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Mag : H
    {
        int hd = 0;
        public bool allive;
        public Mag ()
        {
            base.hp = 200;
            base.dmg = 10;
        }
        public void kold(H poc1, H poc2)
        {
            if (hd == 5)
            {
                hd = 0;
                poc1.dmg += 10;
                poc2.dmg += 10;
            }
            else
            {
                hd++;
            }
        }
    }
}
