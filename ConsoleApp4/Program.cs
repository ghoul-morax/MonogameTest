using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Classes;
using ConsoleApp4.Classes.Interfaces;
using ConsoleApp4.Classes.Intersaces;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Actor> actors = new List<Actor>()
            {
                new ZombieSimple(0,0, "Zombie_Sonya"),
                new ZombieSimple(0,0, "Zombie_Anton"),
                new ZombieRunner(0,0, "ZombieRunner_Vlad"),
                new ZombieSpit(0,0, "ZombieSpit_Boris")
            };

            foreach(var actor in actors)
            {
                actor.Info();
            }
            List<IRun> runs = new List<IRun>();
            foreach(var actor in actors) { 
                if (actor is IRun)
                {
                    runs.Add(actor as IRun);
                }
            }
            foreach(var actor in runs)
            {
                actor.Run();
            }
            List<ISwim> actorsSwim = new List<ISwim>();
            foreach(var item in actors) 
            {
                if (item is ISwim)
                {
                    actorsSwim.Add(item as ISwim);
                }
            }
            foreach(var actor in actorsSwim) { actor.Swim(); }

            Console.ReadLine();
        }
        static void MyAction(List<Actor> actors)
        {
            foreach(var actor in actors)
            {
                if (actor is IRun)
                {
                    (actor as IRun).Run();
                }
            }
        }

    }
}
