using System;
using System.IO;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {             
            string FileName = "AboutUser.txt";
            string[] UserInfo = null;

            try
            {
                UserInfo = File.ReadAllLines(FileName);
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText("AboutUser.txt", null);
            }            

            string [] HelloScreen = UserInfo == null ? SetUsersId(FileName) : File.ReadAllLines(FileName);
            foreach (var item in HelloScreen)
            {
                Console.Write(item + "\t");
            }            
            Console.ReadLine();
        }

        static string[] SetUsersId(string fileName)
        {
            string[] SetUsersInfo = new string[4];

            Console.WriteLine("Давай познакомимся.\n\n" +
                "1) Введи имя \n2) Введи фимилию \n3) Введи свой возраст \n" +
                "4) Кто ты по профессии");

            for (int i = 0; i < SetUsersInfo.Length; i++)
            {
                SetUsersInfo[i] = Console.ReadLine();
            }
            File.AppendAllLines(fileName, SetUsersInfo);

            return SetUsersInfo;
        }
       
    }
}
