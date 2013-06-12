// Copyright (c) 2013 Olly Levett

using System;

namespace SoftwirePrep.Chapter14.Exercise1
{
    public class Cat : Animal
    {
        /// <summary>
        /// Initialise a new cat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        public Cat(string name, float weight)
            : base(name, weight)
        { 
        }

        /// <summary>
        /// Cats meow
        /// </summary>
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }

        /// <summary>
        /// Move the cat somewhere
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Cat moved");
        }

        /// <summary>
        /// ToString of a cat
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} weighs {2}", "Cat", Name, Weight);
        }
    }
}
