using System;

namespace SnakeAndLadder
{
    class snakeandladder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100, STARTING_POSITION = 0;
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
            while (this.position < WINNING_POSITION)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                       int dieRoll = DieRoll();
                        if (this.position + dieRoll <= WINNING_POSITION)
                        {
                            this.position += dieRoll;
                        }
                        break;
                    case SNAKE:
                        dieRoll = DieRoll();
                        if (this.position - dieRoll < STARTING_POSITION)
                        {
                            this.position = 0;
                        }
                        else
                        {
                            this.position -= dieRoll;
                        }
                        break;
                }
            }
            Console.WriteLine("Player is the Winner");
        }
    }
}