namespace Structs
{
    public struct TimeStruct
    {
        private int seconds;

        public int Seconds { get{return seconds;} 
        
                            set{
                                if(value >= 0)
                                    seconds = value;
                                else
                                    seconds = 0;} }
        public TimeStruct(int pSeconds)
        {
            seconds = pSeconds;
           // Seconds = 1500;

        }
        public int CalculateMinutes()
        {
            return seconds / 60;
        }

        public override string ToString()
        {
            return CalculateMinutes().ToString();
        } 
    }
}