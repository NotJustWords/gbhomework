using System;

namespace Task6
{
    class Program
    {
        /*
         * (*) Для полного закрепления битовых масок, попытайтесь создать универсальную структуру
         * расписания недели, к примеру, чтобы описать работу какого-либо офиса.
         * Явный пример - офис номер 1 работает со вторника до пятницы, офис номер 2 работает
         * с понедельника до воскресенья и выведите его на экран консоли.
         */
        enum DayOfWeek
        {
            Monday = 0b000_0001,
            Tuesday = 0b000_0010,
            Wednesday = 0b000_0100,
            Thursday = 0b000_1000,
            Friday = 0b001_0000,
            Saturday = 0b010_0000,
            Sanday = 0b100_0000
        }
        static void Main(string[] args)
        {
            //BitMasks
            DayOfWeek moscowOfficeTimetable = DayOfWeek.Monday | DayOfWeek.Thursday | DayOfWeek.Wednesday |
                DayOfWeek.Thursday;
            DayOfWeek berlinOfficeTimetable = DayOfWeek.Friday | DayOfWeek.Saturday | DayOfWeek.Sanday;

            DayOfWeek allDays = (DayOfWeek)0b111_1111;

            DayOfWeek moscowOffice = allDays & moscowOfficeTimetable;
            DayOfWeek berlinOffice = allDays & berlinOfficeTimetable;

            bool isMoscow = moscowOfficeTimetable == moscowOffice;
            bool isBerlin = berlinOfficeTimetable == berlinOffice;

            if (isMoscow)
            {
                Console.WriteLine("Офис в Москве работает с {0} до {1}", DayOfWeek.Monday, DayOfWeek.Thursday); ;
            }
            if (isBerlin)
            {
                Console.WriteLine("Офис в Берлине работает с {0} до {1}", DayOfWeek.Friday, DayOfWeek.Sanday);
            }
        }
    }
}
