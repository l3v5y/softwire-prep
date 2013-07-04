// Copyright (c) 2013 Olly Levett

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwirePrep.Exercises;
using System;

namespace SoftwirePrep.Tests
{
    /// <summary>
    /// Tests for Excercise7_1
    /// </summary>
    [TestClass] 
    public class Exercise7_1Test
    {
        /// <summary>
        /// Test method for addition
        /// </summary>
        [TestMethod]
        [TestCategory("Chapter 7")]
        public void AddTest()
        {
            int x = 12;
            int y = 4;
            int expected = 16;
            Exercise7_1 calculator = new Exercise7_1();
            Assert.AreEqual(expected, calculator.Add(x, y));
        }

        /// <summary>
        /// Test method for subtraction
        /// </summary>
        [TestMethod]
        [TestCategory("Chapter 7")]
        public void SubtractTest()
        {
            int x = 12;
            int y = 4;
            int expected = 8;
            Exercise7_1 calculator = new Exercise7_1();
            Assert.AreEqual(expected, calculator.Subtract(x, y));
        }

        /// <summary>
        /// Test method for multiplication
        /// </summary>
        [TestMethod]
        [TestCategory("Chapter 7")]
        public void MultiplyTest()
        {
            int x = 3;
            int y = 4;
            int expected = 12;
            Exercise7_1 calculator = new Exercise7_1();
            Assert.AreEqual(expected, calculator.Multiply(x, y));
        }

        /// <summary>
        /// Test method for division
        /// </summary>
        [TestMethod]
        [TestCategory("Chapter 7")]
        public void DivideTest()
        {
            int x = 12;
            int y = 4;
            int expected = 3;
            Exercise7_1 calculator = new Exercise7_1();
            Assert.AreEqual(expected, calculator.Divide(x, y));
        }

        [TestMethod]
        [TestCategory("Chapter 7")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTest()
        {
            int x = 12;
            int y = 0;
            Exercise7_1 calculator = new Exercise7_1();
            calculator.Divide(x, y);
        }
    }
}
