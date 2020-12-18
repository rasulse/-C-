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
        *  Домашнее задание №3:
        *  Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        *  Регистр можно не учитывать:
        *  а) с использованием методов C#;
        *  б) *разработав собственный алгоритм.
        *  Например: badc являются перестановкой abcd.*/

        static void Main(string[] args)
        {
            string stroka1 = "sert";
            string stroka2 = "estr";
            string stroka3 = "TrSE";

            Console.WriteLine($"Является ли строка \"{stroka1}\" перестановкой строки \"{stroka2}\" ? - {IsTransposition(stroka1, stroka2)}");
            Console.WriteLine();
            Console.WriteLine($"Является ли строка \"{stroka1}\" перестановкой строки \"{stroka3}\" ? - {IsTranspositionM(stroka1, stroka3)}");
            Console.ReadKey();
        }

        static bool IsTransposition(string strokaA, string strokaB)
        {
            if (strokaA == null || strokaB == null)
                return false;
            else if (strokaA == "" || strokaB == "")
                return false;
            else if (strokaA.Length != strokaB.Length)
                return false;
            else
            {
                for (int i = 0; i < strokaB.Length; i++)
                {
                    if (strokaA.IndexOf(strokaB[i]) == -1)
                        return false;
                }
            }
            return true;
        }
        
        static bool IsTranspositionM(string strokaA, string strokaB)
        {
            if (strokaA == null || strokaB == null)
                return false;
            else if (strokaA == "" || strokaB == "")
                return false;
            else if (strokaA.Length != strokaB.Length)
                return false;
            else
            {
                if (Sort(strokaA) != Sort(strokaB))
                    return false;
            }
            return true;
        }

        static string Sort(string stroka)
        {
            stroka = stroka.ToLower();
            char[] charArray = stroka.ToCharArray();
            stroka = "";
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < charArray.Length - 1; j++)
                {
                    if (charArray[j] > charArray[j + 1])
                        Swap(ref charArray[j], ref charArray[j + 1]);
                }
            }

            for (int i = 0; i < charArray.Length; i++)
                stroka += charArray[i].ToString();
            return stroka;
        }

        static void Swap(ref char first, ref char second)
        {
            first ^= second;
            second ^= first;
            first ^= second;
        }
    }
}
