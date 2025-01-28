using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    /// <summary>
    /// Вывести первые пять членов арифметической прогрессии (с использованием цикла) и найти их общую сумму,
    /// если a1=1, d=4 (например, 1 5 9 13 17, sum=45).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int d = 4;
            int count = 1;
            int sum = 0; 
            while (count <= 5)
            {
                Console.WriteLine(a);
                sum += a; 
                a += d; 
                count++;
            }
            Console.WriteLine($"sum = {sum}"); 
            Console.ReadKey();
        }
    }
}
