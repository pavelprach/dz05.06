using System;
using System.IO;
using static System.Console;
using WorkWithFile;
using LogToFile3;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;

namespace ConsoleApp16
{
    class Program
    {
        public delegate void Message1(string message);
        static public void ShowMessage(string msg)
        {
            WriteLine(msg);
        }
        static void Main(string[] args)
        {
            Message1 message1;
            message1 = ShowMessage;
            WorkWithFileClass.message2 += ShowMessage;


            string path;
            bool endWhile = true;
            while (endWhile == true)
            {

                message1?.Invoke("1: создать каталог\n2: показать все файлы и каталоги\n3: удалить каталог");
                int k = Convert.ToInt32(ReadLine());
                switch (k)
                {
                    case 1:
                        message1?.Invoke("укажите путь");
                        path = ReadLine();
                        WorkWithFileClass.CreateCatalog(path);
                        break;
                    case 2:
                        message1?.Invoke("укажите путь");
                        path = ReadLine();
                        WorkWithFileClass.ShowCatalogInfo(path);
                        break;
                    case 3:
                        message1?.Invoke("укажите путь");
                        path = ReadLine();
                        WorkWithFileClass.DeleteCatalog(path);
                        break;
                    case 4:
                        message1?.Invoke("укажите путь");
                        path = ReadLine();
                        break;
                }
                message1?.Invoke("1:продолжить работу программы\n2:завершить работу программы");
                int p = Convert.ToInt32(ReadLine());
                switch (p)
                {
                    case 1:
                        endWhile = true;
                        break;
                    case 2:
                        endWhile = false;
                        break;
                }
            }

        }
    
    }
}
