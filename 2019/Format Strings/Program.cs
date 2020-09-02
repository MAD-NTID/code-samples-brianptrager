using System;

namespace Format_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            long numAccount = 34242423412;
            decimal accountBalance = 1256745.54m;
            long numAccount2 = 2423412;
            decimal accountBalance2 = 7543.12m;

            Console.WriteLine("{0,-15:D} {1,15:C}", numAccount, accountBalance);
            Console.WriteLine("{0,-15:D} {1,15:C}", numAccount2, accountBalance2);
        }
    }
}
