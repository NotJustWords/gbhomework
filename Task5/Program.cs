using System;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 5, 4, 4, 3, 2, 6, 7, 8, 5, 4, 2, 5, 4, 4 };

           GetMaxSameNums(arr); 
        }
        static void GetMaxSameNums(int[] arr)
        {
            int[] ArrayCounter = new int[arr.Length];
            int counter = -255;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ArrayCounter[i] = ++max;
                    }
                }               
            }
            //int Max = ArrayCounter.Max();
            foreach (var item in ArrayCounter)
            {
                if (item > counter) counter = item;
            }
            int index = Array.IndexOf(ArrayCounter, counter);

            Console.WriteLine($"Число {arr[index]} встречается {counter} раз.");
            
        }
    }
}
