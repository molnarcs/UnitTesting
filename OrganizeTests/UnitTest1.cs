using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OrganizeTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Priority(1)]
        [Owner("MCS")]
        [TestCategory("First")]
        public void TestMethod1()
        {
            Assert.Fail();
        }

        [TestMethod]
        [Priority(2)]
        [TestCategory("First")]
        public void TestMethod2()
        {
        }

        [TestMethod]
        [Priority(1)]
        [TestCategory("Second category")]
        public void TestMethod3()
        {
            Assert.Fail();
        }

        [TestMethod]
        [Priority(2)]
        [Owner("MCS")]
        [TestCategory("Second category")]
        public void TestMethod4()
        {
        }

        [TestProperty("Time", "Long")]
        [TestMethod]
        public void TestMethod5()
        {
        }

        [TestProperty("Time", "Long")]
        [TestMethod]
        public void TestMethod6()
        {
        }

        [TestProperty("Time", "Fast")]
        [TestMethod]
        public void TestMethod7()
        {
        }
    }
}
