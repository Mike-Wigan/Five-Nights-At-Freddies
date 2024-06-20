using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Five_Nights_At_Freddies
{
    internal class Bonny
    {
        int rand;
        Random random = new Random();

        Stopwatch stopwatch = new Stopwatch();

        int time;
        public Bonny()
        {
            // 1 = 1A
            // 2 = 1B
            // 3 = 1C
            // 4 = 2B
            // 5 = 3
            // 6 = 4a
            // 7 = 4B
            // 8 = 5
            // 9 = 7
            // 10 = 2A
        }
        public void move(int _location)
        {
            if (_location == 1)
            {
                if (rand == 1)
                {
                    Game_screen.bonny = 2;
                    return;
                }
                else
                {
                    rand = random.Next(1, 100);
                }
            }
            else if (_location == 2)
            {
                if (rand == 2)
                {
                    Game_screen.bonny = 5;
                    return;
                }
                else if (rand == 3)
                {
                    Game_screen.bonny = 8;
                    return;
                }
                else
                {
                    rand = random.Next(1, 100);
                }
            }
            else if (_location == 5)
            {
                if (rand == 4)
                {
                    Game_screen.bonny = 10;
                    return;
                }
                else
                {
                    rand = random.Next(1, 100);
                }
            }
            else if (_location == 8)
            {
                if (rand == 10)
                {
                    Game_screen.bonny = 5;
                    return;
                }
                else if (rand == 11)
                {
                    Game_screen.bonny = 10;
                    return;
                }
                else
                {
                    rand = random.Next(1, 100);
                }
            }
            else if (_location == 10)
            {
                if (rand == 5)
                {
                    Game_screen.bonny = 5;
                    return;
                }
                else if (rand == 6)
                {
                    Game_screen.bonny = 8;
                    return;
                }
                else if (rand == 7)
                {
                    Game_screen.bonny = 4;
                    return;
                }
                else
                {
                    rand = random.Next(1, 100);
                }
            }
            else if (_location == 5)
            {
                if (rand == 8)
                {
                    Game_screen.bonny = 4;
                    return;
                }
                else
                {
                    rand = random.Next(1, 100);
                }
            }
            else if (_location == 4)
            {
                if (rand == 9)
                {
                    Game_screen.bonny = 0;
                    return;
                }
                else
                {
                    rand = random.Next(1, 100);
                }
            }
        }
    }
}
