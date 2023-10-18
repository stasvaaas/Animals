using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Animal
    {
        public string Name { get; }
        public int Age { get; }
        public Animal(string name)
        {
            Name = name;
        }
        public Animal(string name, int age) 
        {
            Name = name;
            Age = age;

        }

        public virtual void Move()
        {
            Console.WriteLine($"The animal named {Name} is moving");
        }
        public virtual void Speak()
        {
            Console.WriteLine($"The animal named {Name} is speaking");
        }
    }
}
