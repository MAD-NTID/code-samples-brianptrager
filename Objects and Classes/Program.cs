using System;

namespace Objects_and_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[0];

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

                Console.Write("Do you wish to create another car? (y/n): ");

                Array.Resize(ref cars, cars.Length + 1);
                cars[cars.Length - 1] = myCar;

                if(!(Console.ReadLine().ToUpper()[0] == 'Y'))   
                    break;
            }
            for(int i = 0; i < cars.Length; i++)
            {
                Car car = cars[i];
                Console.WriteLine($"##########Car #{i + 1}###################");
                Console.WriteLine($"Make: {car.GetMake()}\nModel: {car.GetModel()}\nYear: {car.GetYear().ToString()}\nColor: {car.GetColor()}\n");
            }
        }
    }
}
