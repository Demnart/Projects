using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine
    {
        List<Point> lpoint;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {

            lpoint = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                lpoint.Add(p);
            }
        

        }

            public void Draw() {

            foreach (Point p in lpoint) {
                p.Drow();
            }
        }


        }
    }

