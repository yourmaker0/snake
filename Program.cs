﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym = '#';
            Draw(x1, y1, sym);

            int x2 = 4;
            int y2 = 5;
            Draw(x2,y2,'@');
            Draw(7,3,'#');
            Console.ReadLine();
        }

        static void Draw(int x, int y,char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);

        }
    }
}
