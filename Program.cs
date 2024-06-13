using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krestiki_Noliki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();


            User user = new User("Player", 'X');
            User computer = new User("Computer", 'O');


            bool playerTurn = true;

            while (true)
            {
                game.showPlay();
                if (playerTurn)
                {
                    Console.WriteLine("Player's turn.");
                    user.CreateCurrentPoint();
                    game.placePointAt(user);
                    if (game.checkWin(user.Symb))
                    {
                        game.showPlay();
                        Console.WriteLine($"{user.Name} wins!");
                        break;
                    }

                    
                }
                else
                {
                    Console.WriteLine($"{computer.Name} turn.");
                    game.computerMove(computer);
                    if (game.checkWin(computer.Symb))
                    {
                        game.showPlay();
                        Console.WriteLine($"{computer.Name} wins!");
                        break;
                    }
                }

                if (game.isFull())
                {
                    game.showPlay();
                    Console.WriteLine("draw");
                    break;
                }

                playerTurn = !playerTurn;
            }

            Console.ReadKey();
        }
    }
}
