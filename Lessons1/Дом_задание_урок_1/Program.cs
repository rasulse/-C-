using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дом_задание_урок_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Вы используете программы \"Анкета\"");
            Console.Write("Введите Ваше имя: ");
            string firstname = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string lastname = Console.ReadLine();

            Console.Write("Сколько Вам лет: ");
            string age = Console.ReadLine();

            Console.Write("Какой у Вас рост: ");
            string height = Console.ReadLine();

            Console.Write("Какой у Вас вес: ");
            string weight = Console.ReadLine();

            Console.WriteLine("Имя: "+firstname+", Фамилия: "+lastname+", Возраст: "+age+", Рост: "+height+", Вес: "+weight);
            string rezult = String.Format("Имя: {0}, Фамилия: {1}, Возраст: {2}, Рост: {3}, Вес: {4}", firstname, lastname, age, height, weight);
            Console.WriteLine(rezult);
            Console.WriteLine($"Имя: {firstname}, Фамилия: {lastname}, Возраст: {age}, Рост: {height}, Вес: {weight}");
            
            Console.ReadLine();

        }
    }
}
