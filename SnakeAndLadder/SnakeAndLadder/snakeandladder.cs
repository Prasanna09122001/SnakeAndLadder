using System;

namespace SnakeAndLadder
{
    class snakeandladder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        int position = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            Console.WriteLine("Player Position is " + " " + this.position);
            return diePosition;
        }
        public void Game()
        {
            int option = random.Next(0, 3);
            switch(option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    this.position += DieRoll();
                    break;
                case SNAKE:
                    this.position -= DieRoll();
                    break;
            }
        }
    }
}