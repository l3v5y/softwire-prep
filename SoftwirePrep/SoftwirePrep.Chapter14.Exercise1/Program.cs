using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwirePrep.Chapter14.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Dog("Alice", 23);
            animals[1] = new Cat("Bob", 12);
            animals[2] = new Cat("Eve", 5);

            foreach (Animal a in animals)
            {
                Console.WriteLine("Messing with: {0}", a.ToString());
                a.Speak();
                a.Move();
            }
        }
    }
}
