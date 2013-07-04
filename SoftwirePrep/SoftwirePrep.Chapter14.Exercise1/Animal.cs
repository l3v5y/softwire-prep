// Copyright (c) 2013 Olly Levett

namespace SoftwirePrep.Chapter14.Exercise1
{
    public abstract class Animal
    {
        protected float Weight
        {
            get;
            private set;
        }

        protected string Name
        {
            get;
            private set;
        }

        public Animal(string name, float weight)
        {
            Weight = weight;
            Name =  name;
        }

        public abstract void Speak();

        public abstract void Move();

        public new abstract string ToString();
    }
}
