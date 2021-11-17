using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class TicTacToeGame
    {
        char[] Game_Board = new char[10];
        public  char[] Create_GameBoard()
        {

            for (int i = 1; i <=9 ; i++)
            {
                Game_Board[i] = ' ';
            }
            return Game_Board;
        }
        public char takeUserInput()
        {
            Console.WriteLine("Enter you Choice from O/X :");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(playerChoice);
        }
    }
}
