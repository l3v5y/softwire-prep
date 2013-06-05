// Copyright (c) 2013 Olly Levett

using System;

namespace SoftwirePrep.Exercises
{
    /// <summary>
    /// Excercise 7.2 class, a basic calculator
    /// </summary>
    public class Exercise7_2
    {
        /// <summary>
        /// Returns the sum of x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Add(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// Subtracts y from x
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Subtract(int x, int y)
        {
            return x - y;
        }

        /// <summary>
        /// Multiplies x by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        /// <summary>
        /// Divides x by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by 0");
            }
            return x / y;
        }
    }
}
