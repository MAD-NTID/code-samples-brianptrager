using System;

/*Name: Professor BT
  Date: 9/13/2019
  Purpose: Teach students how to use TryParse 
  Caveat: They may never review this code.
  */

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constant to represent current year
            const int CURRENT_YEAR = 2019;
            Console.WriteLine("Enter the year you were born: ");

            string birthYearString = Console.ReadLine();
            //Try to parse the data.  If it works, return true.  Otherwise it will return false.
            bool intResult = int.TryParse(birthYearString, out int birthYear);
            
            //If intResult is true, execute statement within.
            if(intResult)
            {
                //If it is not beyond the current year, execute the code within the scope.
                if(birthYear > CURRENT_YEAR)
                {
                    int age = CURRENT_YEAR - birthYear;
                    Console.WriteLine($"You will be {age:D} by the end of {CURRENT_YEAR}");
                }
                else
                {
                    Console.WriteLine("You aren't born yet!");
                }
            }
            else
            {
                Console.WriteLine("Nice try!");
            }
        }
    }
}
