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
        public  char takeUserInput()
        {
            Console.WriteLine("Enter your Choice from O/X :");
            char input = Convert.ToChar(Console.ReadLine());
            return char.ToUpper(input);
        }

        public void displayBoard()
        { Console.WriteLine("\n\n");
            Console.WriteLine($"   |    |   ");
            Console.WriteLine($"___|____|___");
            Console.WriteLine($"   |    |   ");
            Console.WriteLine($"___|____|___");
            Console.WriteLine($"   |    |   ");
            Console.WriteLine($"   |    |   ");
        }
          
    }
}
