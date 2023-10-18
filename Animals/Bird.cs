using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The bird named {Name} is flying");
        }
        public override void Speak()
        {
            Console.WriteLine($"The bird named {Name} is tweeting");
        }
    }
}
