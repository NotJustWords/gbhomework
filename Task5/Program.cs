using System;

namespace Task5
{
    class Program    
    {
     /*
     * (*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0,
     * вывести сообщение «Дождливая зима».
     */
        [Flags]
        enum Months : int
        {
            January,
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
            float MaxTemp;
            float MinTemp;
            float temp;           

            Console.Write("Какой сейчас месяц? ");
            string UsersMonth = Console.ReadLine();

            Console.Write("Какая максимальная температура в этом месяце? ");
            MaxTemp = Convert.ToSingle(Console.ReadLine());

            Console.Write("Какая минимальная температура в этом месяце? ");
            MinTemp = Convert.ToSingle(Console.ReadLine());

            temp = (MinTemp + MaxTemp) / 2;

            if (temp >= 0 && (UsersMonth == "1" || UsersMonth == "2" || UsersMonth == "12"))
            {
                Console.WriteLine($"Дождливая зима.");                
            }
            else
            {
                switch (UsersMonth)
                {
                    case "1":
                        Console.WriteLine(Months.January); break;
                    case "2":
                        Console.WriteLine(Months.February); break;
                    case "3":
                        Console.WriteLine(Months.Marth); break;
                    case "4":
                        Console.WriteLine(Months.April); break;
                    case "5":
                        Console.WriteLine(Months.May); break;
                    case "6":
                        Console.WriteLine(Months.June); break;
                    case "7":
                        Console.WriteLine(Months.July); break;
                    case "8":
                        Console.WriteLine(Months.August); break;
                    case "9":
                        Console.WriteLine(Months.September); break;
                    case "10":
                        Console.WriteLine(Months.October); break;
                    case "11":
                        Console.WriteLine(Months.November); break;
                    case "12":
                        Console.WriteLine(Months.December); break;
                    default:
                        Console.WriteLine("There is no such month"); break;

                }
                Console.WriteLine($"Средняя температура: {temp}");
            }         

            
        }
    }
}
