using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zmeyka
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(28, 4, '#');
            p1.Draw();

            Point p2 = new Point(15, 14, '*');
            p2.Draw();

            Console.ReadLine();
        }
    }
}
