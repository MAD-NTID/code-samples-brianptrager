using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What is your favorite number?: ");
            int favNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the first number: ");
            int firstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNum = int.Parse(Console.ReadLine());

            Console.Write("Type of operation you wish to perform (+ - * / %):");
            string op = Console.ReadLine();

            PerformCalculation(firstNum, secondNum, op);

        }

        private static void PerformCalculation(int n1, int n2, string op)
        {
            switch(op)
            {
                case "+": Add(n1, n2);
                          break;
                case "-": Subtract(n1, n2);
                          break;
                case "*": Multiply(n1, n2);
                          break;
                case "/": Divide(n1, n2);
                          break;
                case "%": Modulus(n1, n2);
                          break;
                default: Console.WriteLine("Operation cannot be performed.");
                         Environment.Exit(0);
                         break;
            }

        }

        private static void Add(int n1, int n2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Addition performed: {n1} + {n2} = {n1 + n2}");
        }

        private static void Subtract(int n1, int n2)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Subtraction performed: {n1} - {n2} = {n1 - n2}");
        }

        private static void Multiply(int n1, int n2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Multiplication performed: {n1} * {n2} = {n1 * n2}");
        }

        private static void Divide(int n1, int n2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Division performed: {n1} / {n2} = {n1 / (double)n2}");
        }

        private static void Modulus(int n1, int n2)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Modulus performed: {n1} % {n2} = {n1 % n2}");
        }

        private static void printHello()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello MAD!");
        }

        private static void printHello(string message)
        {
            Console.WriteLine("Hello! " + message);
        }

        private static void printHello(string message, int number)
        {
            Console.WriteLine("Hello " + message + "!\nYour favorite number is " + number + ".");
        }
        
    }
}
