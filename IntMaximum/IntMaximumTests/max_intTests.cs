using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntMaximum;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntMaximum.Tests
{
    [TestClass()]
    public class max_intTests
    {
        [TestMethod()]
        public void MaximumTest1()
        {
            max_int max_int1 = new max_int();
            int result = max_int1.Maximum(6, 5, 4);
            Assert.AreEqual(6, result);

        }
        [TestMethod()]
        public void MaximumTest2()
        {
            max_int max_int2 = new max_int();
            int result1 = max_int2.Maximum(3, 7, 6);
            Assert.AreEqual(7, result1);
        }
        [TestMethod()]
        public void MaximumTest3()
        {
            max_int max_int3 = new max_int();
            int result2 = max_int3.Maximum(3, 7, 8);
            Assert.AreEqual(8, result2);
        }
    }
}