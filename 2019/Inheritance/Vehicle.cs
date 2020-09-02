using System;

namespace Inheritance
{
    public class Vehicle
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        
        private string engine;
        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        
        private string make;
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        
        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        
        protected string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Vehicle()
        {
            this.Id = "No Id";
            this.Engine = "No Engine";
            this.Make = "Unknown";
            this.Model = "Unknown";
            this.Color = "N/A";
            this.Year = DateTime.Now.Year;
        }
        
        public Vehicle(string id, string engine, string make, string model, string color, int year)
        {
            this.Id = id;
            this.Engine = engine;
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Year = year;
        }

        public override string ToString()
        {
            return String.Format($"\nId: {this.Id}\nEngine: {this.Engine}\nMake: {this.Make}\nModel: {this.Model}\nColor: {this.Color}\nYear: {this.Year}\n");
        }
    }
}