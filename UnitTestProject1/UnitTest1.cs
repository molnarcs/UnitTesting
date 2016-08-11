using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(420, calc.CalculateTotalPrice(10, 42));
        }

        [TestMethod]
        public void TestMethod2()
        {
            InternalCalculator intCalc = new InternalCalculator();
            Assert.AreEqual(10, intCalc.Add(3, 7));
        }

        [TestMethod]
        public void TestMethod3()
        {
            PrivateCalculator calc = new PrivateCalculator();
            PrivateObject obj = new PrivateObject(calc);
            var retVal = obj.Invoke("Multiplication", 2, 5);
            Assert.AreEqual(10, retVal);
        }
    }
}
