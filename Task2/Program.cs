using System;

namespace Task2
{
    class Program
    {
        /*Написать программу, принимающую на вход строку — набор чисел, 
           разделенных пробелом, и возвращающую число — сумму всех чисел в строке.
           Ввести данные с клавиатуры и вывести результат на экран.
         */

        static void Main(string[] args)
        {
            Console.Write("Сложить числа. Введите числа: ");
            string nums = Console.ReadLine();
            nums = nums.Replace(" ", "");
            char[] Array = nums.ToCharArray();
            Console.WriteLine(GetSum(Array));
            
        }
        static double GetSum (char [] arr)
        {
            double sum = 0;
            double[] NumArray = new double [arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {               
                NumArray[i] = char.GetNumericValue(arr[i]);
                sum += NumArray[i];
            }
            return sum;
        }
    }
}
