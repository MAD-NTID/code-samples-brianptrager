using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("123456", "7.3L V8", "Ford", "F-250", "Black", 2018, 4, 4, "Truck");
            Boat myBoat = new Boat();

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(myCar);
            vehicles.Add(myBoat);

            foreach(Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
            
            //Console.WriteLine(myBoat.ToString());
        }
    }
}
