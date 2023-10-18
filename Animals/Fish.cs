using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
        }

        public Fish(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The fish named {Name} is moving");
        }
        public override sealed void Speak()
        {
            Console.WriteLine("Fishes can't speak");
        }
    }
}
