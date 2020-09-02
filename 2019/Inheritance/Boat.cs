namespace Inheritance
{
    public class Boat : Vehicle
    {
        private bool hasRudder;
        public bool HasRudder
        {
            get { return hasRudder; }
            set { hasRudder = value; }
        }
        
        private bool hasSail;
        public bool HasSail
        {
            get { return hasSail; }
            set { hasSail = value; }
        }
        
        private int cabinSqft;
        public int CabinSqft
        {
            get { return cabinSqft; }
            set { cabinSqft = value; }
        }
        
        public Boat() : base()
        {
            this.CabinSqft = 0;
            this.HasRudder = false;
            this.HasSail = false;
        }

        public Boat(string id, string engine, string make, string model, string color, int year, int cabinSqft, bool hasRudder, bool hasSail) : base(id, engine, make, model, color, year)
        {
            this.CabinSqft = cabinSqft;
            this.HasRudder = hasRudder;
            this.HasSail = hasSail;
        }
    
        public override string ToString()
        {
            return string.Format($"\n==============BOAT==================\n{base.ToString()}\nHas Rudder: {this.HasRudder}\nCabin Square Footage: {this.CabinSqft}\nHas Sail: {this.HasSail}\n");
        }       
    }
}