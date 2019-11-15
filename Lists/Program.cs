using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Car> cars = new List<Car>(50);
            Console.WriteLine(cars.Capacity);

            Car myCar;

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
                //myCar.SetColor(Console.ReadLine());
                myCar = new Car(make, model, year, color);

                if(cars.Count != 0)
                {
                    Console.Write("Do you want to append this car to the beginning of the list? (y/n): ");
                    if(Console.ReadLine().ToUpper() == "Y")
                        cars.Insert(0, myCar);
                    else
                        cars.Add(myCar);
                }
                else
                    cars.Add(myCar);

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
            foreach(Car c in cars)
            {
                Console.WriteLine($"##########Car #{i + 1}###################");
                Console.WriteLine(c.ToString());
                i++;
            }

            cars.Clear();
            Console.WriteLine($"There are {cars.Count} cars in the list.");
        }
    }
}
