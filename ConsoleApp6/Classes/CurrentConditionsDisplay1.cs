using ConsoleApp6.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    public class CurrentConditionsDisplay : IObserver
    {
        

        public void Update(float temp, float pressure)
        {
            Console.WriteLine($"[CurrentConditionsDisplay] temperature: {temp} pressure: {pressure}");
        }

        
    }
}
