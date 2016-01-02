using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zmeyka
{
    class Square
    {
        List<Point> Plist;

        public Square(int x, int y, int lenght, char sym)
        {
            Plist = new List<Point>();
            for (int k = 0; k < lenght; ++k)
            {
                for (int i = 0; i < lenght; ++i)
                {
                    Point p = new Point(x + i, y+k, sym);
                    Plist.Add(p);
                }
            }
        }

        public void squareDraw()
        {
            foreach (Point i in Plist)
            {
                i.Draw();
            }
        }

    }
}
