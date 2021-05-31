using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
           
            char[] board=TicTacToe.createBoard();                 //calling an method by usung class name
            Console.WriteLine(board);
            char choose = TicTacToe.chooseUserChar();
            Console.WriteLine("Your choice is " + choose);
            //Calling showBoard function
            TicTacToe.showBoard(board);
            //Gettin user Move
            int userMove = TicTacToe.getUserMove(board);
            TicTacToe.makeMove(board, userMove,choose);
            Console.ReadKey();
        }
    }
}
