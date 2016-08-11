using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using TestLibrary;

namespace AssertTests.Exceptions
{
    [TestClass]
    public class UnitTestExceptions
    {
        [TestMethod]
        public void AssertFailedExceptionTest()
        {
            try
            {
                Assert.Fail();
            }
            catch (AssertFailedException ex)
            {
                //Debug this line and see the output
                Trace.WriteLine(ex.Message);               
            }
        }

        [TestMethod]
        //[ExpectedException(typeof(CalculatorException))]
        public void GetTotalItemPriceTest()
        {
            Calculator calc = new Calculator();

            decimal price = 10m;
            decimal quantiy = 1m;
            decimal expected = 0;
            decimal actual = calc.CalculateTotalPrice(price, quantiy);

            Assert.AreEqual(expected, actual);
        }
    }
}
