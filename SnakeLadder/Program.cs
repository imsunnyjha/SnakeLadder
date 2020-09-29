using System;

namespace SnakeLadder
{
    class Program
    {
        //Constants
        public const int NO_OF_PLAYERS = 1;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;
        public const int WINNING_POSITION = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake Ladder Problem!");
           
            //Variables
            int position = 0;
            int newPosition;

            while (position < WINNING_POSITION)
            {
                
                Random random = new Random();

                int die = random.Next(1, 7);
                Console.WriteLine("Rolling: " + die);

                //Checking 
                int optionPlay = random.Next(0, 3);
                switch (optionPlay)
                {
                    case IS_LADDER:
                        Console.WriteLine("IS_LADDER");
                        position += die;
                        if (position > 100)
                        {
                            position -= die;
                        }
                        break;
                    case IS_SNAKE:
                        Console.WriteLine("IS_SNAKE");
                        position -= die;
                        if (position < 0)
                        {
                            position = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("NO_PLAY");
                        break;
                }
                newPosition = position;
                Console.WriteLine("NEW_POSITION: " + newPosition);
            }
        }
    }
}
