// Copyright (c) 2013 Olly Levett

using System;

namespace SoftwirePrep.Chapter14.Exercise1
{
    public class Cat : Animal
    {
        public Cat(string name, float weight)
            : base(name, weight)
        { 
        }

        public override void Speak()
        {
            Console.WriteLine("Meow");
        }

        public override void Move()
        {
            Console.WriteLine("Cat moved");
        }

        public override string ToString()
        {
            return string.Format("{0} {1} weighs {2}", "Cat", Name, Weight);
        }
    }
}
