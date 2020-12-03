using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2
{
    class Program
    {
        private static int number;

        /* Код написан: Бахмудовым Расулом
        * Домашнее задание №2: Написать метод подсчета количества цифр числа.
        */

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число для подсчета количества знаков: ");
            number = int.Parse(Console.ReadLine());
            int i = 0;
            Console.WriteLine(Quantity(i));
            Console.ReadKey();
        }

        public static int Quantity(int i)
        {
            while (number > 0)
            {
                i++;
                number /= 10;
            }
            return i;
        }
    }
}
