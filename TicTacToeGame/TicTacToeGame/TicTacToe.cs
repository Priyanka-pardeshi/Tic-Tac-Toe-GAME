using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class TicTacToe
    {
        /// <summary>
        /// Method to create an empty board 
        /// </summary>
        /// <returns></returns>
        public char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i] = '_');
            }
            return board;
        }
        public char chooseUserChar()
        {
            Console.WriteLine("Enter your choice X or O :");
            char userSelection = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userSelection);
        }
    }
}
