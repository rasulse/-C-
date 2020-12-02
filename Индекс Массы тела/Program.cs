using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Индекс_Массы_тела
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
            //I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            double m;
            double h;
            double i;
            Console.Write("Введите свой вес: ");
            string ves = Console.ReadLine();
            m = Convert.ToDouble(ves);

            Console.Write("Введите свой рост в метрах: ");
            string rost = Console.ReadLine();
            h = Convert.ToDouble(rost);

            i = m / (h * h);
            
            Console.WriteLine("Индекс массы тела равен: {0:F}", i);
            Console.ReadLine();
        }
    }
}
