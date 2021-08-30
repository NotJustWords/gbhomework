using System;

namespace Task7Palindrome
{
    /*
     * (*)Является ли введеное пользователем число палиндромом?
     */
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Является ли число палиндромом? Введите число: ");
           int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isPalindrome(number));
        }
        static bool isPalindrome(int num)
        {
            if (num >= 0 && num < 10) return true;
            
            int ArrayLength = GetLength(num);          

            int[] NumArray = new int [ArrayLength];
            for (int i = ArrayLength - 1; i >= 0; i--)
            {
                NumArray[i] = num % 10;
                num = num / 10;                
            }
            
            for (int i = 0; i < ArrayLength / 2; i++)
            {
                if (NumArray[i] != NumArray[ArrayLength - i - 1])
                    return false;
            }
            return true;
        }           
        
        static int GetLength(int number)
        {
            int n = 0;
            while (number > 0)
            {                
                number = number / 10;
                ++n;
            }
            return n;
        }
    }
}
