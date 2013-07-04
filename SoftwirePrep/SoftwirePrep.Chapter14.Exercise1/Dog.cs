// Copyright (c) 2013 Olly Levett

using System;

namespace SoftwirePrep.Chapter14.Exercise1
{
    public class Dog : Animal
    {
        public Dog(string name, float weight)
            : base(name, weight)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Bark");
        }

        public override void Move()
        {
            Console.WriteLine("Dog moved");
        }

        public override string ToString()
        {
            return string.Format("{0} {1} weighs {2}", "Dog", Name, Weight);
        }
    }
}
