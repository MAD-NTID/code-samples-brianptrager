using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeStruct ts = new TimeStruct(240);
            //ts.Seconds = 60;
            DateTime dt = new DateTime();
            ts.Seconds = 1500;

            Console.WriteLine(ts.ToString());
            Console.WriteLine(dt.ToLongDateString());
        }
    }
}
