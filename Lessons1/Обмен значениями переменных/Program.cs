using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обмен_значениями_переменных
{
    class Program
    {
        // Написать программу обмена значениями двух переменных:
        // а) с использованием третьей переменной;
        // б) *без использования третьей переменной.
        static void Main(string[] args)
        {
            Console.Write("Введите переменную Х: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите переменную У: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Значение переменных до обмена: х=" + x+" y="+y);
            int z = x;
            x = y;
            y = z;                       
            Console.WriteLine("Значение переменных после обмена: х=" + x + " y=" + y);

            Console.WriteLine();
            Console.WriteLine("Обмен значениями переменных без использования третьей переменной:");
            y = x + y;
            x = y-x;
            y = y-x;
            
            Console.WriteLine($"y = x + y \n" +
                              $"x = y - x \n" +
                              $"y = y - x ");
            Console.WriteLine("Значение переменных до обмена: х=" + x + " y=" + y);
            Console.ReadLine();
        }
    }
}
