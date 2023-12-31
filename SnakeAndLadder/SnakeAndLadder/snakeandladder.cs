﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace SnakeAndLadder
{
    public class snakeandladder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100, STARTING_POSITION = 0;
        int position = 0, count = 0;
        Random random = new Random();
        public int DieRoll()
        {
            int diePosition = random.Next(1, 7);
            count++;
            return diePosition;
        }
        public int Game()
        {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                         Console.WriteLine("Position" + " " + this.position);
                         break;
                    case LADDER:
                        int dieRoll = DieRoll();
                        dieRoll = DieRoll();
                        if (this.position + dieRoll <= WINNING_POSITION)
                        {
                            this.position += dieRoll;
                        }
                        Console.WriteLine("Position" + " " + this.position);
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
                        Console.WriteLine("Position" + " " + this.position);
                        break;

                }
            return this.position;

        }
        public int COunt()
        {
            return count;
        }
    }
}