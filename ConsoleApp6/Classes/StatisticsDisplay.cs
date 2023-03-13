using ConsoleApp6.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    internal class StatisticsDisplay : IObserver
    {
        public void Update(float temp, float pressure)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"[StatisticsDisplay] temperature: {temp} pressure: {pressure}");
            Console.ResetColor();
        }
    }
}
