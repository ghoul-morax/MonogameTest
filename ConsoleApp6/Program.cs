using ConsoleApp6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Classes;


namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentConditionsDisplay display = new CurrentConditionsDisplay();
            StatisticsDisplay statisticsdisplay = new StatisticsDisplay();
            PressureDisplay pressureDisplay= new PressureDisplay();
            WeatherData data = new WeatherData();
            data.RegisterObserver(display);
            data.RegisterObserver(statisticsdisplay);
            data.RegisterObserver(pressureDisplay);
            data.NotifyObserver();
            Console.ReadLine();

        }
    }
}
