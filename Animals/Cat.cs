using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Mammal
    {
        public Cat(string name) : base(name)
        {
        }

        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The cat named {Name} is moving");
        }
        public override void Speak()
        {
            Console.WriteLine($"The cat named {Name} is meowing");
        }
    }
}
