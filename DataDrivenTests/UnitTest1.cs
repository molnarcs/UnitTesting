using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;
using System.Diagnostics;

namespace DataDrivenTests
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV","|DataDirectory|\\Data.csv","Data#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void CalculateTotalPriceTest()
        {
            Calculator calc = new Calculator();
            decimal price = 0m;
            decimal quantity = 0m;
            decimal expected = Convert.ToDecimal(testContextInstance.DataRow["ExpectedTotalPrice"]);
            decimal actual;
            actual = calc.CalculateTotalPrice(Convert.ToDecimal(testContextInstance.DataRow["UnitPrice"]), Convert.ToDecimal(testContextInstance.DataRow["Quantity"]));

            Assert.AreEqual(expected, actual, "A várt érték {0}, de az aktuális {1}", expected, actual);
            Trace.WriteLine("Expected: " + expected + " Actual: " + actual);
        }
    }
}
