using System;

namespace Task3
{
    /*
     * Написать программу, выводящую введённую пользователем строку в обратном порядке
     * (olleH вместо Hello).Написать программу, выводящую элементы двумерного массива
     * по диагонали.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эхо-бот-наоборот! Введите слово: ");
            string UsersWord = Console.ReadLine();
            GetWord(UsersWord);
        }

        static void GetWord(string usersWord)
        {            
            for (int i = usersWord.Length - 1, j = 0; i >= 0; i--, j++)
            {
                Console.Write(usersWord[usersWord.Length - 1 - j]);
            }            
        }
        
    }
}
