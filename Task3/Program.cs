using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Task3
{
    /*
     * Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
     */
    class Program
    {
        static void Main(string[] args)
        {
            string UsersNumber;
            do
            {
                Console.WriteLine("Введите число от 0 до 255: ");
                UsersNumber = Console.ReadLine();

            } while (UsersNumber == null||Convert.ToInt32(UsersNumber) > 255);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("number.txt", FileMode.OpenOrCreate), UsersNumber);
        }
    }
}
