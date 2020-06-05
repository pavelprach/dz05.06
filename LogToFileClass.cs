using System;
using System.IO;
using System.Security;
using System.Text;

namespace LogToFile3
{
   
        public delegate void Message(string message);

    public class LogToFileClass
    {
        public event Message ShowError;

        private readonly string filePath;
        public LogToFileClass()
        {
            filePath = "log.log";
        }
        public LogToFileClass(string path)
            {
                filePath = path.Trim(); // удаление пробелов только в начале и в конце строки
            }

        public void Info(string message)
        {
            var dateTime = DateTime.Now;
            var msg = $"[{dateTime:G}] INFO : {message}"; // [dd.mm.yyyy hh:mm:ss] INFO : message
            WriteToFile(msg);
        }
        public void Error(string message)
        {
            var dateTime = DateTime.Now;
            var msg = $"[{dateTime:G}] ERROR : {message}"; // [dd.mm.yyyy hh:mm:ss] ERROR : message
            WriteToFile(msg);
        }
        public void Successfully(string message)
        {
            var dateTime = DateTime.Now;
            var msg = $"[{dateTime:G}] SUCCESS : {message}"; // [dd.mm.yyyy hh:mm:ss] SUCCESS : message
            WriteToFile(msg);
        }
        private void WriteToFile(string message)
            {
                try
                {
                    using (var file = new StreamWriter(filePath, true, Encoding.Default))
                        file.WriteLine(message);
                }
                catch (UnauthorizedAccessException)
                {
                    ShowError?.Invoke("Отказано в доступе");
                }
                catch (ArgumentException)
                {
                    ShowError?.Invoke("Пустой путь файла");
                }
                catch (DirectoryNotFoundException)
                {
                    ShowError?.Invoke("Указан недопустимый путь к файлу");
                }
                catch (IOException)
                {
                    ShowError?.Invoke("Неверный или недопустимый синтаксис имени файла, каталога или диска");
                }
                catch (SecurityException)
                {
                    ShowError?.Invoke("У вызывающего кода отсутствуют необходимые разрешения");
                }
            }
        }

    }

