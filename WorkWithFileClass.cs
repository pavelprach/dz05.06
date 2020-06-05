using System;
using static System.Console;
using System.IO;
using LogToConsole2;
using LogToFile3;

namespace WorkWithFile
{
    
    public  class WorkWithFileClass 
    {
        public delegate void Message2(string message);
        public static event Message2 message2;
        public static void ShowCatalogInfo(string way)
        {
            try
            {
                message2?.Invoke("");
                LogToConsoleClass.Info("показать все файлы и каталоги по пути1 " + way);
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Info("показать все файлы и каталоги по пути " + way);
                string dirName = way;
                
                message2?.Invoke("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                
                message2?.Invoke("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    WriteLine(s);
                }
            }
            catch (UnauthorizedAccessException)
            {
                LogToConsoleClass.Error("У вызывающего кода отсутствуют необходимые разрешения.");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("У вызывающего кода отсутствуют необходимые разрешения ");

            }
            catch (ArgumentException)
            {
                LogToConsoleClass.Error("Пустой путь ");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Пустой путь ");
            }
            catch (DirectoryNotFoundException)
            {
                LogToConsoleClass.Error("Указан недопустимый путь к файлу");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Указан недопустимый путь к файлу" );
            }
            catch (IOException)
            {
                LogToConsoleClass.Error("Неверный или недопустимый синтаксис имени файла, каталога или диска");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Неверный или недопустимый синтаксис имени файла, каталога или диска");
            }
        }
        public static void DeleteCatalog(string way)
        {
            try
            {
                LogToConsoleClass.Successfully("удалил файл или каталог по пути " + way);
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Successfully("удалить каталог по пути " + way);
                Directory.Delete(way, true);
            }
            catch (UnauthorizedAccessException)
            {
                LogToConsoleClass.Error("У вызывающего кода отсутствуют необходимые разрешения.");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("У вызывающего кода отсутствуют необходимые разрешения ");

            }
            catch (ArgumentException)
            {
                LogToConsoleClass.Error("Пустой путь ");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Пустой путь ");
            }
            catch (DirectoryNotFoundException)
            {
                LogToConsoleClass.Error("Указан недопустимый путь к файлу");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Указан недопустимый путь к файлу");
            }
            catch (IOException)
            {
                LogToConsoleClass.Error("Неверный или недопустимый синтаксис имени файла, каталога или диска");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Неверный или недопустимый синтаксис имени файла, каталога или диска");
            }
        }
        public static void CreateCatalog(string way)
        {
            try
            {
                LogToConsoleClass.Successfully("создал каталог по пути " + way);
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Successfully("создал каталог по пути " + way);
                Directory.CreateDirectory(way);
            }
            catch (UnauthorizedAccessException)
            {
                LogToConsoleClass.Error("У вызывающего кода отсутствуют необходимые разрешения.");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("У вызывающего кода отсутствуют необходимые разрешения ");

            }
            catch (ArgumentException)
            {
                LogToConsoleClass.Error("Пустой путь ");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Пустой путь ");
            }
            catch (DirectoryNotFoundException)
            {
                LogToConsoleClass.Error("Указан недопустимый путь к файлу");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Указан недопустимый путь к файлу");
            }
            catch (IOException)
            {
                LogToConsoleClass.Error("Неверный или недопустимый синтаксис имени файла, каталога или диска");
                LogToFileClass logToFile = new LogToFileClass();
                logToFile.Error("Неверный или недопустимый синтаксис имени файла, каталога или диска");
            }


        }
       
    }
}
