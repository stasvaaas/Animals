using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Owl : Bird
    {
        public Owl(string name) : base(name)
        {
        }

        public Owl(string name, int age) : base(name, age)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"The owl named {Name} is flying");
        }
        public override void Speak()
        {
            Console.WriteLine($"The owl named {Name} is coosing");
        }
    }
}
