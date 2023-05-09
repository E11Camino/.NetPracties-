using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_practies_1
{
    internal class Dog
    {
        public string Breed { get; set; }
        public string Color { get; set; }
        public double Age { get; set; }
        public string Sex { get; set; }

        public Dog()
        {
        }

        public void DogInfo()
        {
            Console.WriteLine($"Dog breed {Breed}");
            Console.WriteLine($"Dog color {Color}");
            Console.WriteLine($"Dog Age {Age}");
            Console.WriteLine($"Dog Sex {Sex}");
        }

        public void DogSays()
        {
            Console.WriteLine("Bark! Bark! Bark! Rrrruuu");
        }
    }
    
}
