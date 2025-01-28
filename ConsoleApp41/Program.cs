using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    /// <summary>
    /// Родители ко дню рождения своего сына Андрея решили купить и обновить ему мобильный телефон. 
    /// Для этого они в первый месяц отложили 100 руб., 
    /// а в каждый последующий на 50 рублей больше. Какая сумма будет через десять месяцев?
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int d = 50;
            int totalMonths = 10;
            int currentMonth = 1;
            int totalSavings = 0;
            
            while (currentMonth <= totalMonths)
            {
                totalSavings += a + (currentMonth - 1) * d;
                currentMonth++;
            }
            Console.WriteLine($"Спустя 10 месяцев сумма стала = {totalSavings}");
            Console.ReadKey();
            
            
        }

    }
}
