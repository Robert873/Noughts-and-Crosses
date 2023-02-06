using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    class Board
    {
        public Board()
        {

        }
        public void Draw()
        {
            Console.Clear();

            Console.WriteLine("\n\n\t\t-------------");

            Console.Write("\t\t| {0} | {1} | {2} |", board[0], board[1], board[2]);
            Console.WriteLine("\n\t\t------------- ");
            Console.Write("\t\t| {0} | {1} | {2} |", board[3], board[4], board[5]);
            Console.WriteLine("\n\t\t------------- ");
            Console.Write("\t\t| {0} | {1} | {2} |", board[6], board[7], board[8]);
            Console.WriteLine("\n\t\t-------------");

            Console.WriteLine("\n\n");
        }

        public void Update(int pos, bool player)
        {
            turns++;

            char piece = ' ';

            if (player == true)
                piece = 'X';
            else
                piece = 'O';

            shuffle.RemoveNumber(pos);
            board[pos - 1] = piece;
        }

        public bool IsPosFree(int pos)
        {
            if (board[pos - 1] != 'O' && board[pos - 1] != 'X')
                return true;

            return false;  
        }

        public bool CheckDraw()
        {
            if (turns == 9)
                return true;
            else
                return false;
        }

        public bool CheckWin(bool player)
        {
            char piece = ' ';

            if (player == true)
                piece = 'X';
            else
                piece = 'O';

            // Checks horizontally for win condition

            if (board[0] == piece && board[1] == piece && board[2] == piece)
                return true;
            if (board[3] == piece && board[4] == piece && board[5] == piece)
                return true;
            if (board[6] == piece && board[7] == piece && board[8] == piece)
                return true;

            // Checks vertically for win condition

            if (board[0] == piece && board[3] == piece && board[6] == piece)
                return true;
            if (board[1] == piece && board[4] == piece && board[7] == piece)
                return true;
            if (board[2] == piece && board[5] == piece && board[8] == piece)
                return true;

            // Checks diagonally for win condition

            if (board[0] == piece && board[4] == piece && board[8] == piece)
                return true;
            if (board[2] == piece && board[4] == piece && board[6] == piece)
                return true;
            

            return false;
        }

        private char[] board = { '1','2','3','4','5','6','7','8','9'};
        private int turns = 0;
        public Shuffle shuffle = new Shuffle(9);
    }
}
