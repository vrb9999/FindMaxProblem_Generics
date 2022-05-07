using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMaximum;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringMaximum.Tests
{
    [TestClass()]
    public class max_stringTests
    {
        [TestMethod()]
        public void MaximumstringTest1()
        {
            max_string max_string1 = new max_string();
            string result = max_string1.Maximum("Peach", "Apple", "Banana");
            Assert.AreEqual("Peach", result);

        }
        [TestMethod()]
        public void MaximumstringTest2()
        {
            max_string max_string2 = new max_string();
            string result = max_string2.Maximum("Apple", "Peach", "Banana");
            Assert.AreEqual("Peach", result);
        }
        [TestMethod()]
        public void MaximumstringTest3()
        {
            max_string max_string3 = new max_string();
            string result = max_string3.Maximum("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", result);
        }
    }
}