using System;

namespace MoreArrayLove
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = {"New York", "Chicago", "Los Angeles"};
            int departure;
            int destination;

            //dotnConsole.Write(cities.Length);

            double[,] priceGrid = new double[3,3];

            priceGrid[0,1] = 89.0;
            priceGrid[0,2] = 300;
            priceGrid[1,0] = 120;
            priceGrid[1,2] = 200;
            priceGrid[2,0] = 270;
            priceGrid[2,1] = 159.23;

            string[] expandedCities = new string[cities.Length + 1];
            expandedCities[0] = cities[0];
            expandedCities[1] = cities[1];
            expandedCities[2] = cities[2];
            expandedCities[3] = "Orlando";

            Array.Resize(ref cities, cities.Length + 1);
            cities[3] = "Orlando";


            Console.WriteLine("Welcome to MAD Airlines");
            Console.Write($"Which city are you departing from?\n1. {cities[0]}\n2. {cities[1]}\n3. {cities[2]}\n\nEnter choice: ");
            
            if(!(int.TryParse(Console.ReadLine(), out departure)))
            {
                Console.WriteLine("Invalid input");
                Environment.Exit(0);
            }
            else if(departure > 0 && departure <= cities.Length)
            {
                departure--;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Environment.Exit(0);
            }

            Console.Write($"Which city would you like to fly to?\n1. {cities[0]}\n2. {cities[1]}\n3. {cities[2]}\n\nEnter choice: ");

            if(!(int.TryParse(Console.ReadLine(), out destination)))
            {
                Console.WriteLine("Invalid input");
                Environment.Exit(0);
            }
            else if(destination > 0 && destination <= cities.Length)
            {
                destination--;
                if(destination == departure)
                {
                    Console.WriteLine("There is no airfare for same departure/destination.");
                    Environment.Exit(0);
                }             
            }
            else
            {
                Console.WriteLine("Invalid input");
                Environment.Exit(0);
            }

            Console.WriteLine($"Your airfare is {priceGrid[departure, destination]:C}");

        }//end main
    }
}
