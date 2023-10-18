﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    internal class Menu
    {
        private int minp;
        private int maxp;

        public Menu(int min, int max)
        {
            minp = min;
            maxp = max;
        }

        public int Show()
        {
            int pos = minp;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.DownArrow && pos != maxp)
                    pos++;
                else if (key.Key == ConsoleKey.UpArrow && pos != minp)
                    pos--;
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}
