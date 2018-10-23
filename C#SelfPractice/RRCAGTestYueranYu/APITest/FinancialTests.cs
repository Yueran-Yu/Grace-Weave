using System;
using Yueran.Yu.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITest
{
    [TestClass]
    public class FinancialTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_RateLessThanZero_Test()
        {
            decimal getPayment = Financial.GetPayment(-0.1m,54,2000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_RateLMoreThanOne_Test()
        {
            decimal getPayment = Financial.GetPayment(1.1m, 54, 2000);
        }

        [TestMethod]
        public void GetPayment_RateEqualToOne_Test()
        {
            decimal getPayment = Financial.GetPayment(0, 54, 2000);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NumberOfPaymentPeriodsLessThanZero_Test()
        {
            decimal getPayment = Financial.GetPayment(0.1m, -1, 2000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_NumberOfPaymentPeriodsEqualToZero_Test()
        {
            decimal getPayment = Financial.GetPayment(0.1m, 0, 2000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_PresentValueLessThanZero_Test()
        {
            decimal getPayment = Financial.GetPayment(0.1m, 54, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetPayment_PresentValueEqualToZero_Test()
        {
            decimal getPayment = Financial.GetPayment(0.1m, 54, 0);
        }

        [TestMethod]
        public void GetPayment_Vaild_Test()
        {
            //Aact
            decimal actualPayment = Financial.GetPayment(0.1m, 54, 2000);
            decimal expectedPayment = (0 + 2000 * (decimal)Math.Pow((double)1.1, 54)) / (((decimal)Math.Pow((double)1.1, 54) - 1) * (1 + 0.1m * 0));

            //Assert
            Assert.AreEqual(expectedPayment,actualPayment);
        }
    }
}
