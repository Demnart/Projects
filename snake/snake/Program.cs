using System;
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
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sim = '#';
            p1.Draw(p1.x , p1.y , p1.sim);

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 7;
            p2.sim = '&';
            p2.Draw(p2.x, p2.y, p2.sim);

            Console.ReadLine();
        }
        

        }
    }

