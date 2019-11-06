using System;

namespace Objects_and_Classes
{
    public class Car
    {
        public string make;
        private string model;
        private int year;
        private string color;

        public Car()
        {
            this.SetMake("Rolls Royce");
            this.SetModel("Phantom");
            this.SetYear(DateTime.Now.Year);
            this.SetColor("Red");
        }

        public Car(string make, string model, int year, string color)
        {
            this.SetMake(make);
            this.SetModel(model);
            this.SetYear(year);
            this.SetColor(color);
        }

        public void SetMake(string _make)
        {
            if(_make == "Ford" || _make == "Nissan" || _make == "Rolls Royce" || _make == "Audi" || _make == "Toyota")
                make = _make;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public void SetYear(int year)
        {
            if(year > 1900)
                this.year = year;
            else
                this.year = DateTime.Now.Year;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetMake()
        {
            return this.make;
        }

        public string GetModel()
        {
            return this.model;
        }

        public int GetYear()
        {
            return this.year;
        }

        public string GetColor()
        {
            return this.color;
        }
    }
}