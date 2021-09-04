using System;

namespace Task1
{
    /*
     * Написать программу, выводящую элементы двумерного массива по диагонали.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            GetArray(myArray);
        }
        static void GetArray(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                Console.WriteLine(Array[i, i]);
            }
        }
    }
}
