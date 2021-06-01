using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    static class TicTacToe
    {
        /// <summary>
        /// Method to create an empty board 
        /// </summary>
        /// <returns> return an board</returns>
        public static char[] createBoard()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i] = '_');
            }
            return board;
        }

        /// <summary>
        /// Method to take user choice that its O or X
        /// </summary>
        /// <returns>returns an user selection</returns>
        public static char chooseUserChar()
        {
            Console.WriteLine("Enter your choice X or O :");
            char userSelection = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(userSelection);
        }
        
        /// <summary>
        /// Method to show an board 
        /// </summary>
        public static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("_________________");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
        }

        public static char chooseComputerChar(char user)
        {
            char computerLetter;
            if (user == 'X')
            {
                 computerLetter = 'O';
                 return computerLetter;
            }
            else
            {
                return computerLetter = 'X';
            }
        }
    }
}
