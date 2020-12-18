using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DZ_1
{
    class Program
    {
        /* Код написан: Бахмудовым Расулом
        *  Домашнее задание №1:
        * Создать программу, которая будет проверять корректность ввода логина.
        * Корректным логином будет строка от 2 до 10 символов, содержащая только
        * буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        * а) без использования регулярных выражений;
        * б) с использованием регулярных выражений.*/

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

/*-------------------------------------------------------Задание А-------------------------------------------------------------------*/

            Console.WriteLine("Проверка логина без использования регулярных выражений\n");
            Console.WriteLine("Логин должен содержать от 2 до 10 символов и состоят только из символов латинского языка и цифр." +
                             " Первым символом должна быть латинская буква", ConsoleColor.Red);
            
            Console.WriteLine("Введите логин для проверки на корректность: ");
            
            while (!CheckLogin(Console.ReadLine()))
            {
                Console.Write("Вы ввели некорректный логин! Повторите еще раз", ConsoleColor.DarkRed);
                Console.Write("Введите логин для проверки на корректность: ");
            }
            ConsoleWriteLine("Логин подходит!", ConsoleColor.Green);

            Console.ReadKey();
            Console.Clear();

/*-------------------------------------------------------Задание А-------------------------------------------------------------------*/
            Console.WriteLine("Проверка логина с использованием регулярных выражений\n");
            Console.WriteLine("Логин должен содержать от 2 до 10 символов и состоят только из символов латинского языка и цифр." +
                             " Первым символом должна быть латинская буква", ConsoleColor.Red);

            Console.Write("Введите логин для проверки на корректность: ");

            while (!RegCheckLogin(Console.ReadLine()))
            {
                ConsoleWriteLine("Вы ввели некорректный логин! Повторите еще раз", ConsoleColor.DarkRed);
                Console.Write("Введите логин для проверки на корректность: ");
            }
            ConsoleWriteLine("Логин подходит!", ConsoleColor.Green);

            Console.ReadKey();
        }        

        static bool CheckLogin(string login)
        {
            bool result = false;
            login = login.ToLower();
            char[] myArray = login.ToCharArray();

            char[] characters = {
                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3',
                '4', '5', '6', '7', '8', '9'
            };

            if (login.Length >= 2 && myArray.Length <= 10 && !Char.IsDigit(myArray[0]))
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    result = false;
                    int j = 0;
                    while (j < characters.Length)
                    {
                        if (myArray[i] == characters[j])
                        {
                            result = true;
                            break;
                        }
                        j++;
                    }
                    if (!result)
                        break;
                }
            }
            return result;
        }
        
        static bool RegCheckLogin(string login)
        {
            bool result = false;
            Regex regular = new Regex(@"^[a-z][a-z\d]{1,9}$", RegexOptions.IgnoreCase);
            result = regular.IsMatch(login);
            return result;
        }

        static void ConsoleWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
