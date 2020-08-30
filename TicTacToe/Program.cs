using System;
using TicTacToe.Classes;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
            
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner.
            bool play = true;

            while (play == true)
            {

                Console.WriteLine("Player 1 enter name.");
                string input1 = Console.ReadLine();
                Console.WriteLine("Player 2 enter name.");
                string input2 = Console.ReadLine();
                Player player1 = new Player();
                Player player2 = new Player();
                player1.Name = input1;
                player2.Name = input2;
                player1.Marker = "x";
                player2.Marker = "O";
                Game newGame = new Game(player1, player2);
                //newGame.Play();
                Player winner = newGame.Play();
                if (winner.Name != "Draw")
                {
                    Console.WriteLine($"Winner {winner.Name}");
                } else
                {
                    Console.WriteLine("Draw");
                }
                


                Console.WriteLine("Play Again? Y/N");
                string input = Console.ReadLine().ToLower();
                if (input == "y" || input == "1" || input == "yes")
                {
                    play = true;
                }
                else
                {
                    break;
                }
            }
         
        }


    }
}