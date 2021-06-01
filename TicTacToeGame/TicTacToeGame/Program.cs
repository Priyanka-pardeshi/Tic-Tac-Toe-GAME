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

        //is winner function
        private static bool isWinner(char [] board , char ch)
        {
            return ((board[1] == ch && board[2] == ch && board[3] == ch) ||
                (board[4] == ch && board[5] == ch && board[6] == ch) ||
                (board[7] == ch && board[8] == ch && board[9] == ch) ||
                (board[1] == ch && board[4] == ch && board[7] == ch) ||
                (board[2] == ch && board[5] == ch && board[8] == ch) ||
                (board[3] == ch && board[6] == ch && board[9] == ch) ||
                (board[1] == ch && board[5] == ch && board[9] == ch) ||
                (board[7] == ch && board[5] == ch && board[3] == ch)); 
        }

        private static int getComputerMove(char[] board, char computerLetter,char userLetter)
        {
            int winnigMove = getWinningMove(board, computerLetter);
            if (winnigMove != 0) return winnigMove;
            int userWinnigMove = getWinningMove(board, computerLetter);
            if (userWinnigMove != 0) return userWinnigMove;
            int[] cornerMove = { 1, 3, 7, 9 };
            int computerMove = getRandomMoveFromList(board,cornerMove);
            if (computerMove != 0) return computerMove;
            return 0;
        }

        //Generate an Random move for computer
        private static int getRandomMoveFromList(char [] board, int [] moves)
        {
            for (int index = 0; index < moves.Length;index++ )
            {
                if (isFreeSpace(board, moves[index])) return moves[index];
            }
            return 0;
        }

        private static int getWinningMove(char [] board, char letter)
        {
            for (int index = 0; index <= board.Length; index++)
            {
                char[] copyOfBoard = getCopyOfBoard(board);
                if (isFreeSpace(copyOfBoard, index))
                {
                    makeMove(copyOfBoard, index, letter);
                    if (isWinner(copyOfBoard, letter))
                        return index;
                }
            }
            return 0;
        }

        /// <summary>
        /// Make Move Function
        /// </summary>
        /// <param name="board"> Creating a board</param>
        /// <param name="index">getting the users index</param>
        /// <param name="letter">Checking the Users Letter i.e X oe O </param>
        public static void makeMove(char[] board, int index, char letter)
        {
            bool spaceFree = isFreeSpace(board, index);
            if (spaceFree) board[index] = letter;
        }

        public static bool isFreeSpace(char[] board, int index)
        {
            return board[index] == ' ';
        }
        //GetUserMove
        public static int getUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("What is Your next move(1-9)???");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, elements => elements == index) != 0 && isFreeSpace(board, index))
                    return index;
            }
        }

        //function copy of board
        private static char[] getCopyOfBoard(char[] board)
        {
            char[] boardCopy = new char[10];
            Array.Copy(board,boardCopy,board.Length);
            return boardCopy;
        }
        static void Main(string[] args)
        {
           
            char[] board=TicTacToe.createBoard();                 //calling an method by usung class name
            Console.WriteLine(board);
            //letter
            char userLetter = TicTacToe.chooseUserChar();
            char computerLetter = TicTacToe.chooseComputerChar(userLetter);
            Console.WriteLine("Your choice is " + userLetter );       

            //Calling showBoard function
            TicTacToe.showBoard(board);
            //Gettin user Move

            int userMove = getUserMove(board);
            makeMove(board, userMove, userLetter);
            Player player = getWhoStartFirst();

            Console.WriteLine("Check if Winner:" + isWinner(board, userLetter));


            //comuter Move
            int computeMoves = getComputerMove(board,computerLetter,userLetter);
            Console.ReadKey();
        }
    }
}
