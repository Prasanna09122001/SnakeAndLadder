using System;

namespace SnakeAndLadder
{
    class program
    {
        static void Main()
        {
            int number1, number2;
            Console.WriteLine("Welcome to the Snake and Ladder Program");
            snakeandladder snakeandladder1 = new snakeandladder();
            snakeandladder1.DieRoll();
            number1 = snakeandladder1.Game();
            snakeandladder snakeandladder2 = new snakeandladder();
            snakeandladder2.DieRoll();
            number2 = snakeandladder2.Game();

            Console.WriteLine("Number of Time the Dice's played by Player 1" + " = " + number1);
            Console.WriteLine("Number of Time the Dice's played by Player 2" + " = " + number2);
            if (number1.CompareTo(number2) < 0)
                Console.WriteLine("Player1 is the Champion");
            if (number1.CompareTo(number2) > 0)
                Console.WriteLine("Player2 is the Champion");

        }
    }

}