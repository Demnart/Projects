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
            Point p1 = new Point(4,6,'#');
            Point p2 = new Point(5,0,'^');

            HorizontalLine line = new HorizontalLine(0, 10, 0,'_');
            line.Draw();
            VerticalLine vline = new VerticalLine(0, 1, 10, '|');
            vline.Draw();
            Console.ReadLine();
        }
        

        }
    }

