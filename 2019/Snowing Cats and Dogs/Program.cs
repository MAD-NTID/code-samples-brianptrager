using System;
using System.Text;

namespace Snowing_Cats_and_Dogs
{
    class Program
    {
        public static Owner[] owners = new Owner[0];
        public static Cat[] cats = new Cat[0];
        public static Dog[] dogs = new Dog[0];
        static void Main(string[] args)
        {
            Console.Write(Menu());

            switch(Console.ReadLine())
            {
                case "1": // Add new owner with cat/dog or both
                        AddOwner();
                        break;
                case "2": //List all pet parents
                        ListOwners();
                case "3": //List all pets owned by a given parent

                case "4": //Quit the program
                        Console.WriteLine("Exiting program....");
                        System.Threading.Thread.Sleep(500);
                        Console.Beep();
                        Environment.Exit(0);
                        break;
            }
        }

        private static string Menu()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("#######MAD Veterinary Clinic#######\n\n");
            sb.Append("1. Add new owner\n");
            sb.Append("2. List all Pet Parents");
            sb.Append("3. List all pets by a given owner\n");
            sb.Append("4. Exit\n\n");
            sb.Append("Enter choice: ");

            return sb.ToString();
        }
    
        private static void AddOwner()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Does this owner have a cat? (y/n): ");
            if(Console.ReadLine().ToUpper() == "Y")
            {
                AddCat(true, firstName, lastName);
            }
            else
            {
                AddCat(false);
            }

            Console.Write("Does this owner have a dog? (y/n): ");
            if(Console.ReadLine().ToUpper() == "Y")
            {
                AddDog(true, firstName, lastName);
            }
            else
            {
                AddDog(false);
            }
        }

        private static void AddCat(bool hasCat, string firstName = "Unknown", string lastName = "Unknown")
        {
            if(hasCat)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter breed: ");
                string breed = Console.ReadLine();
                Console.Write("Enter color: ");
                string color = Console.ReadLine();
                Console.Write("Has this pet been declawed (y/n): ");
                bool declawed = false;
                if(Console.ReadLine().ToUpper() == "Y")
                    declawed = true;

                Array.Resize(ref cats, cats.Length + 1);
                cats[cats.Length - 1] = new Cat(name, breed, age, color, firstName + " " + lastName, declawed);
                return;
            }
            Array.Resize(ref cats, cats.Length + 1);
            cats[cats.Length - 1] = new Cat();
        }

        private static void AddDog(bool hasDog, string firstName = "Unknown", string lastName = "Unknown")
        {
            if(hasDog)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter breed: ");
                string breed = Console.ReadLine();

                Array.Resize(ref dogs, dogs.Length + 1);
                dogs[dogs.Length - 1] = new Dog(name, breed, age, $"{firstName} {lastName}");
                return;
            }
            Array.Resize(ref dogs, dogs.Length + 1);
            dogs[dogs.Length - 1] = new Dog();
        }
    
        private static void ListOwners()
        {
            for(int i = 0; i < owners.Length; i++)
            {
                Console.WriteLine(owners[i].ToString());
            }
        }
    }
}
