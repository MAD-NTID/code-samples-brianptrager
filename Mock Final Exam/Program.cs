using System;
using System.Collections.Generic;
using System.Text;

namespace Mock_Final_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Store> stores = new List<Store>();

            while(true)
            {
                Console.Write(DisplayMenu());

                switch(Console.ReadLine())
                {
                    case "1": CreateStore(ref stores);
                            break;
                    
                    case "2": Console.WriteLine(DisplayAllStores(ref stores));
                            break;

                    case "3": Console.Write(DisplayStoreTypeMenu());
                              Console.WriteLine(DisplayStoreType(ref stores));
                            break;
                    case "X": System.Environment.Exit(0);
                            break;
                }
            }
        }

        static string DisplayMenu()
        {
            return "1. Create a store\n2. Report all stores\n3.Report all stores of a type\n" + 
            "4.Report all restaurants with sit-down service\n5.Report all stores with more than 5 employees\n" +
            "6. Report all jewelry stores that can repair jewelry or install batteries" +
            "\n\nEnter choice: ";
        }

        static void CreateStore(ref List<Store> stores)
        {
            Console.Write("Store Name: ");
            string name = Console.ReadLine();
            Console.Write("Number of Employees: ");
            int employees = int.Parse(Console.ReadLine());
            Console.Write("Suite Number: ");
            string suite = Console.ReadLine();
            Console.Write("Monthly Revenue: ");
            double revenue = double.Parse(Console.ReadLine());
            string storeType = null;
            while(true)
            {
                Console.Write("Store Type:\n1. Restaurant\n2. Jewelry\n3. Clothing\n\nEnter choice: ");
                storeType = Console.ReadLine();
                if(storeType == "1" || storeType == "2" ||storeType == "3")
                    break;
            }

            switch(storeType)
            {
                case "1": 
                            Console.Write("Restaurant Type: ");
                            string type = Console.ReadLine();
                            Console.Write("Full Service (Y/N): ");
                            bool service = (Console.ReadLine().ToUpper() == "Y") ? true : false;
                            stores.Add(new Restaurant(revenue, employees, name, suite, type, service));
                            break;
                
                case "2": 
                            Console.Write("Performs Repair (Y/N): ");
                            bool repair = (Console.ReadLine().ToUpper() == "Y") ? true : false;
                            Console.Write("Battery Replacement (Y/N): ");
                            bool replacement = (Console.ReadLine().ToUpper() == "Y") ? true : false;
                            stores.Add(new Jewelry(revenue, employees, name, suite, repair, replacement));
                            break;

                case "3": 
                            Console.Write("Clothing Style: ");
                            string style = Console.ReadLine();
                            stores.Add(new Clothing(revenue, employees, name, suite, style));
                            break;
            }

        }
    
        static string DisplayAllStores(ref List<Store> stores)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Store store in stores)
            {
                sb.Append(store.ToString());
            }
            return sb.ToString();
        }
    
        static string DisplayStoreTypeMenu()
        {
            return $"1. Restaurant\n2. Jewelry\n3. Clothing" +
            "\n\nEnter choice: ";
        }
    
        static string DisplayStoreType(ref List<Store> stores)
        {
            string response = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string storeTypeKey = null;
            switch(response)
            {
                case "1": storeTypeKey = "Mock_Final_Exam.Restaurant";
                          break;

                case "2": storeTypeKey = "Mock_Final_Exam.Jewelry";
                          break;

                case "3": storeTypeKey = "Mock_Final_Exam.Clothing";
                          break;
            }

            foreach(Store store in stores)
            {
                if(store.GetType().ToString() == storeTypeKey)
                    sb.Append(store.ToString());
            }

            return sb.ToString();
        }
    
        static string DisplaySitDownRestaurants(ref List<Store> stores)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Store store in stores)
            {
                //Check if object is a Restaurant
                if(store is Restaurant)
                {
                    //Convert object type to Restaurant type
                    Restaurant r = store as Restaurant;
                    if(r.FullService)
                        sb.Append(r.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
