﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Figure
    {

       protected List<Point> lpoint;

        public void Draw()
        {

            foreach (Point p in lpoint)
            {
                p.Drow();
            }
        }
    }
}
