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

            Draw(2, 6, '#');
            

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
