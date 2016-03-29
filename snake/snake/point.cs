﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        private int x;
        private int y;
        private char simb;

        public Point() { }
        public Point(int x, int y, char simb)
        {
            this.x = x;
            this.y = y;
            this.simb = simb;
        }

        public  void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }
    }
}
