using Microsoft.VisualStudio.TestTools.UnitTesting;
using R2_Generic_Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace R2_Generic_Class.Tests
{
    [TestClass()]
    public class GenericClassTests
    {
        [TestMethod()]
        public void MaxusingGenericsTest()
        {
            int value = GenericClass.MaxusingGenerics<int>(4, 3, 2);
            Assert.AreEqual(4, value);
        }
        [TestMethod()]
        public void MaxusingGenericsTest1()
        {
            double value = GenericClass.MaxusingGenerics<double>(4.4, 5.5, 6.6);
            Assert.AreEqual(6.6, value);
        }
        [TestMethod()]
        public void MaxusingGenericsTest2()
        {
            string value = GenericClass.MaxusingGenerics<string>("Animal", "Banana", "Apple");
            Assert.AreEqual("Banana", value);
        }
    }
}