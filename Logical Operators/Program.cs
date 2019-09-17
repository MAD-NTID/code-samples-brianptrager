using System;

namespace Logical_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter make of vehicle (Ford, GMC, Honda, Toyota): ");
            Console.ForegroundColor = ConsoleColor.Green;
            string make = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.White;
            int modelNum;
            string model = "";

            switch(make)
            {
                case "ford": Console.Write("Select Model: \n1 - F-150\n2 - Escape\n");
                             Console.ForegroundColor = ConsoleColor.Green;
                             if(int.TryParse(Console.ReadLine(), out modelNum))
                             {
                                 switch(modelNum)
                                 {
                                     case 1: model = "F-150";
                                             break;
                                     case 2: model = "Escape";
                                             break;
                                    default: Console.ForegroundColor = ConsoleColor.Red;
                                             Console.WriteLine("The make does not exist.  Exiting program...");
                                             Console.ForegroundColor = ConsoleColor.White;
                                             System.Threading.Thread.Sleep(500);
                                             Console.Beep(200, 500);
                                             System.Environment.Exit(0);
                                             break;
                                 }
                             }
                break;

                case "gmc": Console.Write("Select Model: \n1 - Sierra 1500\n2 - Terrain\n");
                            Console.ForegroundColor = ConsoleColor.Green;
                             if(int.TryParse(Console.ReadLine(), out modelNum))
                             {
                                 switch(modelNum)
                                 {
                                     case 1: model = "Sierra 1500";
                                             break;
                                     case 2: model = "Terrain";
                                             break;
                                    default: Console.ForegroundColor = ConsoleColor.Red;
                                             Console.WriteLine("The make does not exist.  Exiting program...");
                                             Console.ForegroundColor = ConsoleColor.White;
                                             System.Threading.Thread.Sleep(500);
                                             Console.Beep(200, 500);
                                             System.Environment.Exit(0);
                                             break;
                                 }
                             }
                break;

                case "honda": Console.Write("Select Model: \n1 - Ridgeline\n2 - Pilot\n");
                              Console.ForegroundColor = ConsoleColor.Green;
                             if(int.TryParse(Console.ReadLine(), out modelNum))
                             {
                                 switch(modelNum)
                                 {
                                     case 1: model = "Ridgeline";
                                             break;
                                     case 2: model = "Pilot";
                                             break;
                                    default: Console.ForegroundColor = ConsoleColor.Red;
                                             Console.WriteLine("The make does not exist.  Exiting program...");
                                             Console.ForegroundColor = ConsoleColor.White;
                                             System.Threading.Thread.Sleep(500);
                                             Console.Beep(200, 500);
                                             System.Environment.Exit(0);
                                             break;
                                 }
                             }
                break;

                case "toyota": Console.Write("Select Model: \n1 - Tundra\n2 - RAV4\n");
                               Console.ForegroundColor = ConsoleColor.Green;
                                if(int.TryParse(Console.ReadLine(), out modelNum))
                                {
                                    switch(modelNum)
                                    {
                                        case 1: model = "Tundra";
                                                break;
                                        case 2: model = "RAV4";
                                                break;
                                        default: 
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("The make does not exist.  Exiting program...");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                System.Threading.Thread.Sleep(500);
                                                Console.Beep(200, 500);
                                                System.Environment.Exit(0);
                                                break;
                                    }
                                }
                break;

                default: Console.ForegroundColor = ConsoleColor.Red;
                         Console.WriteLine("The make does not exist.  Exiting program...");
                         Console.ForegroundColor = ConsoleColor.White;
                         System.Threading.Thread.Sleep(500);
                         Console.Beep(500, 500);
                         System.Environment.Exit(0);
                         break;
            }
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine(make);
            if(make == "gmc")
                make = make.ToUpper();
            
            Console.WriteLine($"Congrats on purchasing {make.Replace(make[0].ToString(), make[0].ToString().ToUpper())} {model}");
        }
    }
}
