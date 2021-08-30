using System;

namespace Task3
{
    /*
     * Определить, является ли введённое пользователем число чётным.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Четное ли число? Введите число : ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetEven(UserNumber));
        }
        static bool GetEven(int userNumber)
        {            
            bool isTrue = userNumber % 2 == 0 ? true : false;          

            return isTrue;
        }
        
    }   
}
