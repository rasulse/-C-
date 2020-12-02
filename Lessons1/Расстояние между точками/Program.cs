using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расстояние_между_точками
{
    class Program
    {
        // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,y1 и x2,y2
        //  по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат,
        // используя спецификатор формата .2f(с двумя знаками после запятой);
        // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

        static double Distance (double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите х1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите у1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите х2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите у2: ");
            double y2 = double.Parse(Console.ReadLine());

            //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            Console.WriteLine("Расстояние между координатами х1, у1 и х2, у2 равно: {0:F}", Distance (x1, y1, x2, y2));
            Console.ReadLine();

        }
    }
}
