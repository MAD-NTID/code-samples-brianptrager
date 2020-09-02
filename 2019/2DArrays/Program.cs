using System;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] heroes = new string[2,5]; 
            heroes[0,0] = "Iron Man";
            heroes[0,1] = "Spiderman";
            heroes[0,2] = "Gambit";
            heroes[0,3] = "Wolverine";
            heroes[0,4] = "DareDevil";

            heroes[1,0] = "Flash";
            heroes[1,1] = "Beast Boy";
            heroes[1,2] = "Cyborgs";
            heroes[1,3] = "Superman";
            heroes[1,4] = "Aquaman";

            Console.Write("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nHero of the day {heroes[n1,n2]}\n\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            //This is for Conor.  Print all the heroes
            Console.WriteLine($"{heroes[0,0],-15}{heroes[0,1],-15}{heroes[0,2],-15}{heroes[0,3],-15}{heroes[0,4],-15}");
            Console.WriteLine($"{heroes[1,0],-15}{heroes[1,1],-15}{heroes[1,2],-15}{heroes[1,3],-15}{heroes[1,4],-15}");
            
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
