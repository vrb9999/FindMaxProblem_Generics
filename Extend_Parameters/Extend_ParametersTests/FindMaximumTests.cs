using Microsoft.VisualStudio.TestTools.UnitTesting;
using Extend_Parameters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Extend_Parameters.Tests
{
    [TestClass]
    public class FindMaximumTest
    {
        [TestMethod]
        public void GivenIntegerArray_ShouldReturnLargestInteger()
        {
            int[] values = { 3, 6, 7, 10, 4, 8 };
            FindMaximum<int> maximumNumber = new FindMaximum<int>(values);
            int max = maximumNumber.FindMaxValue();
            Assert.AreEqual(10, max);
        }

        [TestMethod]
        public void GivenDoubleArray_ShouldReturnLargestDouble()
        {
            double[] values = { 10.6, 25.9, 8.2, 9.56, 20.8, 6.9, 21.5 };
            FindMaximum<double> maximumNumber = new FindMaximum<double>(values);
            double max = maximumNumber.FindMaxValue();
            Assert.AreEqual(25.9, max);
        }

        [TestMethod]
        public void GivenStringArrayShouldReturnLargestString()
        {
            string[] values = { "222", "498", "999", "333", "777", "888" };
            FindMaximum<string> maximumNumber = new FindMaximum<string>(values);
            string max = maximumNumber.FindMaxValue();
            Assert.AreEqual("999", max);
        }
    }
}