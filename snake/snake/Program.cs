﻿using System;
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
          

            List<char> charList = new List<char>();
            charList.Add('#');
            charList.Add('@');
            charList.Add('!');
            charList.Add('%');

            foreach (char i in charList)
            {
                Console.WriteLine(i);
            }
                List<Point> lpoint = new List<Point>();
                lpoint.Add(p1);
                lpoint.Add(p2);
                foreach (Point p in lpoint)
                {
                p.Draw();
                }
            Console.ReadLine();
        }
        

        }
    }

