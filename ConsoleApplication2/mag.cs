using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Mag : H
    {
        public Mag ()
        {
            base.hp = 200;
            base.dmg = 10;
            base.clss = "Mag";
        }
        
        public static void kold(H poc1, H poc2,int hd)
        {
            if (hd % 5 ==0)
            {
                hd = 0;
                poc1.dmg += 10;
                poc2.dmg += 10;
            }
            else
            {
                if (hd % 5==1)
                {
                    if (hd == 1)
                    { }
                    else
                    {
                        poc1.dmg -= 10;
                        poc2.dmg -= 10;
                    }
                }
            }
                hd++;
        }
    }
}
