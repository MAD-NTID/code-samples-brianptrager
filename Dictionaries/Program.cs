using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            #region samplecode
            /*Dictionary<string, string> cars = new Dictionary<string, string>();

            cars.Add("A1", "Ford GT");
            cars.Add("A2", "Nissa Sentra");
            cars.Add("A3", "Honda Pilot");*/

           //Car myCar = new Car("Ford", "GT", 2020, "Blue");

            //Object Initializer Syntax (OIS)
            Car myCar = new Car() {
                Make = "Ford",
                Model = "GT",
                VIN = "A1"
            };

            //New Dictionary to hold Car objects
            //Dictionary<string, Car> cars = new Dictionary<string, Car>();

            //cars.Add(myCar.VIN, myCar);

            //Dictionary Initializer Syntax
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            cars.Add("A1", new Car(){ Make="Ford", Model="GT", Year=2020, Color="blue", VIN="A1"}); 
            cars.Add("B2", new Car(){ Make="Nissan", Model="Sentra", Year=2012, Color="silver", VIN="B2"}); 
            cars.Add("C3", new Car(){ Make="Honda", Model="Pilot", Year=2017, Color="black", VIN="C3"}); 

            /*
            foreach(KeyValuePair<string, Car>car in cars)
            {
                if(car.Key == "A1")
                    Console.WriteLine($"Key: {car.Key} Value:{car.Value}");
            }*/
            /*
            foreach(var pair in cars)
            {
                System.Console.WriteLine($"{pair.Key} \n{pair.Value}");
            }
            */
            /*    
            if(cars.ContainsKey("A2"))
            {
                System.Console.WriteLine("The car exists.");
            }*/
            /*
            if(cars.TryGetValue("A1", out Car c))
            {
                System.Console.WriteLine(c);
            }*/

            //Console.WriteLine(cars[0]);  DO NOT USE!
            //Console.WriteLine(cars["A1"]);
            #endregion
        
            while(true)
            {
                Console.Write("Enter make of car: ");
                string make = Console.ReadLine();
                //myCar.SetMake(Console.ReadLine());

                Console.Write("Enter model of car: ");
                string model = Console.ReadLine();
                //myCar.SetModel(Console.ReadLine());
                
                Console.Write("Enter year of car: ");
                int year = int.Parse(Console.ReadLine());
                //myCar.SetYear(int.Parse(Console.ReadLine()));
                
                Console.Write("Enter color of car: ");
                string color = Console.ReadLine();

                string vin;
                while(true)
                {
                    Console.ResetColor();
                    Console.Write("Enter VIN of car: ");
                    vin = Console.ReadLine();

                    if(cars.ContainsKey(vin))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("VIN already exists!");
                        continue;
                    }
                    break;
                }
                //myCar.SetColor(Console.ReadLine());
                myCar = new Car(make, model, year, color, vin);

                cars.Add(myCar.VIN, myCar);

                Console.Write("Do you wish to create another car? (y/n): ");

                //Array.Resize(ref cars, cars.Length + 1);
                //cars[cars.Length - 1] = myCar;

                if(!(Console.ReadLine().ToUpper()[0] == 'Y'))   
                    break;
            }

            Console.WriteLine($"There are {cars.Count} cars in the list.");
            /*for(int i = 0; i < cars.Count; i++)
            {
                Car car = cars[i];
                Console.WriteLine($"##########Car #{i + 1}###################");
                Console.WriteLine($"Make: {car.GetMake()}\nModel: {car.GetModel()}\nYear: {car.GetYear().ToString()}\nColor: {car.GetColor()}\n");
            }*/
            int i = 0;
            foreach(KeyValuePair<string, Car> c in cars)
            {
                Console.WriteLine($"##########Car #{i + 1}###################");
                Console.WriteLine($"{c.Value}");
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            cars.Clear();
            Console.WriteLine($"There are {cars.Count} cars in the list.");
        }
    }
}
