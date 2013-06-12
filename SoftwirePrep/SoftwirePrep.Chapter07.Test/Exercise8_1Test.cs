// Copyright (c) 2013 Olly Levett
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SoftwirePrep.Tests
{
    [TestClass]
    public class Exercise8_1Test
    {
        [TestMethod]
        [TestCategory("Chapter 8")]
        public void TestFloat()
        {
            float input = 4;
            float expected = 12;
            Assert.AreEqual(expected, Exercises.Exercise8_1.Triple(input));
        }

        [TestMethod]
        [TestCategory("Chapter 8")]
        public void TestInt()
        {
            int input = 4;
            int expected = 12;
            Assert.AreEqual(expected, Exercises.Exercise8_1.Triple(input));
        }
    }
}
