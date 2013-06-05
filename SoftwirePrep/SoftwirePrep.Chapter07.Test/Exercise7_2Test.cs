// Copyright (c) 2013 Olly Levett

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwirePrep.Exercises;
using System;

namespace SoftwirePrep.Tests
{
    [TestClass]
    public class Exercise7_2Test
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
            Assert.AreEqual(expected, Exercise7_2.Add(x, y));
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
            Assert.AreEqual(expected, Exercise7_2.Subtract(x, y));
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
            Assert.AreEqual(expected, Exercise7_2.Multiply(x, y));
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
            Assert.AreEqual(expected, Exercise7_2.Divide(x, y));
        }

        [TestMethod]
        [TestCategory("Chapter 7")]
        public void DivideByZeroTest()
        {
            int x = 12;
            int y = 0;
            try
            {
                Exercise7_2.Divide(x, y);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, "Cannot divide by 0");
                return;
            }
            Assert.Fail("No exception was thrown");
        }
    }
}
