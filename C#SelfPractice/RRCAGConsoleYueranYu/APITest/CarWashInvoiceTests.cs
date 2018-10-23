using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yueran.Yu.Business;

namespace APITest
{
    [TestClass]
    public class CarWashInvoiceTests
    {
        private string eventActual = null;

        void TestHandler(object sender, EventArgs e)
        {
            eventActual = "Event triggered.";
        }

        [TestMethod]
        public void PackageCostChanged_Test()
        {
            this.eventActual = null;
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.2m, 300, 300);
            carWashInvoice.PackageCostChanged += TestHandler;
            carWashInvoice.PackageCost = 500;
            Assert.AreEqual("Event triggered.", eventActual);

        }

        [TestMethod]
        public void FragranceCostChanged_Test()
        {
            this.eventActual = null;
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.2m, 300, 300);
            carWashInvoice.FragranceCostChanged += TestHandler;
            carWashInvoice.FragranceCost = 500;
            Assert.AreEqual("Event triggered.", eventActual);

        }

        [TestMethod]
        public void Constructor_PST_GST_PackageCost_FragranceCost_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 1000;
            decimal fragranceCost = 1000;

            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            PrivateObject carWashInvoicePrivate = new PrivateObject(carWashInvoice);
            PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));

            //Act
            decimal expectedProvincialSalesTaxRate = 0.2m;
            decimal expectedGoodsAndServicesTaxRate = 0.1m;
            decimal expectedPackageCost = 1000;
            decimal expectedFragranceCost = 1000;

            decimal actualProvincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
            decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
            decimal actualPackageCost = (decimal)carWashInvoicePrivate.GetField("packageCost");
            decimal actualFragranceCost = (decimal)carWashInvoicePrivate.GetField("fragranceCost");

            //Assert           
            Assert.AreEqual(expectedProvincialSalesTaxRate, actualProvincialSalesTaxRate);
            Assert.AreEqual(expectedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
            Assert.AreEqual(expectedPackageCost, actualPackageCost);
            Assert.AreEqual(actualFragranceCost, expectedFragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_PackageCost_FragranceCost_ProvincialSalesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = -0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 1000;
            decimal fragranceCost = 1000;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_PackageCost_FragranceCost_ProvincialSalesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 1.2m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 1000;
            decimal fragranceCost = 1000;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_PackageCost_FragranceCost_GoodsAndServicesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = -0.1m;
            decimal packageCost = 1000;
            decimal fragranceCost = 1000;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_PackageCost_FragranceCost_GoodsAndServicesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 1.1m;
            decimal packageCost = 1000;
            decimal fragranceCost = 1000;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_PackageCost_FragranceCost_PackageCostLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = -1;
            decimal fragranceCost = 1000;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_PackageCost_FragranceCost_FragranceCostLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 1000;
            decimal fragranceCost = -1;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        public void Constructor_PST_GST_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;

            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, 0, 0);
            PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));

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
        public void Constructor_PST_GST_ProvincialSalesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = -0.2m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0;
            decimal fragranceCost = 0;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_ProvincialSalesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 1.2m;
            decimal goodsAndServicesTaxRate = 0.1m;
            decimal packageCost = 0;
            decimal fragranceCost = 0;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_GoodsAndServicesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = -0.1m;
            decimal packageCost = 0;
            decimal fragranceCost = 0;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_PST_GST_GoodsAndServicesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal provincialSalesTaxRate = 0.2m;
            decimal goodsAndServicesTaxRate = 1.1m;
            decimal packageCost = 0;
            decimal fragranceCost = 0;
            CarWashInvoice carWashInvoice = new CarWashInvoice(provincialSalesTaxRate, goodsAndServicesTaxRate, packageCost, fragranceCost);
            //Act
            //Assert
        }

        [TestMethod]
        public void GetProvincialSalesTaxRate_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expectedProvincialSalesTaxRate = 0.2m;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
            decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
            Assert.AreEqual(expectedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expectedProvincialSalesTaxRate = 0.3m;
            carWashInvoice.ProvincialSalesTaxRate = 0.3m;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
            decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
            Assert.AreEqual(expectedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_LessThanZero_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expcetedProvincialSalesTaxRate = 0.2m;
            //Assert
            try
            {
                carWashInvoice.ProvincialSalesTaxRate = -0.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
                decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
                Assert.AreEqual(expcetedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
            }
        }

        [TestMethod]
        public void SetProvincialSalesTaxRate_MoreThanOne_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expcetedProvincialSalesTaxRate = 0.2m;
            //Assert
            try
            {
                carWashInvoice.ProvincialSalesTaxRate = 1.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
                decimal actualprovincialSalesTaxRate = (decimal)target.GetField("provincialSalesTaxRate");
                Assert.AreEqual(expcetedProvincialSalesTaxRate, actualprovincialSalesTaxRate);
            }
        }

        [TestMethod]
        public void GetGoodsAndServicesTaxRate_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expectedGoodsAndServicesTaxRate = 0.1m;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
            decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
            Assert.AreEqual(expectedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expectedGoodsAndServicesTaxRate = 0.3m;
            carWashInvoice.GoodsAndServicesTaxRate = 0.3m;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
            decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
            Assert.AreEqual(expectedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_LessThanZero_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expcetedGoodsAndServicesTaxRate = 0.1m;
            //Assert
            try
            {
                carWashInvoice.GoodsAndServicesTaxRate = -0.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
                decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
                Assert.AreEqual(expcetedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
            }
        }

        [TestMethod]
        public void SetGoodsAndServicesTaxRate_MoreThanOne_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 500, 500);

            //Act
            decimal expcetedGoodsAndServicesTaxRate = 0.1m;
            //Assert
            try
            {
                carWashInvoice.GoodsAndServicesTaxRate = 1.2m;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice, new PrivateType(typeof(Invoice)));
                decimal actualGoodsAndServicesTaxRate = (decimal)target.GetField("goodsAndServicesTaxRate");
                Assert.AreEqual(expcetedGoodsAndServicesTaxRate, actualGoodsAndServicesTaxRate);
            }
        }

        [TestMethod]
        public void SetPackageCost_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal expectedPackagedCost = 1500;
            carWashInvoice.PackageCost = 1500;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal actualPackageCost = (decimal)target.GetField("packageCost");
            Assert.AreEqual(expectedPackagedCost, actualPackageCost);
        }

        [TestMethod]
        public void GetPackageCost_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal expectedPackagedCost = 1000;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal actualPackageCost = (decimal)target.GetField("packageCost");
            Assert.AreEqual(expectedPackagedCost, actualPackageCost);
        }

        [TestMethod]
        public void SetFragranceCost_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal expectedFragranceCost = 1500;
            carWashInvoice.FragranceCost = 1500;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal actualFragranceCost = (decimal)target.GetField("fragranceCost");
            Assert.AreEqual(expectedFragranceCost, actualFragranceCost);
        }

        [TestMethod]
        public void GetFragranceCost_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal expectedFragranceCost = 1000;

            //Assert
            PrivateObject target = new PrivateObject(carWashInvoice);
            decimal actualFragranceCost = (decimal)target.GetField("packageCost");
            Assert.AreEqual(expectedFragranceCost, actualFragranceCost);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetPackageCost_LessThanZero_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            carWashInvoice.PackageCost = -1000;


        }

        [TestMethod]
        public void SetPackageCostSpecial_LessThanZero_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal expcetedPackageCost = 1000;
            //Assert
            try
            {
                carWashInvoice.PackageCost = -1000;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice);
                decimal actualPackageCost = (decimal)target.GetField("packageCost");
                Assert.AreEqual(expcetedPackageCost, actualPackageCost);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetFragranceCost_LessThanZero_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            carWashInvoice.FragranceCost = -1000;


        }

        [TestMethod]
        public void SetFragranceCostSpecial_LessThanZero_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal expcetedFragranceCost = 1000;
            //Assert
            try
            {
                carWashInvoice.FragranceCost = -1000;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject target = new PrivateObject(carWashInvoice);
                decimal actualFragranceCost = (decimal)target.GetField("packageCost");
                Assert.AreEqual(expcetedFragranceCost, actualFragranceCost);
            }
        }

        [TestMethod]
        public void GetProvincialSalesTaxCharged_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m);

            //Act
            decimal salesTax = 0;

            //Assert
            Assert.AreEqual(0, salesTax);
        }

        [TestMethod]
        public void GetGoodsAndServicesTaxCharged_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal salesTax = (carWashInvoice.PackageCost + carWashInvoice.FragranceCost) * 0.1m;

            //Assert
            Assert.AreEqual(200, salesTax);
        }

        [TestMethod]
        public void SubTotal_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal subTotal = carWashInvoice.PackageCost + carWashInvoice.FragranceCost;

            //Assert
            Assert.AreEqual(2000, subTotal);
        }

        [TestMethod]
        public void Total_Test()
        {
            //Arrange
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m, 0.1m, 1000, 1000);

            //Act
            decimal expectedTotal = 1000 + 1000 + 0 + (1000 + 1000) * 0.1m;
            decimal actualTotal = carWashInvoice.Total;
            //Assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }
    }
}
