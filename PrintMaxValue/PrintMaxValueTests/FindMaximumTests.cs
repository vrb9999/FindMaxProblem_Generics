using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrintMaxValue;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintMaxValue.Tests
{
    [TestClass()]
    public class FindMaximumTests
    {
        [TestMethod]
        public void Passing_Integer_Array_Should_Return_Maximum_Value()
        {
            int[] intArray = { 10, 20, 30 };
            int expected = 30;
            FindMaximum<int> find = new FindMaximum<int>(intArray);
            int actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Passing_float_Array_Should_Return_Maximum_Value()
        {
            float[] floatArray = { 10.5f, 20.5f, 30.5f };
            float expected = 30.5f;
            FindMaximum<float> find = new FindMaximum<float>(floatArray);
            float actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Passing_string_Array_Should_Return_Maximum_Value()
        {
            string[] strArray = { "10", "20", "30" };
            string expected = "30";
            FindMaximum<string> find = new FindMaximum<string>(strArray);
            string actual = find.FindMaxValue();
            Assert.AreEqual(expected, actual);
        }
    }
}