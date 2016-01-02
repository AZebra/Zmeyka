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
            Point p1 = new Point();
            p1.x = 28;
            p1.y = 4;
            p1.sym = '#';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 15;
            p2.y = 14;
            p2.sym = '*';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
