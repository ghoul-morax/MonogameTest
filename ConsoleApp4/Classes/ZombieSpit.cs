using ConsoleApp4.Classes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Classes
{
    internal class ZombieSpit : Actor, IRun
    {
        public ZombieSpit(int x, int y, string name) : base(x, y, name) { }

        public int Speed { get; set; }

        public override void Info()
        {
            Console.WriteLine($"[ZOMBIE SPIT] Name: {name}, X:{x}, Y:{y}");
        }

        public void Run()
        {
            Console.WriteLine("[ZOMBIE SPIT] RUN!!!");
        }
    }
}
