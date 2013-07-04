// Copyright (c) 2013 Olly Levett
using System;

namespace SoftwirePrep.Exercises
{
    /// <summary>
    /// Excercise 7.1 class, a basica calculator
    /// </summary>
    public class Exercise7_1
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public float Divide(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("denominator");
            }
            return numerator / denominator;
        }
    }
}
