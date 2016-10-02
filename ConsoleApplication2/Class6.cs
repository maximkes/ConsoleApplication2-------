using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Hiller:H
    {

        public int hp, dmg;
        public override void Attack(H h1, H h2)
        {
            Random rnd = new Random();
            h2.hp -= rnd.Next(0, h2.hp);
        }
        public void hil(H poc1,H poc2)
        {
            Random rnd = new Random();
            poc1.hp += rnd.Next(1, 20);
            poc2.hp += rnd.Next(1, 20);
        }
    }
}
