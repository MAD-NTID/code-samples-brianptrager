using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            age = 44;
            int myDogAge = 5;
            int dogYearsFactor = 7;

            string firstName = "Brian";
            string lastName = "Trager";
            string fullName = firstName + " " + lastName;
            string reverseFullName = lastName + ", " + firstName;

            Console.WriteLine("I am " + age + " years old.");
            age = 25;

            Console.WriteLine("I am " + age + " years old.\n");
            Console.WriteLine("My dog is " + (myDogAge * dogYearsFactor) + " years old.");

            Console.WriteLine("\n\nFull Name: " + fullName);
            Console.WriteLine("Reverse Full Name: " + reverseFullName + "\n\n");
        }
    }
}
