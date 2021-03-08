using System;

namespace snakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and ladder!");
            int position = 0;
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("dice value is: " + dice);
        }
    }
}
