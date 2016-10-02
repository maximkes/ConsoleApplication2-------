using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    public class H
    {
        public int hp, dmg;
        public override void Attack(H h1, H h2)
        {
            int n;
            Random rnd = new Random();
            n = h2.hp - rnd.Next(0, h2.hp);
            if (n < 0) h2.hp = 0;
            else h2.hp = n;
        }
    }
}
