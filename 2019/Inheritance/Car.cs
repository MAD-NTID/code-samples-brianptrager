namespace Inheritance
{
    public class Car : Vehicle
    {
        private int numOfWheels;
        public int NumOfWheels
        {
            get { return numOfWheels; }
            set { numOfWheels = value; }
        }
        
        private string carType;
        public string CarType
        {
            get { return carType; }
            set { carType = value; }
        }
        
        private int numOfDoors;
        public int NumOfDoors
        {
            get { return numOfDoors; }
            set { numOfDoors = value; }
        }
        
        private bool hasSpoiler;
        public bool HasSpoiler
        {
            get { return hasSpoiler; }
            set { hasSpoiler = value; }
        }
        
        public Car() : base()
        {
            this.NumOfDoors = 2;
            this.NumOfWheels = 4;
            this.CarType = "Car";
            this.HasSpoiler = false;
        }

        public Car(string id, string engine, string make, string model, string color, int year, int numOfDoors, int numOfWheels, string carType, bool hasSpoiler = false) : base(id, engine, make, model, color, year)
        {
            this.NumOfDoors = numOfDoors;
            this.NumOfWheels = numOfWheels;
            this.CarType = carType;
            this.HasSpoiler = hasSpoiler;
        }
    
        public override string ToString()
        {
            return string.Format($"\n==============CAR==================\n{base.ToString()}\nNumber of Wheels: {this.NumOfWheels}\nNumber of Doors: {this.NumOfDoors}\nCar Type: {this.CarType}\nHas Spoiler: {this.HasSpoiler}");
        }
    
    }
}