using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "asdggggggreaasasdfa";
            char[] arr = word.ToCharArray();
            GetMaxSameLetters(arr);
        }

        static void GetMaxSameLetters(char[] arr)
        {
            int[] ArrayCounter = new int[arr.Length];
            int counter = -255;

            for (int i = 0; i < arr.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ArrayCounter[i] = ++max;
                    }
                }
            }

            foreach (var item in ArrayCounter)
            {
                if (item > counter) counter = item;
            }
            int index = Array.IndexOf(ArrayCounter, counter);

            Console.WriteLine($"Буква '{arr[index]}' встречается {counter} раз.");

        }
    }
}
