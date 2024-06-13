using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krestiki_Noliki
{
    internal class Game
    {
        public int Cols { get; set; }
        public int Rows { get; set; }
        public Point[,] Playground { get; set; }

        public Game()
        {
            Cols = 3;
            Rows = 3;
            Playground = new Point[Cols, Rows];

            for (int i = 0; i < Cols; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    Playground[i, j] = new Point(i, j, ' ');
                }
            }
        }

        public bool isPlaceEmpty(int x, int y)
        {
            return Playground[x, y].Symb == ' ';
        }

        public void placePointAt(User user)
        {
            if (isPlaceEmpty(user.Point.X , user.Point.Y ))
            {
                Playground[user.Point.X , user.Point.Y ].Symb = user.Symb;
            }
            else
            {
                throw new Exception("Place not empty\n");
            }
        }



        public void showPlay()
        {
            //kolonk
            Console.Write("  ");
            for (int j = 0; j < Rows; j++)
            {
                Console.Write($" {j}  ");
                if (j < Rows - 1) Console.Write(" ");
            }
            Console.WriteLine();
            //stroki
            for (int i = 0; i < Cols; i++)
            {

                Console.Write($"{i}  ");

                for (int j = 0; j < Rows; j++)
                {
                    Console.Write(Playground[i, j].Symb);
                    if (j < Rows - 1) Console.Write(" | ");
                }
                Console.WriteLine();
                if (i < Cols - 1) Console.WriteLine("   --|---|--");
            }
        }

        public bool checkWin(char symb)
        {

            for (int i = 0; i < Cols; i++)
            {
                if ((Playground[i, 0].Symb == symb && Playground[i, 1].Symb == symb && Playground[i, 2].Symb == symb) ||
                    (Playground[0, i].Symb == symb && Playground[1, i].Symb == symb && Playground[2, i].Symb == symb))
                {
                    return true;
                }
            }
            if ((Playground[0, 0].Symb == symb && Playground[1, 1].Symb == symb && Playground[2, 2].Symb == symb) ||
                (Playground[0, 2].Symb == symb && Playground[1, 1].Symb == symb && Playground[2, 0].Symb == symb))
            {
                return true;
            }
            return false;
        }

        public bool isFull()
        {
            for (int i = 0; i < Cols; i++)
            {
                for (int j = 0; j < Rows; j++)
                {
                    if (Playground[i, j].Symb == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void computerMove(User computer)
        {
            Random rand = new Random();
            int x, y;
            do
            {
                x = rand.Next(0, 3);
                y = rand.Next(0, 3);
            } while (!isPlaceEmpty(x, y));

            computer.Point = new Point(x, y, computer.Symb);
            placePointAt(computer);
        }
    }
}
