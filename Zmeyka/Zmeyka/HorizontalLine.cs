using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zmeyka
{
    class HorizontalLine
    {
        List<Point> Plist;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            Plist = new List<Point>();
            for (int x = xLeft; x <= xRight; ++x)
            {
                Point P = new Point(x, y, sym);
                Plist.Add(P);
            }
        }

        public void DrawHorizontal()
        {
            foreach (Point p in Plist)
            {
                p.Draw();
            }
        }
    }
}
