using System;

namespace Task4
{
    class Program
    {
        /*
         * (*) Написать программу, вычисляющую число Фибоначчи для заданного 
         * значения рекурсивным способом.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Числа Фибоначчи. Введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciSecond(num));
            Console.WriteLine(FibonacciFirst(num));

            if (num >= 45)
            {
                Console.WriteLine(FibonacciSecond(num));
            }
            else
            {
                Console.WriteLine(FibonacciFirst(num));
            }

        }
        static int FibonacciFirst(int num)
        {
            if (num == 0) return 0;
            if (num == 1) return 1;
            else return FibonacciFirst(num - 2) + FibonacciFirst(num - 1);            
        }
        static long FibonacciSecond(int num)
        {
            long[] arr = new long[num + 1];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }
            return arr[num];
        }
    }
}
