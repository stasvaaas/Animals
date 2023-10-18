using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Mammal
    {
        public Dog(string name) : base(name)
        {
        }

        public Dog(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The dog named {Name} is moving");
        }
        public override void Speak()
        {
            Console.WriteLine($"The dog named {Name} is barking");
        }
    }
}
