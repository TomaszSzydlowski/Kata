using System;
using System.Collections.Generic;
using CodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeKataTests
{
    [TestClass]
    public class SumTwoSmallestNumbersTests
    {
        private SumTwoSmallestNumbers mockup = new SumTwoSmallestNumbers();
        private int BigArraySize = 10000000;

        [TestMethod]
        public void SmallArrayExampleOne()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, mockup.ExampleOne(numbers));
        }

        [TestMethod]
        public void SmallArrayExampleTwo()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, mockup.ExampleTwo(numbers));
        }

        [TestMethod]
        public void BigArrayExampleOne()
        {
            List<int> intList = new List<int>();

            for (int i = 10; i < BigArraySize; i++)
            {
                intList.Add(i);
            }

            Assert.AreEqual(21, mockup.ExampleOne(intList.ToArray()));
        }

        [TestMethod]
        public void BigArrayExampleTwo()
        {
            List<int> intList = new List<int>();

            for (int i = 10; i < BigArraySize; i++)
            {
                intList.Add(i);
            }

            Assert.AreEqual(21, mockup.ExampleTwo(intList.ToArray()));
        }
    }
}
