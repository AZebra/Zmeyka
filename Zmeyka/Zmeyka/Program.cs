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
            
            HorizontalLine hl1 = new HorizontalLine(13, 26, 6, '#');
            hl1.DrawHorizontal();

            VerticalLine vl1 = new VerticalLine(3, 4, 9, '#');
            vl1.DrawVertical();

            Square s1 = new Square(10, 10, 3, '#');
            s1.squareDraw();

            Console.ReadLine();
        }
    }
}
