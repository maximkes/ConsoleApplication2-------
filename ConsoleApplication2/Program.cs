using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<H> team1= new List<H>();
            List<H> team2= new List<H>();
            Hvy var1 = new Hvy();
            Hvy var10 = new Hvy();
            Hvy var100 = new Hvy();
            Hvy var1000 = new Hvy();
            Hvy var10000 = new Hvy();
            Hvy var100000 = new Hvy();
            Hiller var2 = new Hiller();
            Hiller var20 = new Hiller();
            Hiller var200 = new Hiller();
            Hiller var2000 = new Hiller();
            Hiller var20000 = new Hiller();
            Hiller var200000 = new Hiller();
            Sln var3 = new Sln();
            Sln var30 = new Sln();
            Sln var300 = new Sln();
            Sln var3000 = new Sln();
            Sln var30000 = new Sln();
            Sln var300000 = new Sln();
            Smertnic var4 = new Smertnic();
            Smertnic var40 = new Smertnic();
            Smertnic var400 = new Smertnic();
            Smertnic var4000 = new Smertnic();
            Smertnic var40000 = new Smertnic();
            Smertnic var400000 = new Smertnic();
            Mag var5 = new Mag();
            Mag var50 = new Mag();
            Mag var500 = new Mag();
            Mag var5000 = new Mag();
            Mag var50000 = new Mag();
            Mag var500000 = new Mag();
            int clss;
            clss = int.Parse(Console.ReadLine());
            switch(clss)
            {
                case(1):
                    team1.Add(var1);
                    break;
                case(2):
                    team1.Add(var2);
                    break;
                case(3):
                    team1.Add(var3);
                    break;
                case(4):
                    team1.Add(var4);
                    break;
                case (5):
                    team1.Add(var5);
                    break;
                default:
                    team1.Add(var1);
                    break;
            }
            clss = int.Parse(Console.ReadLine());
            switch(clss)
            {
                case(1):
                    team1.Add(var10);
                    break;
                case(2):
                    team1.Add(var20);
                    break;
                case(3):
                    team1.Add(var30);
                    break;
                case(4):
                    team1.Add(var40);
                    break;
                case(5):
                    team1.Add(var50);
                    break;
                default:
                    team1.Add(var10);
                    break;
            }
            clss = int.Parse(Console.ReadLine());
            switch(clss)
            {
                case(1):
                    team1.Add(var100);
                    break;
                case(2):
                    team1.Add(var200);
                    break;
                case(3):
                    team1.Add(var300);
                    break;
                case(4):
                    team1.Add(var400);
                    break;
                case (5):
                    team1.Add(var500);
                    break;
                default:
                    team1.Add(var100);
                    break;
            }
            
            clss = int.Parse(Console.ReadLine());
            switch(clss)
            {
                case(1):
                    team2.Add(var1000);
                    break;
                case(2):
                    team2.Add(var2000);
                    break;
                case(3):
                    team2.Add(var3000);
                    break;
                case(4):
                    team2.Add(var4000);
                    break;
                case (5):
                    team2.Add(var5000);
                    break;
                default:
                    team2.Add(var1000);
                    break;
            }
            clss = int.Parse(Console.ReadLine());
            switch(clss)
            {
                case(1):
                    team2.Add(var10000);
                    break;
                case(2):
                    team2.Add(var20000);
                    break;
                case(3):
                    team2.Add(var30000);
                    break;
                case(4):
                    team2.Add(var40000);
                    break;
                case (5):
                    team2.Add(var50000);
                    break;
                default:
                    team2.Add(var10000);
                    break;
            }
            clss = int.Parse(Console.ReadLine());
            switch(clss)
            {
                case(1):
                    team2.Add(var100000);
                    break;
                case(2):
                    team2.Add(var200000);
                    break;
                case(3):
                    team2.Add(var300000);
                    break;
                case(4):
                    team2.Add(var400000);
                    break;
                case (5):
                    team2.Add(var500000);
                    break;
                default:
                    team2.Add(var100000);
                    break;
            }
            while(true)
            {
                hd(team1[0], team2[0]);
                hd(team1[1], team2[1]);
                hd(team1[2], team2[2]);
            }
            }
        static public void hd(H a, H b)
        {

        }
        }
    }

