using System;

namespace DateTimeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            DateTime startOfFallSemester = new DateTime(2019, 8, 26);
            DateTime firstExamDate = dt.AddDays(7);
            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.Month);
            Console.WriteLine($"First Exam Date {firstExamDate.ToLongDateString()}");
            

            Console.WriteLine(startOfFallSemester.ToString());

            TimeSpan ts = dt.Subtract(startOfFallSemester);
            int totalDays = (int)ts.TotalDays;

            Console.WriteLine($"Days: {totalDays.ToString()}");
        }
    }
}
