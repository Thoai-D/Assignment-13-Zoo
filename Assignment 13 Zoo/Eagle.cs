using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Eagle : Animal
    {
        public Eagle(string species, string name, int age, int legs)
        {
            Species = species;
            Name = name;
            Age = age;
            Legs = legs;
        }

        public void Fly()
        {
            Console.WriteLine(GetName() + " I can fly");
        }

        public override void Speak()
        {
            Console.WriteLine("Squack");
        }
    }
}
