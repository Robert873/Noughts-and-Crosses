using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    class Game
    {

        private int PlayersMove()
        {
            bool correctInput = false;

            Console.WriteLine("Enter a number from the board to make your move:");

            int move = 0;

            while(correctInput != true)
            {
                move = Convert.ToInt32(Console.ReadLine());

                if ((move >= 1 && move <= 9) && board.IsPosFree(move))
                    return move;
                else if (move < 1 || move > 9)
                    Console.WriteLine("That move is not valid, only enter numbers from the board:");
                else
                    Console.WriteLine("That move is taken, only enter available numbers from the board: ");

            }
            return 0;
        }

        public void Start()
        {
            

            while (gameOver != true)
            {
                board.Draw();
                board.Update(PlayersMove(), true);
                board.Draw();
                if (board.CheckWin(true) == true)
                {
                    gameOver = true;
                    Console.WriteLine("You Win:");
                }
                else if (board.CheckDraw() == true)
                {
                    gameOver = true;
                    Console.WriteLine("It's a Draw:");
                }
                else
                {
                    board.Update(board.shuffle.GetNumber(), false);
                    board.Draw();
                    if (board.CheckWin(false) == true)
                    {
                        gameOver = true;
                        Console.WriteLine("Computer Wins:");
                    }
                }
            }

        }

        private bool gameOver = false;
        private Board board = new Board();
    }
}
