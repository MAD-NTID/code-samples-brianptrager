using System;
using static System.Console;
using static System.Math;

namespace Methods_II
{
    class Program
    {
        static decimal balance = 0;
        const decimal MIN_BALANCE = 5.0M;
        const decimal MIN_DEPOSIT = 1.0M;
        const decimal MIN_WITHDRAW = 20.0M;
        const decimal MAX_WITHDRAW = 300.0M;
        static void Main(string[] args)
        {
            
           // DisplayText("Hello, today is Monday!", true, ConsoleColor.Cyan);
           // DisplayText(String.Format(Math.PI.ToString()), false, ConsoleColor.Yellow);

            DisplayText("Welcome to MAD Bank!", true, ConsoleColor.Magenta);
            DisplayText("Enter your starting balance: ", false, ConsoleColor.Cyan);
            while(!InitializeBalance(decimal.Parse(Console.ReadLine())))
            {
                DisplayText("Value not acceptable.", true, ConsoleColor.Red); 
                DisplayText("Enter your starting balance: ", false, ConsoleColor.Cyan);
            }
            while(true)
            {
                DisplayText("1. Check balance\n2. Deposit\n3. Withdraw\n4. Exit program\n\nEnter choice:", false, ConsoleColor.White);

                switch(Console.ReadLine())
                {
                    case "1": DisplayText(newline: true, color: ConsoleColor.Green, msg: ShowBalance().ToString());
                              break;
                    case "2": DisplayText("Enter the amount you wish to deposit: ", false, ConsoleColor.Cyan);
                              while(!Deposit(decimal.Parse(Console.ReadLine())))
                              {
                                 DisplayText("Value not acceptable.", true, ConsoleColor.Red); 
                                 DisplayText("Enter the amount you wish to deposit: ", false, ConsoleColor.Cyan);
                              }
                              break;
                    case "3": DisplayText("Enter the amount you wish to withdraw: ", false, ConsoleColor.Cyan);
                              while(!Withdraw(decimal.Parse(Console.ReadLine())))
                              {
                                DisplayText("Value not acceptable.", true, ConsoleColor.Red); 
                                DisplayText("Enter the amount you wish to withdraw: ", false, ConsoleColor.Cyan);
                              }
                              break;
                    case "4": Environment.Exit(0);
                              break;
                    default:  DisplayText("Invalid choice, try again", true, ConsoleColor.Red);
                              break;
                }
            }

            //End of program
        }

        ///<summary>
        ///
        ///</summary>
        private static void DisplayText(string msg, bool newline, ConsoleColor color)
        {
            ForegroundColor = color;
            Write(msg);
            if (newline)
            {
                Write("\n");
            }
            ResetColor();
        }

        private static bool InitializeBalance(decimal bal = 20)
        {
            if(bal >= MIN_BALANCE)
            {
                balance = bal;
                return true;
            }
            return false;
        }
    
        private static decimal ShowBalance()
        {
            return balance;
        }

        private static bool Deposit(decimal amount)
        {
            if(amount >= MIN_DEPOSIT)
            {
                balance += amount;
                return true;
            }
            return false;
        }

        private static bool Withdraw(decimal amount)
        {
            if(amount >= MIN_WITHDRAW && amount <= (balance - MIN_BALANCE) && amount <= MAX_WITHDRAW && amount % 20 == 0)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }
}
