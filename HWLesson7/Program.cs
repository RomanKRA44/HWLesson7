using System;

namespace HWLesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            int diag_arr = 0;
            int[,] array = new int[3, 3];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = diag_arr + 1;
                    Console.WriteLine($"{new string(' ', diag_arr)}{array[i, j]}");
                    diag_arr++;
                }
            }
        }
    }
}
