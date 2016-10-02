using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static public List<H> team1 = new List<H>();
        static public List<H> team2 = new List<H>();
        static void Main(string[] args)
        {
            int hd1=0;
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
            switch (clss)
            {
                case (1):
                    team1.Add(var1);
                    break;
                case (2):
                    team1.Add(var2);
                    break;
                case (3):
                    team1.Add(var3);
                    break;
                case (4):
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
            switch (clss)
            {
                case (1):
                    team1.Add(var10);
                    break;
                case (2):
                    team1.Add(var20);
                    break;
                case (3):
                    team1.Add(var30);
                    break;
                case (4):
                    team1.Add(var40);
                    break;
                case (5):
                    team1.Add(var50);
                    break;
                default:
                    team1.Add(var10);
                    break;
            }
            clss = int.Parse(Console.ReadLine());
            switch (clss)
            {
                case (1):
                    team1.Add(var100);
                    break;
                case (2):
                    team1.Add(var200);
                    break;
                case (3):
                    team1.Add(var300);
                    break;
                case (4):
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
            switch (clss)
            {
                case (1):
                    team2.Add(var1000);
                    break;
                case (2):
                    team2.Add(var2000);
                    break;
                case (3):
                    team2.Add(var3000);
                    break;
                case (4):
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
            switch (clss)
            {
                case (1):
                    team2.Add(var10000);
                    break;
                case (2):
                    team2.Add(var20000);
                    break;
                case (3):
                    team2.Add(var30000);
                    break;
                case (4):
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
            switch (clss)
            {
                case (1):
                    team2.Add(var100000);
                    break;
                case (2):
                    team2.Add(var200000);
                    break;
                case (3):
                    team2.Add(var300000);
                    break;
                case (4):
                    team2.Add(var400000);
                    break;
                case (5):
                    team2.Add(var500000);
                    break;
                default:
                    team2.Add(var100000);
                    break;
            }
            bool match = false;
            bool match1 = false;
            while (!match&!match1)
            {
                Console.Clear();
                Console.WriteLine(team1[0].hp);
                Console.WriteLine(team1[1].hp);
                Console.WriteLine(team1[2].hp);
                Console.WriteLine(team2[0].hp);
                Console.WriteLine(team2[1].hp);
                Console.WriteLine(team2[2].hp);
                hd1++;
                hd(team1[0], team1[1], team1[2], hd1);
                hd(team1[1], team1[0], team1[2], hd1);
                hd(team1[2], team1[0], team1[1], hd1);
                hdv(team2[0], team2[1], team2[2], hd1);
                hdv(team2[1], team2[0], team2[2], hd1);
                hdv(team2[2], team2[0], team2[1],hd1);
                foreach (H w in team1)
            {
                match = match && (w.hp != 0);
            }
            foreach (H w in team2)
            {
                match1 = match1 && (w.hp != 0);
            }
            }
            
            if (match)
            {
                Console.WriteLine("YOU WIN!!!");
            }
            else
            {
                if (match1)
                {
                    Console.WriteLine("YOU LOSE!!!");
                }
                else
                {
                    Console.WriteLine("DRAW");
                }
            }
        }
        static public void hd(H a,H b,H c,int hd1)
        {
            int ta = 0,to=0;
            if(a.hp!=0)
            {
            ta = int.Parse(Console.ReadLine());
            switch (a.clss)
            {
                case "Hiller":
                    to = 1;
                    break;
                case "Mag":
                    to = 2;
                    break;
            }
            switch (to)
            {
                case (1):
                    Hiller.hil(b, c);
                    break;
                case(2):
                    Mag.kold(b, c, hd1);
                    break;
            }
            if (ta > 2) ta = 0;
                a.Attack(a,team2[ta]);
        }
        }
        static public void hdv(H a, H b, H c, int hd1)
        {
            int ta = 0, to = 0;
            if (a.hp != 0)
            {
                ta = int.Parse(Console.ReadLine());
                switch (a.clss)
                {
                    case "Hiller":
                        to = 1;
                        break;
                    case "Mag":
                        to = 2;
                        break;
                }
                switch (to)
                {
                    case (1):
                        Hiller.hil(b, c);
                        break;
                    case (2):
                        Mag.kold(b, c, hd1);
                        break;
                }
                a.Attack(a, team1[ta]);
            }
        }
    }
}

