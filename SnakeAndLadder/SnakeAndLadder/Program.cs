using System;

namespace SnakeAndLadder
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Snake and Ladder Program");
            int number1 = 0, number2 = 0, count1, count2;
            snakeandladder snakeandladder1 = new snakeandladder();
            snakeandladder snakeandladder2 = new snakeandladder();
            snakeandladder1.DieRoll();
            snakeandladder2.DieRoll();
            while (number1 != 100 && number2 != 100)
            {
                Console.Write(" Player 1 ");
                number1 = snakeandladder1.Game();
                Console.Write(" Player 2 ");
                number2 = snakeandladder2.Game();
            }
            count2 = snakeandladder2.COunt();
            count1 = snakeandladder1.COunt(); 

            if (number1 == 100)
            {
                Console.WriteLine("Player 1 is the Champion");
                Console.WriteLine("No of Steps Taken to Win is " + count1 );
            }
            else
            {
                Console.WriteLine("Player 2 is the Champion");
                Console.WriteLine("No of Steps Taken to Win is " + count2 );
            }
            
        }
    }

}