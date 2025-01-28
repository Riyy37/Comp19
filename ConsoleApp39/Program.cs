using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    /// <summary>
    /// Задача 1. Вывести первые пять членов арифметической прогрессии (с использованием цикла), 
    /// если a1=1, d=4 (например, 1  5  9  13  17).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int d = 4;
            int count = 1;
            
            while(count <= 5)
            {
                Console.WriteLine(a);
                
                a += d; //a=a+4
                count++;
            }
            
            Console.ReadKey();
        }
    }
}
