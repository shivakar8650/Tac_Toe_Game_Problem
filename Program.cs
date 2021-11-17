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
            //call taken user input method
            char UserInput = game.takeUserInput();
            char computerInput = (UserInput == 'X') ? 'O' : 'X';
            //call dispaly method
            game.displayBoard();
        }
    }
}
