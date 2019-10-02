using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lostValues = new int[6];

            lostValues[0] = 4;
            lostValues[1] = 8;
            lostValues[2] = 15;
            lostValues[3] = 16;
            lostValues[4] = 23;
            lostValues[5] = 42;

            int total = lostValues[0] + lostValues[1] + lostValues[2] +
                        lostValues[3] + lostValues[4] + lostValues[5];

            Console.WriteLine("Total of all values: " + total);

            string[] heroes = new string[60];

            heroes[0] = "Spiderman";
            heroes[1] = "Cyclops";
            heroes[2] = "Batman";
            heroes[3] = "Iron Man";
            heroes[4] = "Superman";
            heroes[5] = "Black Panther";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"\n\nChoose a number (1 - {heroes.Length}): ");

            int selection = int.Parse(Console.ReadLine());

            if(selection >= 1 && selection <= heroes.Length)
            {
                if(heroes[selection] != null)
                {
                    Console.WriteLine("Hero of the day: " + heroes[--selection]);
                }
                else
                {
                    Console.WriteLine("Sorry, the hero you selected went out to lunch!");
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
