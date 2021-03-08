using System;

namespace snakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Snake and ladder!");
            int position = 0;
            for (position = 0; position < 100;)
            {    
                int previousPosition = position;
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
                else if (position > 100)
                {
                    Console.WriteLine("Position is above 100. Hence setting the previous position: " + previousPosition);
                    position = previousPosition;
                }
            }
            
            
        }
    }
}
