using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Fish : Animal
    {
        public Fish(string species, string name, int age, int legs)
        {
            Species = species;
            Name = name;
            Age = age;
            Legs = legs;
        }

        public void Swim()
        {
            Console.WriteLine(GetName() + " I can swim");
        }

        public override void Speak()
        {
            Console.WriteLine("Glub Glub");
        }
    }
}
