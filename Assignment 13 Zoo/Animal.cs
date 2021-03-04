using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Zoo
{
    class Animal
    {
        protected string Species;
        protected string Name;
        protected int Age;
        protected int Legs;

        public string GetName()
        {
            return Name;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public int GetAge()
        {
            return Age;
        }

        public virtual void Speak()
        {
        }


    }
}
