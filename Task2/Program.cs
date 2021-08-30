using System;

namespace Task2
{
    /*
     * Запросить у пользователя порядковый номер текущего месяца и вывести его название.
     */
    class Program
    {
        [Flags]

        enum MyEnum
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
            December
        }

        static void Main(string[] args)
        {
            Console.Write("Какой месяц сейчас по счету? ");
            int MonthByCount = Convert.ToInt32(Console.ReadLine());

            GetMonth(MonthByCount);
        }
        static void GetMonth(int month)
        {
            switch (month)
            {
                case 1:
                    Console.WriteLine(MyEnum.January); break;
                case 2:
                    Console.WriteLine(MyEnum.February); break;
                case 3:
                    Console.WriteLine(MyEnum.Marth); break;
                case 4:
                    Console.WriteLine(MyEnum.April); break;
                case 5:
                    Console.WriteLine(MyEnum.May); break;
                case 6:
                    Console.WriteLine(MyEnum.June); break;
                case 7:
                    Console.WriteLine(MyEnum.July); break;
                case 8:
                    Console.WriteLine(MyEnum.August); break;
                case 9:
                    Console.WriteLine(MyEnum.September); break;
                case 10:
                    Console.WriteLine(MyEnum.October); break;
                case 11:
                    Console.WriteLine(MyEnum.November); break;
                case 12:
                    Console.WriteLine(MyEnum.December); break;
                default:
                    Console.WriteLine("Такого месяца не существует."); break;

            }
        }
    }
}


    

    
    
    

