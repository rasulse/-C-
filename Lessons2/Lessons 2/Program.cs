using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_1
    {
    
    class Program
    {
        /* Код написан: Бахмудовым Расулом
         * Домашнее задание №1: Написать метод, возвращающий минимальное из трёх чисел.
         */
             
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            string a = Console.ReadLine();
            int x = int.Parse(a);

            Console.WriteLine("Введите второе число:");
            string b = Console.ReadLine();
            int y = int.Parse(b);

            Console.WriteLine("Введите третье число:");
            string c = Console.ReadLine();
            int z = int.Parse(c);
                       
            Console.WriteLine("Минимальное из чисел: " + Minimum(x, y, z));
            Console.ReadLine();
        }

        static int Minimum(int x, int y, int z)
        {
            if ((x > y) & (y > z))
            {
                return z;
            }
            else if ((x > y) & (y < z))
            {
                return y;
            }
            else return x;
        }
    }
}
