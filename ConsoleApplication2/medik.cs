using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Hiller:H
    {
        public int hp, dmg;
        public Hiller()
        {
            base.hp = 30;
            base.dmg = 20;
            base.clss = "Hiller";
        }
        static public void hil(H poc1,H poc2)
        {
            Random rnd = new Random();
            poc1.hp += rnd.Next(1, 20);
            poc2.hp += rnd.Next(1, 20);
        }
    }
}
