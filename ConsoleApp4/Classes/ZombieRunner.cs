using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Classes.Interfaces;
using ConsoleApp4.Classes.Intersaces;

namespace ConsoleApp4.Classes
{
    internal class ZombieRunner:Actor, IRun, ISwim
    {
        public ZombieRunner(int x, int y, string name) : base(x, y, name) { }

        public int Speed { get; set; }

        public override void Info()
        {
            Console.WriteLine($"[ZOMBIE RUNNER] Name: {name}, X:{x}, Y:{y}");
        }

        public void Run()
        {
            Console.WriteLine("[ZOMBIE RUNNER] RUNNING!");
        }

        public void Swim()
        {
            Console.WriteLine("[ZOMBIE RUNNER] Swim");
        }
    }
}
