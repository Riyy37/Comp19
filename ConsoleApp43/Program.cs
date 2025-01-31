using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    /// <summary>
    /// Начав тренировки, лыжник в первый день пробежал 10 км. Каждый следующий день он увеличивал пробег на 10% от пробега предыдущего дня. Определить:
    /// а) в какой день он пробежит больше 20 км;
    /// б) в какой день суммарный пробег за все дни превысит 100 км.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = 10;
            double d = 0.1;
            double a20 = a1;
            double sum = a1;
            int day = 1;

            while (a20 <= 20)
            {
                a20 += a20 * d;
                day++;
            }

            Console.WriteLine($"А) На {day}-й день лыжник пробежит больше 20 км");

            a20 = a1;
            sum = a1;
            day = 1;

            while (sum <= 100)
            {
                a20 += a20 * d;
                sum += a20;
                day++;
            }

            Console.WriteLine($"Б) Суммарный прлбег лыжника составит более 100 км на {day}-й день");
            Console.ReadKey();
        }
    }
}
