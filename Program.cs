using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //create object
            TicTacToeGame game = new TicTacToeGame();
            //call generate bord method 
            char[] game_Board= game.Create_GameBoard();
            //call user taken input
            char UserInput = game.takeUserInput();
            char computerInput = (UserInput == 'X') ? 'O' : 'X';
        }
    }
}
