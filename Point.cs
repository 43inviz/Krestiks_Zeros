using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krestiki_Noliki
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symb { get; set; }

        public Point() { }
        

        public Point(int x, int y, char symb)
        {
            X = x;
            Y = y;
            Symb = symb;
        }
    }
}
