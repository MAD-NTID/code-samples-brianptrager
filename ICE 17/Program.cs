using System;
/// <summary>
/// Name: Professor Trager
/// Date: 10/16/2019
/// Course: Programming Fundamentals I: Mobile Domain 
/// Purpose: This program will collect data for a single student
/// </summary>
namespace ICE_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentCodes = new string[0];
            double[] scores = new double[0];
            bool flag = true;
            double score = 0;
            string code = "Z";
            
            Console.WriteLine("*** Class Average Calculator ***");

            while(flag)
            {
                Console.ResetColor();
                Console.Write("Enter 'U' for Undergraduate student, 'G' for Graduate student (type X to exit): ");
                code = Console.ReadLine().ToUpper();
                if(code == "X")
                {
                    flag = false;
                    continue;
                }
                switch(code)
                {
                    case "U":
                    case "G": break;
                    
                    default: Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid input - exiting program");
                            Console.ForegroundColor = ConsoleColor.White;
                            
                            continue;
                }
                while(true)
                {
                    Console.ResetColor();
                    Console.Write("Enter the score for this student (0-100): ");
                    if(!(double.TryParse(Console.ReadLine(), out score)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input - it is not entered in the correct format.");
                        continue;         
                    }
                    if(!(score >= 0 && score <= 100))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input - score must be between 0 - 100.");
                        continue;
                    }
                    break;
                }
                //All is well
                Array.Resize(ref studentCodes, studentCodes.Length + 1);
                Array.Resize(ref scores, scores.Length + 1);

                studentCodes[studentCodes.Length - 1] = code;
                scores[scores.Length - 1] = score;
            }
        }
    }
}
