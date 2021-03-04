using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Lion : Animal
    {
        public Lion(string species, string name, int age, int legs)
        {
            Species = species;
            Name = name;
            Age = age;
            Legs = legs;
        }

        public void Run()
        {
            Console.WriteLine(" I can run");
        }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
