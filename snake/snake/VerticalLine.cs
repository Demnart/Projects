using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        List<Point> lpoint;

        public VerticalLine(int x, int yHight, int yBoth, char sym) {

            lpoint = new List<Point>();
            for (int y = yHight; y <= yBoth; y++)
            {
                Point p = new Point(x, y, sym);
                lpoint.Add(p);
            }


        }
        
        public void Draw()
        {

            foreach (Point p in lpoint)
            {
                p.Drow();
            }
        }


    }
}

