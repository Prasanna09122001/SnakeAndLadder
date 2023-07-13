using System;

namespace SnakeAndLadder
{
    class snakeandladder
    {
        int position = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            Console.WriteLine("Player Position" + " " + this.position);
            return diePosition;
        }
    }
}