using System;

namespace Assignment_13_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] Zoo = new Animal[3];
            Zoo[0] = new Lion("Lion", "Simba", 2, 3);
            Zoo[1] = new Fish("Blue Tang", "Dory", 2, 5);
            Zoo[2] = new Eagle("Bald Eagle", "Beep", 2, 2);

            Lion Leo = (Lion)Zoo[0];


            for(int i = 0; i < Zoo.Length; i++)
            {
                Zoo[i].Speak();
            }
        }
    }
}
