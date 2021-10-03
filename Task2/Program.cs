using System;

namespace Task2
{
    /*
     * Написать программу «Телефонный справочник»: создать двумерный массив 5х2, хранящий список
     * телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/email.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string[,] Contacts = new string[5, 2];
            for (int i = 0; i < Contacts.GetUpperBound(0) + 1; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < Contacts.GetUpperBound(1); j++)
                {
                    Contacts[i, 0] = "Друг " + (i + 1) + "\t";
                    Contacts[i, 1] = "+79" + random.Next(000000000, 1000000000).ToString();
                    Console.Write($"{Contacts[i, j]} ");
                    Console.Write($"{Contacts[i, j + 1]} ");
                }
            }
        }
    }
}
