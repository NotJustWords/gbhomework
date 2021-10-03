using System;

namespace Task4
{/*
  * *«Морской бой»: вывести на экран массив 10х10, состоящий из символов
  * X и O, где Х — элементы кораблей, а О — свободные клетки.
  * 
  * НЕ МОГУ АДЕКВАТНО СОСТАВИТЬ АЛГОРИТМ РАСПРЕДЕЛЕНИЯ КОРАБЛЕЙ. Поэтому просто закреп массивовов.
  */
    class Program
    {
        static void Main(string[] args)
        {
            string[,] field = new string[10, 10];
            
            for (int i = 0; i < field.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0;  j < field.GetLength(1); j++)
                {
                    if (i == 0 && j == 1 || i == 2 && j == 3 || i == 5 && j == 8 || i == 8 && j == 2 || i == 3 && j == 8)
                    {                        
                        field[i, j] = "X ";
                        field[i + 1, j + 1] = "X ";              
                        Console.Write(field[i, j]);
                        Console.Write(field[i + 1, j + 1]);
                        j++;
                    }
                    else
                    {
                        Console.Write(field[i, j] = "O ");                        
                    }
                }
            }
        }
    }
}


