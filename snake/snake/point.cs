using System;
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

        public Point(Point p) {
            x = p.x;
            y = p.y;
            simb = p.simb;


        }

        public void Move(int offset, Direction direction) {

            if (direction == Direction.Right)
            {
                x = x + offset;
            }

            else if (direction == Direction.Left)
            {
                x = x - offset;

            }

            else if (direction == Direction.Up)
            {
                y = y - offset;
            }
            else if (direction == Direction.Down)
            {
                y = y + offset;
            }
        }


        public  void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }

        public void Clear()
        {
            simb = ' ';
            Drow();
        }

        public override string ToString()
        {
            return x + "," + y + "," + simb;
        }
     
    }
}
