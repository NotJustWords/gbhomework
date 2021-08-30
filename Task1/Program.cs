using System;

namespace Task1
{
    /*
     * Запросить у пользователя минимальную и максимальную температуру 
     * за сутки и вывести среднесуточную температуру.      
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какая минимальная температура сегодня? ");
            float MinTemp = Convert.ToSingle (Console.ReadLine());

            Console.Write("Какая максимальная температура сегодня? ");
            float MaxTemp = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Средняя температура сегодня {(MinTemp + MaxTemp) / 2}");
        }
    }
}
