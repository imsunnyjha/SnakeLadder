using System;

namespace SnakeLadder
{
    class Program
    {
        //Constants
        public const int NO_OF_PLAYERS = 1;
        public const int IS_LADDER = 1;
        public const int IS_SNAKE = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake Ladder Problem!");
           
            //Variables
            int position = 0;

            Random random = new Random();

            int die = random.Next(1, 7);
            Console.WriteLine("Rolling: " + die);

            //Checking 
            int optionPlay = random.Next(0, 3);
            switch (optionPlay)
            {
                case IS_LADDER:
                    position += die;
                    Console.WriteLine("IS_LADDER");
                    break;
                case IS_SNAKE:
                    if (position == 0)
                    {
                        position = 0;
                        Console.WriteLine("IS_SNAKE");
                    }
                    else
                    {
                        position -= die;
                        Console.WriteLine("IS_SNAKE");
                    }
                    break;
                default:
                    Console.WriteLine("NO_PLAY");
                    break;
            }
            Console.WriteLine("NEW_POSITION: " + position);
        }
    }
}
