using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionMath2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddition()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction("1/4");
            Fraction f3 = f1 + f2;
            Assert.AreEqual(f3.ToString(), "3/4");
        }

        [TestMethod]
        public void TestComparitive()
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction("1/4");
           
            Assert.IsTrue(f1>f2);
        }

    }


}
