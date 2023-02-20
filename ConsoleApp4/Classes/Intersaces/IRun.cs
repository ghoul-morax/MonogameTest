using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Classes.Interfaces
{
    public interface IRun
    {
        int Speed { get; set; }
        void Run();
    }
}
