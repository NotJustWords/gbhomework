using System;

namespace Task3
{

    enum Season : byte
    {
        
        January = 1,
        February,
        Marth,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
        Winter,
        Summer,
        Spring,
        Autumn
    }
    class Program
    {
        /*
         * Написать метод по определению времени года. На вход подаётся число – порядковый
         * номер месяца. На выходе — значение из перечисления (enum) — Winter, Spring, Summer,
         * Autumn.
         */

        /*
         * Не совсем осознаю, как использовать битовые маски на практике как например в этом задании.
         * Приведите пожалуйста в комментариях или в начале урока несколько примеров использования.
         * Как это использовать в этом задании?
         */
        static void Main(string[] args)
        {
            
            bool isTrue = true;
            do
            {
                Console.Write("Введите номер месяца ");
                byte NumberOfMonth = byte.Parse(Console.ReadLine());

                if (NumberOfMonth <= 12) 
                {                     
                    GetSeason(GetMonth(NumberOfMonth));
                    isTrue = false;
                }
                else Console.WriteLine("Ошибка: введите число от 1 до 12.");
            }
            while (isTrue);            
        }
        static Season GetMonth(byte numberOfMonth)
        {
            return (Season)numberOfMonth;
        }
        static void GetSeason(Season usersSeason)
        {
            switch (usersSeason)
            {
                case Season.January:
                    Console.WriteLine("Зима");
                    break;
                case Season.February:
                    goto case Season.January;
                case Season.Marth:
                    goto case Season.May;
                case Season.April:
                    goto case Season.May;
                case Season.May:
                    Console.WriteLine("Весна");
                    break;
                case Season.June:                    
                    goto case Season.August;
                case Season.July:
                    goto case Season.August;
                case Season.August:
                    Console.WriteLine("Лето");
                    break;
                case Season.September:
                    goto case Season.November;
                case Season.October:
                    goto case Season.November;
                case Season.November:
                    Console.WriteLine("Осень");
                    break;
                case Season.December:
                    goto case Season.January;
                default:
                    break;
            }            
        }    
    }
}
