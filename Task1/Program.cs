using System;

namespace Task1
{
    class Program
    {
        /*
           Написать метод GetFullName(string firstName, string lastName, string patronymic), 
           принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
           Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
         
         */
        static void Main(string[] args)
        {
            byte iterator = 4;
            do
            {                
                Console.WriteLine("Введите своё имя: ");
                string FirstName = Console.ReadLine();
                Console.WriteLine("Введите свою фамилию: ");
                string LastName = Console.ReadLine();
                Console.WriteLine("Введите своё отчество: ");
                string Patronymic = Console.ReadLine();
                GetFullName(FirstName, LastName, Patronymic);
                iterator--;
            }
            while (iterator > 0);
        }
        static void GetFullName(string firstName, string lastName, string patronomic)
        {
            Console.WriteLine("{0} {1} {2}",  lastName, firstName, patronomic);
        }
    }
}
