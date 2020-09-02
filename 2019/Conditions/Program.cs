using System;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MINIMUM_DRINKING_AGE = 21;

            Console.Write("Enter your age: ");

            if(int.TryParse(Console.ReadLine(), out int age))
            {
                if(0 <= age)
                {
                    /*if(age >= MINIMUM_DRINKING_AGE)
                    {
                        Console.WriteLine("You are legally permitted to drink.");
                    }
                    else
                    {
                        Console.WriteLine("You are not allowed to drink any beer or whatever");
                    }*/
                    Console.WriteLine((age >= MINIMUM_DRINKING_AGE) ? "Allowed to drink" : "Not allowed to drink");
                }
                else
                {
                    Console.WriteLine("Negative number is an invalid input...exiting program");
                    Console.Beep(200,2000);
                    Console.Beep(1000,1000);
                    Console.Beep(200,2000);
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Not a valid input.");
                Console.Beep(200,2000);
            }
        }
    }
}
