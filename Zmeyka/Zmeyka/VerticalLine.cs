using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zmeyka
{
    class VerticalLine
    {
        List<Point> Plist;
        public VerticalLine(int x, int yHigth, int yDown, char sym)
        {
            Plist = new List<Point>();
            for (int y = yHigth; y <= yDown; ++y)
            {
                Point p = new Point(x, y, sym);
                Plist.Add(p);
            }
        }

        public void DrawVertical()
        {
            foreach (Point p in Plist)
            {
                p.Draw();
            }
        }

    }
}
