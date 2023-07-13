using System;

namespace SnakeAndLadder
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Snake And Ladder Program");
            snakeandladder Snakeandladder = new snakeandladder();
            Snakeandladder.DieRoll();
            Snakeandladder.Game();
        }
    }
}