using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> numbers = new List<int>() { 20, 2, 45, 33, 87, 89, 26, 88 };

            int expectedResult = 89 + 88;

            int sumOfTwoHighest = Numbers.SumOfTwoHighestNumbers(numbers);

            Assert.AreEqual(expectedResult, sumOfTwoHighest);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> numbers = new List<int>() { 15, 15, 10, 18, 22, 19, 21, 22 };

            int expectedResult = 22 + 22;

            int sumOfTwoHighest = Numbers.SumOfTwoHighestNumbers(numbers);

            Assert.AreEqual(expectedResult, sumOfTwoHighest);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> numbers = new List<int>() { 0, 20, 15, 10, 14, 19, 18, 4, 21 };

            int expectedResult = 20 + 21;

            int sumOfTwoHighest = Numbers.SumOfTwoHighestNumbers(numbers);

            Assert.AreEqual(expectedResult, sumOfTwoHighest);
        }
    }
}
