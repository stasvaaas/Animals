using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Eagle : Bird
    {
        public Eagle(string name) : base(name)
        {
        }

        public Eagle(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The eagle named {Name} is flying");
        }
        public override void Speak()
        {
            Console.WriteLine($"The eagle named {Name} is shrieking");
        }
    }
}
