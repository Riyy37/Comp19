using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    /// <summary>
    /// Составьте программу вычисления суммы 150 первых членов арифметической прогрессии, 
    /// если a1= –200; d = 0,2.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = -200; 
            double d = 0.2;  
            int n = 150;      
            double sum = 0;   
            int count = 0;        
            
            while (count < n)
            {
                double currentTerm = a1 + count * d; 
                sum += currentTerm;             
                count++;                           
            }

            Console.WriteLine("Сумма 150 первых членов арифметической прогрессии: " + sum);
            Console.ReadKey();
        }
    }
}
