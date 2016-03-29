using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine : Figure
    {
     
        public VerticalLine(int yHight, int yBoth, int x , char sym) {

            lpoint = new List<Point>();
            for (int y = yHight; y <= yBoth; y++)
            {
                Point p = new Point(x, y, sym);
                lpoint.Add(p);
            }


        }
        
      


    }
}

