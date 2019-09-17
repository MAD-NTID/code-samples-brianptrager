using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = 5;
            numOfStudents = 8;

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Beep();

            //string blowYourMinds = "14";
            int blowYourMinds = 9;
            string blowYourMindsBigTime = "51";
            decimal blowYourMindsOnceAgain = 28;
            Console.Beep();

            blowYourMindsOnceAgain = blowYourMindsOnceAgain / blowYourMinds;

            Console.WriteLine(blowYourMinds + numOfStudents + blowYourMindsBigTime);
            Console.WriteLine(blowYourMindsBigTime + blowYourMinds + numOfStudents);
            Console.WriteLine(blowYourMindsOnceAgain);
            Console.Beep();
        }
    }
}
