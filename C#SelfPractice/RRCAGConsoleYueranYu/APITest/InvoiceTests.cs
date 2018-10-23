using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yueran.Yu.Business;

namespace APITest
{
    [TestClass]
    public class InvoiceTests
    {
        private string eventActual = null;
        void TestHandler(object sender, EventArgs e)
        {
            eventActual = "Event triggered.";
        }

        [TestMethod]
        public void ProvincialSalesTaxChanged_Test()
        {
            this.eventActual = null;
            Invoice invoice = new ServiceInvoice(0.2m, 0.2m);
            invoice.ProvincialSalesTaxChanged += TestHandler;
            invoice.ProvincialSalesTaxRate = 0.3m;
            Assert.AreEqual("Event triggered.", eventActual);
        }

        [TestMethod]
        public void GoodsAndServicesTaxChanged_Test()
        {
            this.eventActual = null;
            Invoice invoice = new ServiceInvoice(0.2m, 0.2m);
            invoice.GoodsAndServicesTaxChanged += TestHandler;
            invoice.GoodsAndServicesTaxRate = 0.3m;
            Assert.AreEqual("Event triggered.", eventActual);
        }
    }
}
