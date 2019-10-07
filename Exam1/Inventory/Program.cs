using System;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            const double COMPUTER_VALUE = 798.50;
            int numOfComputers;

            Console.Write("Enter # of computers in entire inventory: ");
            Console.ForegroundColor = ConsoleColor.Green;

            if(!(int.TryParse(Console.ReadLine(), out numOfComputers)))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Invalid input, please enter whole number.  Exiting program....");
                Environment.Exit(0);
            }
            else if(numOfComputers < 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Number cannot be negative, exiting program...");
                Environment.Exit(0);
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n1. Add more computers\n" +
            "2. Remove computers\n" +
            "3. Display total value\n\nEnter choice: ");
            Console.ForegroundColor = ConsoleColor.Green;

            switch(Console.ReadLine())
            {
                case "1":   Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Enter # of computers to add: ");
                            if(int.TryParse(Console.ReadLine(), out int addNumber))
                            {
                                numOfComputers += addNumber; //numOfComputers = numOfComputers + addNumber;
                            }
                            break;
                case "2":   Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Enter # of computers to remove: ");
                            if(int.TryParse(Console.ReadLine(), out int removeNumber))
                            {
                                numOfComputers -= removeNumber; //numOfComputers = numOfComputers - removeNumber;
                            }
                            break;
                case "3":   Console.ForegroundColor = ConsoleColor.White;
                            break;
                default:    Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Invalid input, exiting program...");
                            Environment.Exit(0);
                            break;
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Computer Inventory Valuation\t{DateTime.Now.ToString()}\n{numOfComputers}\t{numOfComputers * COMPUTER_VALUE:C}");
        }
    }
}