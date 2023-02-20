using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Classes
{
    public abstract class Actor
    {
        protected int x;
        protected int y;
        protected string name;

        public Actor(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public abstract void Info();

    }
}
