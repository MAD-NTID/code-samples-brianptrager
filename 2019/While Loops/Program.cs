using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int counter = 1;
            int totalScores = 0;

            while(true)
            {
                Console.Write($"Enter test score #{counter} (enter -99 to exit): ");
                
                if(!(int.TryParse(Console.ReadLine(), out number)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, not an integer!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else if(!(number >= 0 && number <= 100))
                {
                    if((number == -99))
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Invalid input, score must be between 0 and 100.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                
                totalScores += number;
                counter++;
            }
            Console.WriteLine($"Average test score: {totalScores / --counter}");
        }
    }
}