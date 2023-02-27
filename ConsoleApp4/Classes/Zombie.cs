using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Classes
{
    public class ZombieSimple : Actor
    {
        public ZombieSimple(int x, int y, string name) : base(x, y, name) { }
        public override void Info()
        {
            Console.WriteLine($"[ZOMBIE] Name: {name}, X:{x}, Y:{y}");
        }
    }
}
