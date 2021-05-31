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
            TicTacToe objTicTac = new TicTacToe();         //Created an object of an class TicTacToe
            objTicTac.createBoard();                      //accessing method by using class
            Console.ReadKey();
        }
    }
}
