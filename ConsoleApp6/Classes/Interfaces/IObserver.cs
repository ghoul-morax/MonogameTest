using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes.Interfaces
{
    public interface IObserver
    {
        
        void Update(float temp, float pressure);
    }
}
