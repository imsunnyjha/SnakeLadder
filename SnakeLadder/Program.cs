using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake Ladder Problem!");
            
            //Constants
            int NO_OF_PLAYERS = 1;

            //Variables
            int startPosition = 0;

            Random random = new Random();

            int die = random.Next(1, 7);
            Console.WriteLine("Rolling: " + die);
        }
    }
}
