using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Mammal : Animal
    {
        public Mammal(string name) : base(name)
        {
        }
        public Mammal(string name, int age): base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The mammal named {Name} is moving");
        }
        public override void Speak()
        {
            Console.WriteLine($"The mammal named {Name} is speaking");
        }
    }
}
