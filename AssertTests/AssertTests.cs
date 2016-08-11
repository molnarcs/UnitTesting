using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLibrary;
using System.Collections.Generic;

namespace AssertTests
{
    [TestClass]
    public class AssertTests
    {
        [TestMethod]
        public void CalculateTotalPriceTest()
        {
            Calculator calc = new Calculator();
            decimal price = 0m;
            decimal quantity = 0m;
            decimal expected = 1m;
            decimal actual;
            actual = calc.CalculateTotalPrice(price, quantity);
            Assert.Inconclusive("Ellenőrizd, hogy jól működik-e!");
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void AreEqualTests()
        {
            string expected = "Valami";
            string actual = "valami";

            Assert.AreEqual(expected, actual, false, "Az elvárt ({0}) és a megadott ({1}) érték nem egyezik!", expected, actual);

            Assert.AreEqual<int>(2, 1 + 1);            
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string expected = "Valami";
            string actual = "valami";

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void AreSameTest()
        {
            List<string> firstLst = new List<string>(3);
            List<string> secondLst = firstLst;
            Assert.AreSame(firstLst, secondLst);

        }

        [TestMethod]
        public void AreNotSameTest()
        {
            List<string> firstLst = new List<string>(3);
            List<string> secondLst = new List<string>();
            Assert.AreNotSame(firstLst, secondLst, "A két objektum megegyezik!");
        }

        [TestMethod]
        public void FailTest()
        {
            try
            {
                throw new Exception("Hiba!");
            }
            catch (Exception ex)
            {
                Assert.Fail("Hiba történt!\nMessage: {0}", ex.Message);
            }
        }

        [TestMethod]
        public void InconclusiveTest()
        {
            Assert.Inconclusive("Ez a metódus még nincs kész a tesztelésre.");
        }

        [TestMethod]
        public void IsTrueTest()
        {
            Assert.IsTrue(5 == 2 + 3, "A feltétel hamis!");
        }

        [TestMethod]
        public void IsFalseTest()
        {
            Assert.IsFalse(2 + 3 == 5, "A feltétel igaz!");
        }

        [TestMethod]
        public void IsNullTest()
        {
            object obj1 = new object();
            object obj2 = null;

            Assert.IsNull(obj2, "Az {0} objektum inicializálva van!", "obj2");
            Assert.IsNull(obj1, "Az {0} objektum inicializálva van!", "obj1");           
        }

        [TestMethod]
        public void IsNotNullTest()
        {
            object obj1 = new object();
            object obj2 = null;

            Assert.IsNotNull(obj1, "Az {0} objektum nincs inicializálva!", "obj1");
            Assert.IsNotNull(obj2, "Az {0} objektum nincs inicializálva!", "obj2");            
        }

        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            IEnumerable<int> obj = new List<int>();

            Assert.IsInstanceOfType(obj, typeof(List<int>), "Az {0} objektum nem {1} típusú!", "obj", "List<int>");
        }
    }
}
