using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    class Program
    {

        /* Код написан: Бахмудовым Расулом
        * Домашнее задание №3: С клавиатуры вводятся числа, пока не будет введен 0.
        * Подсчитать сумму всех нечетных положительных чисел.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите положительное число: ");
            int summa = 0;
            int number = 0;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число: ");
            }

            do
            {                
                number =int.Parse(Console.ReadLine());
                if (number > 0 && number % 2 == 1)
                    summa = summa + number;
            } while (number != 0);                  
            
            Console.WriteLine("Сумма всех нечетных положительных чисел равна: " + summa);
            Console.ReadLine();
                       
        }
    }
}
