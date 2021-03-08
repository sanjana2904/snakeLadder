using System;

namespace snakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Snake and ladder!");
            int position = 0;
            for (position = 0; position <= 100; position++)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("dice value is: " + dice);
                int options = random.Next(3);
                Console.WriteLine("option value is: " + options);

                switch (options)
                {
                    case 0:
                        break;
                    case 1:
                        position = dice + position;
                        break;
                    case 2:
                        position = position - dice;
                        break;
                    default:
                        break;

                }
                Console.WriteLine("position : " + position);
                if (position < 0)
                {
                    Console.WriteLine("Position is below 0. Hence resetting the position to 0");
                    position = 0;
                }
            }
            
            
        }
    }
}
