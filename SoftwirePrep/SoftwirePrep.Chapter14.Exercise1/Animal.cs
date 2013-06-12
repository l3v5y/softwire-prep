// Copyright (c) 2013 Olly Levett

namespace SoftwirePrep.Chapter14.Exercise1
{
    public abstract class Animal
    {
        /// <summary>
        /// Weight of the animal
        /// </summary>
        public float Weight
        {
            get;
            private set;
        }

        /// <summary>
        /// Name of the animal
        /// </summary>
        public string Name
        {
            get;
            private set;
        }

        /// <summary>
        /// Create a new animal
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        public Animal(string name, float weight)
        {
            Weight = weight;
            Name =  name;
        }

        /// <summary>
        /// Speak
        /// </summary>
        public abstract void Speak();

        /// <summary>
        /// Move
        /// </summary>
        public abstract void Move();

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public new abstract string ToString();
    }
}
