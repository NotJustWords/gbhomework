using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;

            Console.WriteLine("Как тебя зовут?");
            var name = Console.ReadLine();

            Console.WriteLine($"Здравствуй {name}! \nСейчас {date}");
        }
    }
}
