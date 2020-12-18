using System;
using System.IO;
using static DZ_2.Message;

namespace DZ_2
{
    class Program
    {
        /* Код написан: Бахмудовым Расулом
        *  Домашнее задание №2:
        *  Разработать класс Message, содержащий следующие статические методы для обработки текста:
        *  а) Вывести только те слова сообщения, которые содержат не более n букв.
        *  б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        *  в) Найти самое длинное слово сообщения.
        *  г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        *  Продемонстрируйте работу программы на текстовом файле с вашей программой.*/

        public static void Main(string[] args)
        {

            string path = @"../../output.txt";
            ClearFile(path);

            string message = "Прежде всего, существующая теория в значительной степени обусловливает важность поэтапного и последовательного развития общества. С учётом сложившейся международной обстановки, убеждённость некоторых оппонентов, в своём классическом представлении, допускает внедрение кластеризации усилий. Как принято считать, диаграммы связей могут быть ограничены исключительно образом мышления.";
            ConsoleWriteLineColor($"Текст сообщения:", ConsoleColor.DarkGray);
            Console.WriteLine(message);
            PrintInputFile(message + "\n", path);
            Console.WriteLine();

            int length = 5;
            ConsoleWriteLineColor($"Слова из текста сообщения, состоящие из не более чем {length} символов:", ConsoleColor.DarkGray);
            PrintInputFile(PrintWords(message, length), path);
            PrintInputFile("", path);
            Console.WriteLine("\n");

            char symbol = 'о';
            ConsoleWriteLineColor($"Сообщение без слов заканчивающихся на \"{symbol}\":", ConsoleColor.DarkGray);
            Console.WriteLine(DeleteWords(message, 'о'));
            PrintInputFile(DeleteWords(message, 'о'), path);
            PrintInputFile("", path);
            Console.WriteLine();

            ConsoleWriteLineColor($"Самое длинное слово в сообщении: ", ConsoleColor.DarkGray);
            Console.WriteLine(MaxLengthWord(message));
            PrintInputFile(MaxLengthWord(message), path);
            PrintInputFile("", path);
            Console.WriteLine();

            ConsoleWriteLineColor($"Самые длинные слова в сообщении: ", ConsoleColor.DarkGray);
            Console.WriteLine(MaxLengthWord(message + ". " + message + ". " + message));
            PrintInputFile(MaxLengthWord(message + ". " + message + ". " + message), path);
            Console.WriteLine();

            ConsoleWriteLineColor($"Чтение из файла: ", ConsoleColor.DarkGray);
            Console.WriteLine(ReadFromFile(path));
            Console.ReadKey();
        }       

        public static void ConsoleWriteLineColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void ConsoleWriteColor(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }
                
        public static void PrintInputFile(string message, string path, bool append = true)
        {
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }

            try
            {
                StreamWriter sw = new StreamWriter(path, append);
                sw.WriteLine(message);
                sw.Close();
                ConsoleWriteLineColor($"Данные записаны в файл {path}", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                ConsoleWriteLineColor(e.Message, ConsoleColor.DarkRed);
            }
        }
        
        public static string ReadFromFile(string path)
        {
            string result = "";

            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
                return result;
            }

            try
            {
                StreamReader sr = new StreamReader(path);
                result = sr.ReadToEnd();
                sr.Close();
                ConsoleWriteLineColor($"Данные считаны из {path}", ConsoleColor.Green);
            }
            catch (Exception e)
            {
                ConsoleWriteLineColor(e.Message, ConsoleColor.DarkRed);
            }
            return result;
        }

        static void ClearFile(string path)
        {
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter(path, false);
                sw.Write("");
                sw.Close();
            }
        }
    }
}