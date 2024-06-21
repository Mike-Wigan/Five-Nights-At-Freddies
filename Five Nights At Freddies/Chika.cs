using System;

namespace Five_Nights_At_Freddies
{
    internal class Chika
    {
        Random random = new Random();
        public static int rand;
        public Chika()
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
                    Game_screen.chika = 2;
                    return;
                }
                else
                {
                    rand = random.Next(1, 500);
                }
            }
            else if (_location == 2)
            {
                if (rand == 2)
                {
                    Game_screen.chika = 9;
                    return;
                }
                else
                {
                    rand = random.Next(1, 500);
                }
            }
            else if (_location == 9)
            {
                if (rand == 3)
                {
                    Game_screen.chika = 11;
                    return;
                }
                else
                {
                    rand = random.Next(1, 500);
                }
            }
            else if (_location == 11)
            {
                if (rand == 4)
                {
                    Game_screen.chika = 6;
                    return;
                }
                else
                {
                    rand = random.Next(1, 500);
                }
            }
            else if (_location == 6)
            {
                if (rand == 5)
                {
                    Game_screen.chika = 7;
                    return;
                }
                else
                {
                    rand = random.Next(1, 500);
                }
            }
            else if (_location == 7)
            {
                if (rand == 6)
                {
                    Game_screen.chika = 0;
                    return;
                }
                else
                {
                    rand = random.Next(1, 500);
                }
            }

            else
            {
                rand = random.Next(1, 500);
            }
        }
    }
}
