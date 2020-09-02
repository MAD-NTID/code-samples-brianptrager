using System;

namespace PastaPalace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Trager's Pasta Palace!!\n");

            //PRICES OF FOOD OFFERED
            const double ANGEL_HAIR = 3.95;
            const double LINGUINI = 4.25;
            const double FETTUCCINI = 4.50;
            const double FARFELLE = 4.25;
            const double PENNE = 4.00;
            const double BASIC_RED_SAUCE = 2.75;
            const double MARINARA = 2.90;
            const double MEAT_SAUCE = 4.50;
            const double ALFREDO_SAUCE = 4.75;
            const double GARLIC_BREAD = 2.50;
            const double MEATBALL_OR_SAUSAGE = 2.25;
            const double GARDEN_SALAD = 4.50;
            //Price is 60% for second order
            const double DOUBLE_ORDER_FACTOR = .6;
            string orderType;
            string pastaType;
            double pastaPrice;

            Console.Write("(S)ingle or (D)ouble order? : ");
            orderType = Console.ReadLine().ToUpper();
            if(!(orderType == "S" || orderType == "D"))
            {
                Console.WriteLine("Invalid input...exiting program.");
                Environment.Exit(0);
            }

            Console.Write("Types of Pasta\n1. Angel Hair\n2. Linguini\n3. Fettuccini\n4. Farfalle\n5. Penne\n\nEnter choice: ");

            switch(Console.ReadLine())
            {
                case "1": pastaType = "Angel Hair";
                          pastaPrice = ANGEL_HAIR;
                          break;
                              

            }

        }
    }
}
