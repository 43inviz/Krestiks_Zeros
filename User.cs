using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krestiki_Noliki
{
    internal class User
    {
        public string Name { get; set; }
        public char Symb { get; set; }
        public Point Point { get; set; }

        public User()
        {
            Name = "GUEST";
            Symb = 'X';
            Point = new Point();
        }

        public User(string name, char symb)
        {
            Name = name;
            Symb = symb;
        }

        public void CreateCurrentPoint()
        {
            string xS, yS;
            int x, y;
            Console.WriteLine($"{Name}, enter your row: ");
            xS = Console.ReadLine();
            int.TryParse(xS, out x);
            Console.WriteLine("Enter your col: ");
            yS = Console.ReadLine();
            int.TryParse(yS, out y);
            Point = new Point(x, y, Symb);
        }
    }
}
