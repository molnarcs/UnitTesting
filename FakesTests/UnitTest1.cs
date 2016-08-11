using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakesTestLibrary;
using Microsoft.QualityTools.Testing.Fakes;

namespace FakesTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //TotalPrice tp = new TotalPrice();
            //var result = tp.UpdateTotalPrice(2);

            //Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestUpdateTotalPrice()
        {
            decimal unitPrice = 10.5m;
            decimal totalPrice = 0.0m;

            IRepository repository = new FakesTestLibrary.Fakes.StubIRepository()
            {
                GetTotalPrice = () =>
                {
                    return totalPrice;
                },
                UpdateTotalPriceInt32 = value =>
                {
                    totalPrice = unitPrice * value;
                }
            };

            ITotalPrice totPrice = new TotalPrice(repository);
            var actualTotalPrice = totPrice.UpdateTotalPrice(2);

            Assert.AreEqual(21, actualTotalPrice);
        }

        [TestMethod]
        public void TestCurrentYear()
        {
            int fixedYear = 2000;

            using (ShimsContext.Create())
            {
                System.Fakes.ShimDateTime.NowGet = () =>
                {
                    return new DateTime(fixedYear, 1, 1);
                };

                DateTimeTools tool = new DateTimeTools();
                int year = tool.GetCurrentYear();
                Assert.AreEqual(fixedYear, year);
            }
        }
    }
}
