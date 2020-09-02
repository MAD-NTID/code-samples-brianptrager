using System;

namespace Properties
{
    public class Car
    {
        //Class variables
        public string make;
        public string Make {    get{ return make;} 
                            
                                set
                                {
                                    if(value == "Ford" || value == "Nissan" || value == "Rolls Royce" || value == "Audi" || value == "Toyota")
                                        make = value;
                                } 
                            }
        public string Model { get; set; }
        private int year;
        public int Year { get{ return year;} 
        
                          set{
                            if(year > 1900)
                                year = value;
                            else
                                year = DateTime.Now.Year;
                          } 
                        }
        public string Color { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Car()
        {
            this.Make = "Rolls Royce";
            this.Model = "Phantom";
            this.Year = DateTime.Now.Year;
            this.Color = "Red";
        }

        /// <summary>
        /// Parameterized constructor (constructor with parameters)
        /// </summary>
        /// <param name="make">Make of car</param>
        /// <param name="model">Model of car</param>
        /// <param name="year">Year of car</param>
        /// <param name="color">Color of car</param>
        public Car(string make, string model, int year, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public override string ToString()
        {
            return String.Format($"Color: {Color}\nYear: {year}\nMake: {make}\nModel: {Model}\n");
        }
    }
}