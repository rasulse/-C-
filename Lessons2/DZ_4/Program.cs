using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4
{
    class Program
    {
        /* Код написан: Бахмудовым Расулом
        * Домашнее задание №4: Реализовать метод проверки логина и пароля.
        * На вход подается логин и пароль. На выходе истина, если прошел авторизацию,
        * и ложь, если не прошел (Логин: root, Password: GeekBrains).
        * Используя метод проверки логина и пароля, написать программу:
        * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        * С помощью цикла do while ограничить ввод пароля тремя попытками.
        */

        static void Main(string[] args)
        {
            string password = "GeekBrains";
            string login = "root";
            int popitki = 1;

            do
            {
                Console.WriteLine("Введите логин: ");
                string userlogin = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string userpassword = Console.ReadLine();

                if (userlogin == login && userpassword == password)
                {
                    Console.WriteLine("Вы авторизованы в системе!");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный логин или пароль! Повторите попытку!");
                }
                popitki++;

            } while (popitki <= 3);

            if (popitki == 4)
            {
                Console.WriteLine("Вы превысили количество попыток!");
            }
            Console.ReadLine();
        }
    }
}

        