using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Five_Nights_At_Freddies
{
    internal class Freddie
    {
        Random random = new Random();
        
        public static int rand;
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
        public void move(int _location)
        {
            if (Game_screen.chika != 1 && Game_screen.bonny != 1)
            {
                if (_location == 1)
                {
                    if (rand == 1)
                    {
                        Game_screen.freddie = 2;
                        return;
                    }
                    else
                    {
                        rand = random.Next(1, 1000000);
                    }
                }
                else if (_location == 2)
                {
                    if (rand == 2)
                    {
                        Game_screen.freddie = 9;
                        return;
                    }
                    else
                    {
                        rand = random.Next(1, 100000);
                    }
                }
                else if (_location == 9)
                {
                    if (rand == 3)
                    {
                        Game_screen.freddie = 6;
                        return;
                    }
                    else
                    {
                        rand = random.Next(1, 100000);
                    }
                }
                else if (_location == 6)
                {
                    if (rand == 4)
                    {
                        Game_screen.freddie = 7;
                        return;
                    }
                    else
                    {
                        rand = random.Next(1, 100000);
                    }
                }
                else if (_location == 7)
                {
                    if (rand == 5)
                    {
                        Game_screen.freddie = 0;
                        return;
                    }
                    else
                    {
                        rand = random.Next(1, 100000);
                    }
                }
            }
        }
    }
}
