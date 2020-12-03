using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5
{
    class Program
    {
        /* Код написан: Бахмудовым Расулом
        * Домашнее задание №5: а) Написать программу, которая запрашивает массу и рост человека,
        * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        * 
        * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        */
        

        static void Main(string[] args)
        {
            double m;
            double h;
            double i;
            Console.Write("Введите свой вес: ");
            string ves = Console.ReadLine();
            m = Convert.ToDouble(ves);

            Console.Write("Введите свой рост в метрах (пример 1,75): ");
            string rost = Console.ReadLine();
            h = Convert.ToDouble(rost);

            i = m / (h * h);
            Console.WriteLine("Индекс массы Вашего тела равен: {0:F}", i);

            if (i < 16)
            {
                Console.WriteLine("У Вас дефицит массы тела, необходимо набрать вес.");
            }
            else if (i >= 16 && i <= 18.5)
            {
                Console.WriteLine("У Вас недостаточная масса тела, необходимо набрать вес.");
            }
            else if (i >= 18.5 && i <= 25)
            {
                Console.WriteLine("У Вас нормальная масса тела.");
            }
            else if (i >= 25 && i <= 30)
            {
                Console.WriteLine("У Вас избыточная масса тела, Вам необходимо похудеть.");
            }
            else if (i >= 30 && i <= 35)
            {
                Console.WriteLine("У Вас ожирение первой степени. Вам необходимо похудеть!!!");
            }
            else if (i >= 35 && i <= 40)
            {
                Console.WriteLine("У Вас ожирение второй степени. Вам необходимо похудеть!!!");
            }
            else if (i > 40)
            {
                Console.WriteLine("У Вас ожирение третьей степени. Вам необходимо похудеть!!!");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Индекс массы тела cоответствие между массой человека и его ростом");
            Console.WriteLine("16 и менее  Дефицит массы");
            Console.WriteLine("16 - 18.5   Недостаточная масса тела");
            Console.WriteLine("18.5 - 25   Норма");
            Console.WriteLine("25  -  30   Избыточная масса тела");
            Console.WriteLine("30  -  35   Ожирение первой степени");
            Console.WriteLine("35  -  40   Ожирение второй степени");
            Console.WriteLine("40 и более  Ожирение третьей степени");

            Console.ReadLine();
        }
    }
}
