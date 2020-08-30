using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};


		public void DisplayBoard()
		{

			//TODO: Output the board to the console
			

			for (int i = 0; i<3; i++)
            {
				string line = "";
				for (int j = 0; j < 3; j++)
				{
					line = $"{line} | {GameBoard[i,j]}";
				}
				Console.WriteLine($"{line} |");
			}
			
		
		}
	}
}