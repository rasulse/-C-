using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Текст_по_центру
{
    class Program
    {
        // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        // б) *Сделать задание, только вывод организовать в центре экрана.
        // в) **Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

        static void Position (string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }

        static void Color(ConsoleColor backgroundcolor, ConsoleColor foregroundcolor)
        {
            Console.BackgroundColor = backgroundcolor;
            Console.ForegroundColor = foregroundcolor;
        }

        static void Main(string[] args)
        {
            Color(ConsoleColor.White, ConsoleColor.Black);
            Console.Clear();           

            Console.Write("Как Вас зовут: ");
            string firstname = Console.ReadLine();
            Console.Write("Как Ваша фамилия: ");
            string lastname = Console.ReadLine();
            Console.Write("С какого Вы города: ");
            string town = Console.ReadLine();            
            Console.Clear();

            Position($"Здравствуй {firstname} {lastname} из города {town}!\n", 25, 10);                        
            Console.ReadLine();            
        }
    }
}
