using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AssertTests
{
    [TestClass]
    public class CollectionAssertTests
    {
        private List<string> firstList;
        private List<string> secondList;
        private List<string> thirdList;
        private List<string> fourthList;

        [TestInitialize]
        public void VariableInit()
        {
            firstList = new List<string>(3);
            firstList.Add("FirstName");
            firstList.Add("LastName");

            secondList = new List<string>(3);
            secondList = firstList;
            secondList.Add("MiddleName");

            thirdList = new List<string>(3);
            thirdList.Add("FirstName");
            thirdList.Add("MiddleName");
            thirdList.Add("LastName");

            fourthList = new List<string>(3);
            fourthList.Add("FirstName");
            fourthList.Add("MiddleName");
        }

        [TestMethod]
        public void AllItemsAreNotNullTest()
        {
            //CollectionAssert.AllItemsAreNotNull(firstList, "Van null elem!");

            firstList.Add("a");

            CollectionAssert.AllItemsAreNotNull(firstList, "Van már null elem!");
        }

        [TestMethod]
        public void AreEquivalentTest()
        {
            CollectionAssert.AreEquivalent(thirdList, secondList);
        }

        [TestMethod]
        public void AreNotEquivalentTest()
        {
            //CollectionAssert.AreNotEquivalent(thirdList, secondList);

            thirdList.Remove("MiddleName");
            thirdList.Add("FullName");

            CollectionAssert.AreNotEquivalent(thirdList, secondList);
        }

        [TestMethod]
        public void AllItemsAreInstancesOfTypeTest()
        {
            CollectionAssert.AllItemsAreInstancesOfType(thirdList, typeof(string));
        }

        [TestMethod]
        public void IsSubsetOfTest()
        {
            CollectionAssert.IsSubsetOf(fourthList, thirdList);
            CollectionAssert.IsSubsetOf(thirdList, fourthList);
        }

        [TestMethod]
        public void IsNotSubsetOfTest()
        {
            //CollectionAssert.IsNotSubsetOf(fourthList, thirdList);

            fourthList.Add("FullName");
            CollectionAssert.IsNotSubsetOf(fourthList, thirdList);
        }

        [TestMethod]
        public void AllItemsAreUniqueTest()
        {
            CollectionAssert.AllItemsAreUnique(firstList);

            firstList.Add("LastName");

            CollectionAssert.AllItemsAreUnique(firstList);
        }

        [TestMethod]
        public void ContainsTest()
        {
            CollectionAssert.Contains(fourthList, "FirstName");
        }

        [TestMethod]
        public void DoesNotContainTest()
        {
            CollectionAssert.DoesNotContain(fourthList, "FirstName");
        }

        [TestMethod]
        public void AreEqualTest()
        {
            CollectionAssert.AreEqual(firstList, secondList);
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            CollectionAssert.AreNotEqual(secondList, thirdList);
        }
    }
}
