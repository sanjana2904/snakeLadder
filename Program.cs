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
            int options = random.Next(3);
            Console.WriteLine("option value is: " + options);

            switch (options)
            {
                case 0:
                    // NoPlay
                    break;
                case 1:
                    //Ladder
                    position = dice + position;
                    break;
                case 2:
                    //Snake
                    position = position - dice;
                    break;
                default:
                    break;
           
            }
            Console.WriteLine("position : " + position);
        }
    }
}
