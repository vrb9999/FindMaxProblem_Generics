using Microsoft.VisualStudio.TestTools.UnitTesting;
using FloatMaximum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FloatMaximum.Tests
{
    [TestClass()]
    public class max_floatTests
    {
        [TestMethod()]
        public void MaximumfloatTest1()
        {
            max_float max_float1 = new max_float();
            double result = max_float1.Maximumfloat(6.6, 5.5, 4.4);
            Assert.AreEqual(6.6, result);

        }
        [TestMethod()]
        public void MaximumfloatTest2()
        {
            max_float max_float2 = new max_float();
            double result1 = max_float2.Maximumfloat(3.3, 7.7, 6.6);
            Assert.AreEqual(7.7, result1);
        }
        [TestMethod()]
        public void MaximumfloatTest3()
        {
            max_float max_float3 = new max_float();
            double result2 = max_float3.Maximumfloat(3.3, 7.7, 8.8);
            Assert.AreEqual(8.8, result2);
        }
    }
}