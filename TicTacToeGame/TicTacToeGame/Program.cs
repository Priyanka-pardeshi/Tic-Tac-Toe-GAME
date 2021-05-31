using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        public const int HEAD = 0;
        public const int TAIL = 1;
        public enum Player { USER, COMPUTER };

        private static Player getWhoStartFirst()
        {
            int toss = getOneFromRandomChoice(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;     
        }
        private static int getOneFromRandomChoice(int choices)
        {
            Random objRandom = new Random();
            return (int)(objRandom.Next() * 10) % choices;
        }
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
