using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Classes;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Actor> actors = new List<Actor>()
            {
                new Zombie(0,0, "Zombie_Sonya"),
                new Zombie(0,0, "Zombie_Anton"),
                new ZombieRunner(0,0, "ZombieRunner_Vlad"),
                new ZombieSpit(0,0, "ZombieSpit_Boris")
            };

            foreach(var actor in actors)
            {
                actor.Info();
            }

            Console.ReadLine();
        }

    }
}
