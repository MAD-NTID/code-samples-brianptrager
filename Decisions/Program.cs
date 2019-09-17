using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            const double MIN_SALES_AMOUNT = 10000;
            const string BONUS_MAKE = "Nissan";
            const double BONUS = 750.0;

            Console.Write("Enter the total sale: ");
            double totalSales = double.Parse(Console.ReadLine());

            Console.Write("\nEnter the make of the vehicle: ");
            string make = Console.ReadLine();

            double largeCommissionRate = .09;
            double smallCommissionRate = .06;
            double totalCommission = 0; //variable initialization
            
            //if sales is greater than $10,000
            if(totalSales >= MIN_SALES_AMOUNT)
            {
                totalCommission = totalSales * largeCommissionRate;

                if(make == BONUS_MAKE)
                {
                    totalCommission += BONUS;  //totalCommission = totalCommission + BONUS;
                }
            }
            else
            {
                totalCommission = totalSales * smallCommissionRate;
            }

            Console.WriteLine("\nCommission: $" + (totalCommission));
        }
    }
}
