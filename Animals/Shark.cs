using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Shark : Fish
    {
        public Shark(string name) : base(name)
        {
        }

        public Shark(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The shark named {Name} is moving");
        }
    }
}
