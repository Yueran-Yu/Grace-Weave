using System;
using Yueran.Yu.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITest
{
    [TestClass]
    public class ServiceInvoiceTests
    {
        private string eventActual = null;
        void TestHandler(object sender, EventArgs e)
        {
            eventActual = "Event triggered.";
        }

        [TestMethod]
        public void CostAdded_Test()
        {
            this.eventActual = null;
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.2m);
            serviceInvoice.CostAdded += TestHandler;
            serviceInvoice.AddCost(CostType.Labour, 500);
            Assert.AreEqual("Event triggered.", eventActual);
        }

        [TestMethod]
        public void Constructor_ServiceInvoiceWithProvincalAndGoodsServicesTaxRate_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;

            ServiceInvoice servieInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            PrivateObject target = new PrivateObject(servieInvoice, new PrivateType(typeof(Invoice)));

            //Act
            decimal expectedProvincialSalesTaxRate = 0.2m;
            decimal expectedGoodsAndServicesTaxRate = 0.1m;
            decimal actualProvincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
            decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");

            //Assert           
            Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            Assert.AreEqual(expectedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ProvincialSalesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = -0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;

            ServiceInvoice servieInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            PrivateObject target = new PrivateObject(servieInvoice, new PrivateType(typeof(Invoice)));

            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ProvincialSalesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 1.1m;
            decimal goodsAndServicesTaxRate = 0.1m;

            ServiceInvoice servieInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            PrivateObject target = new PrivateObject(servieInvoice, new PrivateType(typeof(Invoice)));

            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_GoodsAndServicesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = -0.1m;

            ServiceInvoice servieInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            PrivateObject target = new PrivateObject(servieInvoice, new PrivateType(typeof(Invoice)));

            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_GoodsAndServicesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 1.1m;

            ServiceInvoice servieInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);
            PrivateObject target = new PrivateObject(servieInvoice, new PrivateType(typeof(Invoice)));

            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCost_LessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 1.1m;
            ServiceInvoice servieInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            servieInvoice.AddCost(CostType.Labour, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddCost_EqualToZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 1.1m;
            ServiceInvoice servieInvoice = new ServiceInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate);

            servieInvoice.AddCost(CostType.Labour, 0);
        }

        [TestMethod]
        public void GetProvincialSalesTaxRate_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expectedProvincialSalesTaxRate = 0.2m;

            //Assert
            PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
            decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
            Assert.AreEqual(expectedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expectedProvincialSalesTaxRate = 0.3m;
            serviceInvoice.ProvincialSalesTaxRate = 0.3m;

            //Assert
            PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
            decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
            Assert.AreEqual(expectedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_LessThanZero_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expcetedProvincialSalesTaxRate = 0.2m;
            //Assert
            try
            {
                serviceInvoice.ProvincialSalesTaxRate = -0.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
                decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
                Assert.AreEqual(expcetedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
            }
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_MoreThanOne_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expcetedProvincialSalesTaxRate = 0.2m;
            //Assert
            try
            {
                serviceInvoice.ProvincialSalesTaxRate = 1.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
                decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
                Assert.AreEqual(expcetedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
            }
        }

        [TestMethod]
        public void GetGoodsAndServicesTaxRate_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expectedGoodsAndServicesTaxRate = 0.1m;

            //Assert
            PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
            decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
            Assert.AreEqual(expectedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expectedGoodsAndServicesTaxRate = 0.3m;
            serviceInvoice.GoodsAndServicesTaxRate = 0.3m;

            //Assert
            PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
            decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
            Assert.AreEqual(expectedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_LessThanZero_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expcetedGoodsAndServicesTaxRate = 0.1m;
            //Assert
            try
            {
                serviceInvoice.GoodsAndServicesTaxRate = -0.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
                decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
                Assert.AreEqual(expcetedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
            }
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_MoreThanOne_Test()
        {
            //Arrange
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal expcetedGoodsAndServicesTaxRate = 0.1m;
            //Assert
            try
            {
                serviceInvoice.GoodsAndServicesTaxRate = 1.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(serviceInvoice, new PrivateType(typeof(Invoice)));
                decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
                Assert.AreEqual(expcetedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
            }
        }

        [TestMethod]
        public void AddCost_CostTypeLabour_Test()
        {
            //Arrange
            ServiceInvoice servieInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal actualAmount = 300;
            servieInvoice.AddCost(CostType.Labour, actualAmount);

            //Assert    
            Assert.AreEqual(300, servieInvoice.LabourCost);
        }

        [TestMethod]
        public void AddCost_CostTypePart_Test()
        {
            //Arrange
            ServiceInvoice servieInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal actualAmount = 300;
            servieInvoice.AddCost(CostType.Part, actualAmount);

            //Assert    
            Assert.AreEqual(300, servieInvoice.PartsCost);
        }

        [TestMethod]
        public void AddCost_CostTypeMaterial_Test()
        {
            //Arrange
            ServiceInvoice servieInvoice = new ServiceInvoice(0.2m, 0.1m);

            //Act
            decimal actualAmount = 300;
            servieInvoice.AddCost(CostType.Material, actualAmount);

            //Assert    
            Assert.AreEqual(300, servieInvoice.MaterialCost);
        }

        [TestMethod]
        public void GetProvincialSalesTaxCharged_Test()
        {
            //Arrange
            ServiceInvoice servieInvoice = new ServiceInvoice(0.2m, 0.1m);
            servieInvoice.AddCost(CostType.Labour, 500);
            servieInvoice.AddCost(CostType.Part, 500);

            //Act
            decimal salesTax = (servieInvoice.LabourCost + servieInvoice.PartsCost) * 0.2m;

            //Assert
            Assert.AreEqual(200m, salesTax);
        }

        [TestMethod]
        public void GetGoodsAndServicesTaxCharged_Test()
        {
            //Arrange
            ServiceInvoice servieInvoice = new ServiceInvoice(0.2m, 0.1m);
            servieInvoice.AddCost(CostType.Labour, 500);
            servieInvoice.AddCost(CostType.Part, 500);
            servieInvoice.AddCost(CostType.Material, 500);

            //Act
            decimal salesTax = (servieInvoice.LabourCost + servieInvoice.PartsCost + servieInvoice.MaterialCost) * 0.1m;

            //Assert
            Assert.AreEqual(150m, salesTax);
        }

        [TestMethod]
        public void SubTotal_Test()
        {
            //Arrange
            ServiceInvoice servieInvoice = new ServiceInvoice(0.2m, 0.1m);
            servieInvoice.AddCost(CostType.Labour, 500);
            servieInvoice.AddCost(CostType.Part, 500);
            servieInvoice.AddCost(CostType.Material, 500);

            //Act
            decimal subTotal = servieInvoice.LabourCost + servieInvoice.PartsCost + servieInvoice.MaterialCost;

            //Assert
            Assert.AreEqual(1500, subTotal);
        }

        [TestMethod]
        public void Total_Test()
        {
            //Arrange
            ServiceInvoice servieInvoice = new ServiceInvoice(0.2m, 0.1m);
            servieInvoice.AddCost(CostType.Labour, 500);
            servieInvoice.AddCost(CostType.Part, 500);
            servieInvoice.AddCost(CostType.Material, 500);
            //Act
            decimal expectedTotal = (500 + 500 + 500) + (500 + 500) * 0.2m + (500 + 500 + 500) * 0.1m;
            decimal actualTotal = servieInvoice.SubTotal + servieInvoice.ProvincialSalesTaxCharged + servieInvoice.GoodAndServicesTaxCharged;

            //Assert
            Assert.AreEqual(expectedTotal, actualTotal);

        }
    }
}
