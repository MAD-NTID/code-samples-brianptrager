using System;

namespace Crazy2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[,]{
                {2, 4, 6},
                {8, 10, 12},
                {16, 18, 20}
            };

            numbers[0,0] = 2;
            numbers[0,1] = 4;
            numbers[1,0] = 6;
            numbers[1,1] = 8;
            
            for(int i = 0; i < numbers.GetLength(0); i++) //GetLength(0) - Get length of row
            {
                for(int j = 0; j < numbers.GetLength(1); j++) //GetLength(1) - Get length of column
                {
                    Console.WriteLine(numbers[i,j]);
                }
            }
        }
    }
}
