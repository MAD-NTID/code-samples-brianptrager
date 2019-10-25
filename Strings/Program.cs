using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Professor Trager";
            string upperName = name.ToUpper();
            //name = "PROFESSOR TRAGER";

            string lowerName = name.ToLower();
            //name = "professor trager";

            Console.WriteLine($"{name} is the \"best professor\" ever!");
            //Use the escape character \ to put quotes in a string

            Console.WriteLine($"The first character in the name is {name[10]}");

            //StartsWith(), EndsWith(), Contains()
            Console.WriteLine($"{name.StartsWith("pro").ToString()}");
            Console.WriteLine($"{name.EndsWith("ager").ToString()}");
            Console.WriteLine($"{name.Contains("age").ToString()}");

            //IndexOf -- reports the first occurance of the specified string
            //Console.WriteLine($"{name.IndexOf("z").ToString()}");
            Console.Write("Enter the specified string you wish to find: ");
            int index = name.IndexOf(Console.ReadLine());
            if(index == -1)
            {
                Console.WriteLine("Cannot find the specified string");
            }
            else
            {
                Console.WriteLine($"Found it at position {index}");
            }

            //Insert and Remove
            //Console.WriteLine($"{name.Insert(9, " Rockstar")}");
            name = name.Insert(name.IndexOf(" "), " Rockstar");
            Console.WriteLine($"{name}");

            //name = name.Remove(10);
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.WriteLine($"After removing at index 10, it looks like this: {name}");
            //name = name.Trim();
           // Console.WriteLine($"After trimming the name, it looks like this: {name}");
            //name = name.PadLeft(20, '#');
           // Console.WriteLine($"After padding the name, it looks like this: {name}");

            name = name.Replace("trager", "turner");
            Console.WriteLine($"After replacing the name, it looks like this: {name}");

            //Split the string
            string[] names = name.Split(' ');
            Console.WriteLine($"The names array has {names.Length} elements.");
            names[0] = names[0].ToLower();
            names[1] = names[1].ToUpper();

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            

            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append("\nProgramming Fundamentals I is so MUCH fun!!!");
            sb.Append("sb is one heck of a builder!");
            sb.Append('$');

            Console.WriteLine(sb.ToString());
            Console.WriteLine(TotalCharacterOccurances(name, 'r').ToString());
            Console.ResetColor();
        }

        private static int TotalCharacterOccurances(string s, char c)
        {
            int count = 0;
            int index = 0;
            
            while(!((index = s.IndexOf(c, index)) == -1))
            {
                count++;
                index++;
            }
            return count;
        }
    }
}
