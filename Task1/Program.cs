using System;
using System.IO;

namespace Task1
{
    /*
     * Ввести с клавиатуры произвольный набор данных и сохранить 
     * его в текстовый файл.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            File.AppendAllLines(input, new[] { input });
        }
    }
}
