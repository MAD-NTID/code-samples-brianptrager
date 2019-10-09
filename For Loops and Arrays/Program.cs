using System;

namespace For_Loops_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/
            /* 
            for(int i = 5; i <= 15; i++)
            {
                Console.WriteLine(i);
            }*/
            /*
            for(int i = 15; i >= 5; i--)
            {
                Console.WriteLine(i);
            }
            */
            /* 
            for(int i = 5; i <= 15; i+=3)
            {
                Console.WriteLine(i);
            }*/
            /* 
            for(int i = 1; i <= 150; i++)
            {
                Console.Write($"{i} ");
                if((i % 10) == 0)
                {
                    Console.WriteLine();
                }
            }*/

            string[] superheroes = {"Superman", "Batman", "Wonder Woman", "Aquaman", "Cyborg", "Flash", "Green Lantern", "Shazam"};
            Array.Sort(superheroes);
            Array.Reverse(superheroes);
            for(int i = 0; i < superheroes.Length; i++)
            {
                if(superheroes[i] == "Shazam")
                {
                    Console.WriteLine($"{superheroes[i]} exists.  It is located in index {i}.");
                }
               // Console.WriteLine(superheroes[i]);
            }

            /*
            for(int i = superheroes.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(superheroes[i]);
            }*/
        }
    }
}
