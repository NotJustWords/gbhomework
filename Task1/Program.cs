using System;
using System.Diagnostics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;

            while (isTrue)
            {

                foreach (Process process in Process.GetProcesses())
                {
                    Console.WriteLine($"|Id: { process.Id,-5}| Name: {process.ProcessName,-18}\n|");                    
                }

                Console.Write("Введите q, чтобы выйти.\n\nВведите Id процесса, который вы хотите" +
                    " завершить: ");
                string UsersId = Console.ReadLine();
                if (UsersId == "q") isTrue = false;
                else SetProcess(int.Parse(UsersId));               

            }

        }

        static void SetProcess(int usersId)
        {
            Process ProcessById = Process.GetProcessById(usersId);
            
            try
            {
                ProcessById.Kill();
            }
            catch (ArgumentException)
            {
                throw new Exception("Процесса с таким Id не существует.");
            }
        }
    }
}
