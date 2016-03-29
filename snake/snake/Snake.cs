using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int lengh, Direction _direction) {
            direction = _direction;
            lpoint = new List<Point>();
            for (int i = 0; i < lengh; i++) {
                Point p = new Point(tail);
                p.Move(i, direction);
                lpoint.Add(p);

            }
        }

        internal void Move()
        {
            Point tail = lpoint.First();
            lpoint.Remove(tail);
            Point head = GetNextPoint();
            lpoint.Add(head);

            tail.Clear();
            head.Drow();
        }
        public Point GetNextPoint() {
            Point head = lpoint.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}