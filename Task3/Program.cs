using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i += 2)
            {
                int j = i + 1;

                if (i % 15 == 0) Console.WriteLine("Fizz Buzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);

                if (j % 15 == 0) Console.WriteLine("Fizz Buzz");
                else if (j % 3 == 0) Console.WriteLine("Fizz");
                else if (j % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(j);
            }
        }
    }
}
