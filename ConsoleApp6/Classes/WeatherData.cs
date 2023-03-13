using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ConsoleApp6.Classes.Interfaces;
using System.CodeDom.Compiler;

namespace ConsoleApp6.Classes
{
    internal class WeatherData : ISubject
    {
        private float temp = 0;
        private float pressure = 0;
        private List<IObserver> observers = new List<IObserver>();
        public WeatherData()
        {
            Thread thread = new Thread(Start);
            thread.Start();
        }
        private void Start()
        {

            while(true)
            {
                Random random = new Random();
                int time = random.Next(500, 2000);
                Thread.Sleep(time);
                temp = random.Next(10, 21);
                pressure = random.Next(740, 751);
                NotifyObserver();
            }
        }
        public void NotifyObserver()
        {
            foreach (IObserver observer in observers) 
            {
                observer.Update(temp, pressure);
                
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        
    }
}
