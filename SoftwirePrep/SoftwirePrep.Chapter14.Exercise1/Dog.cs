// Copyright (c) 2013 Olly Levett

using System;

namespace SoftwirePrep.Chapter14.Exercise1
{
    public class Dog : Animal
    {
        /// <summary>
        /// Initialise a new cat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        public Dog(string name, float weight)
            : base(name, weight)
        {
        }

        /// <summary>
        /// Dogs bark
        /// </summary>
        public override void Speak()
        {
            Console.WriteLine("Bark");
        }

        /// <summary>
        /// Move the dog somewhere
        /// </summary>
        public override void Move()
        {
            Console.WriteLine("Dog moved");
        }

        /// <summary>
        /// ToString of a dog
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} weighs {2}", "Dog", Name, Weight);
        }
    }
}
