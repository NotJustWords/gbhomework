using System;
using System.IO;
using System.Text.Json;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            File.AppendAllLines("startup.txt", new[] { DateTime.Now.ToString()});
            Console.WriteLine(File.ReadAllText("startup.txt"));
        }
    }
}
