using System;

namespace Lists
{
    public class Car
    {
        //Class variables
        public string make;
        private string model;
        private int year;
        private string color;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Car()
        {
            this.SetMake("Rolls Royce");
            this.SetModel("Phantom");
            this.SetYear(DateTime.Now.Year);
            this.SetColor("Red");
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
            this.SetMake(make);
            this.SetModel(model);
            this.SetYear(year);
            this.SetColor(color);
        }

        /// <summary>
        /// Validates data (make) and sets value if valid
        /// </summary>
        /// <param name="_make">Make of car</param>
        public void SetMake(string _make)
        {
            if(_make == "Ford" || _make == "Nissan" || _make == "Rolls Royce" || _make == "Audi" || _make == "Toyota")
                make = _make;
        }

        /// <summary>
        /// Sets model of car (no validation)
        /// </summary>
        /// <param name="model">Model of car</param>
        public void SetModel(string model)
        {
            this.model = model;
        }

        /// <summary>
        /// Validates data (year) and sets value if data is 1900 or newer
        /// </summary>
        /// <param name="year">year of car</param>
        public void SetYear(int year)
        {
            if(year > 1900)
                this.year = year;
            else
                this.year = DateTime.Now.Year;
        }

        /// <summary>
        /// Sets value to color
        /// </summary>
        /// <param name="color">Color of car</param>
        public void SetColor(string color)
        {
            this.color = color;
        }

        /// <summary>
        /// Returns make of car
        /// </summary>
        /// <returns>make</returns>
        public string GetMake()
        {
            return this.make;
        }

        /// <summary>
        /// Returns model of car
        /// </summary>
        /// <returns>model</returns>
        public string GetModel()
        {
            return this.model;
        }
        
        /// <summary>
        /// Returns year of car
        /// </summary>
        /// <returns>year</returns>
        public int GetYear()
        {
            return this.year;
        }

        /// <summary>
        /// Returns color of car
        /// </summary>
        /// <returns>color</returns>
        public string GetColor()
        {
            return this.color;
        }

        public override string ToString()
        {
            return String.Format($"Make: {this.GetMake()}\nModel: {this.GetModel()}\nYear: {this.GetYear().ToString()}\nColor: {this.GetColor()}\n");
        }
    }
}