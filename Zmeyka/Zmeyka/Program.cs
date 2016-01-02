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

            Point p3 = new Point(8, 8, '^');
            p3.Draw();

            Point p4 = new Point(30, 1, '&');
            p4.Draw();
            
            List<Point> Plist = new List<Point>();
            Plist.Add( p1 );
            Plist.Add( p2 );
            Plist.Add( p3 );
            Plist.Add( p4 );

           
            

            Console.ReadLine();
        }
    }
}
