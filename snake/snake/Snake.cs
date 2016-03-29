using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int lengh, Direction direction) {
            lpoint = new List<Point>();
            for (int i = 0; i < lengh; i++) {
                Point p = new Point(tail);
                p.Move(i, direction);
                lpoint.Add(p);

            }
        }
    }
}
