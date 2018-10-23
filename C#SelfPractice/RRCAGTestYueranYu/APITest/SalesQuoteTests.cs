using System;
using Yueran.Yu.Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITest
{
    [TestClass]
    public class SalesQuoteTests
    {
        [TestMethod]
        public void Constructor_VehicleSalesPrice_TradeInAmount_SalesTaxRate_Accessories_Finish_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories,finish);
            PrivateObject target = new PrivateObject(salesQuote);

            //Act
            decimal expectedVehicleSalesPrice = 10000;
            decimal expectedTradeInAmount = 2000;
            decimal expectedSalesTaxRate = 0.1m;
            Accessories expectedAccessories = Accessories.LeatherInterior;
            ExteriorFinish expectedFinish = ExteriorFinish.Custom;
            decimal actualVehicleSalesPrice = (decimal)target.GetField("vehicleSalesPrice");
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
            Accessories actualAccessories = (Accessories)target.GetField("accessoriesChosen");
            ExteriorFinish actualFinish = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            decimal actualSalesRate = 0.1m;

            //Assert           
            Assert.AreEqual(expectedVehicleSalesPrice, actualVehicleSalesPrice);
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            Assert.AreEqual(expectedAccessories, actualAccessories);
            Assert.AreEqual(expectedFinish, actualFinish);
            Assert.AreEqual(expectedSalesTaxRate, actualSalesRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_TradeInAmount_SalesTaxRate_Accessories_Finish_VehicleSalesPriceLessThanZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = -1;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_TradeInAmount_SalesTaxRate_Accessories_Finish_VehicleSalesPriceEqualToZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 0;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalesPrice_SalesTaxRate_Accessories_Finish_TradeInAmountLessThanZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = -1;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalesPrice_TradeInAmount_Accessories_Finish_SalesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = -0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalesPrice_TradeInAmount_Accessories_Finish_SalesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 1.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        public void Constructor_VehicleSalesPrice_TradeInAmount_SalesTaxRate_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.None;
            ExteriorFinish finish = ExteriorFinish.None;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            PrivateObject target = new PrivateObject(salesQuote);

            //Act
            decimal expectedVehicleSalesPrice = 10000;
            decimal expectedTradeInAmount = 2000;
            decimal expectedSalesTaxRate = 0.1m;
            Accessories expectedAccessories = Accessories.None;
            ExteriorFinish expectedFinish = ExteriorFinish.None;
            decimal actualVehicleSalesPrice = (decimal)target.GetField("vehicleSalesPrice");
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
            Accessories actualAccessories = (Accessories)target.GetField("accessoriesChosen");
            ExteriorFinish actualFinish = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            decimal actualSalesRate = 0.1m;

            //Assert           
            Assert.AreEqual(expectedVehicleSalesPrice, actualVehicleSalesPrice);
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
            Assert.AreEqual(expectedAccessories, actualAccessories);
            Assert.AreEqual(expectedFinish, actualFinish);
            Assert.AreEqual(expectedSalesTaxRate, actualSalesRate);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_TradeInAmount_SalesTaxRate_VehicleSalesPriceLessThanZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = -1;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.None;
            ExteriorFinish finish = ExteriorFinish.None;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_TradeInAmount_SalesTaxRate_VehicleSalesPriceEqualToZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 0;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.None;
            ExteriorFinish finish = ExteriorFinish.None;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalesPrice_SalesTaxRate_TradeInAmountLessThanZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = -1;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.None;
            ExteriorFinish finish = ExteriorFinish.None;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalesPrice_TradeInAmount_SalesTaxRateLessThanZero_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = -0.1m;
            Accessories accessories = Accessories.None;
            ExteriorFinish finish = ExteriorFinish.None;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_VehicleSalesPrice_TradeInAmount_SalesTaxRateMoreThanOne_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 1.1m;
            Accessories accessories = Accessories.None;
            ExteriorFinish finish = ExteriorFinish.None;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);
            //Act
            //Assert
        }

        [TestMethod]
        public void SetVehicleSalesPrice_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            decimal expectedVehicleSalesPrice = 15000;
            salesQuote.VehicleSalePrice = 15000;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualVehicleSalesPrice = (decimal)target.GetField("vehicleSalesPrice");
            Assert.AreEqual(expectedVehicleSalesPrice, actualVehicleSalesPrice);
        }

        //Special exception for set vehicles sales price
        [TestMethod]
        public void SetVehicleSalesPriceSpecial_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);       

            //Act
            decimal expcetedVehicleSalesPrice = 10000;

            //Assert
            try
            {
                salesQuote.VehicleSalePrice = -1000;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject abc = new PrivateObject(salesQuote);
                decimal actualVehicleSalePrice = (decimal)abc.GetField("vehicleSalesPrice");
                Assert.AreEqual(expcetedVehicleSalesPrice, actualVehicleSalePrice);
            }
        }

        [TestMethod]
        public void GetVehicleSalesPrice_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            decimal expectedVehicleSalesPrice = 10000;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualVehicleSalesPrice = (decimal)target.GetField("vehicleSalesPrice");
            Assert.AreEqual(expectedVehicleSalesPrice, actualVehicleSalesPrice);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetVehicleSalesPrice_LessThanZero_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            salesQuote.VehicleSalePrice = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetVehicleSalesPrice_EqualToZero_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            salesQuote.VehicleSalePrice = 0;
        }

        [TestMethod]
        public void SetTradeInAmount_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            decimal expectedTradeInAmount = 3000;
            salesQuote.TradeInAmount = 3000;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
        }

        //Special exception for trade in amount
        [TestMethod]
        public void SetTradeInAmountSpecial_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);

            //Act
            decimal expcetedTradeInAmount = 2000;

            //Assert
            try
            {
                salesQuote.TradeInAmount = -1000;
                Assert.Fail("Did not throw ArgumentOutOfRangeException as expected.");
            }
            catch (ArgumentOutOfRangeException)
            {
                PrivateObject abc = new PrivateObject(salesQuote);
                decimal actualTradeInAmount = (decimal)abc.GetField("tradeInAmount");
                Assert.AreEqual(expcetedTradeInAmount, actualTradeInAmount);
            }
        }

        [TestMethod]
        public void GetTradeInAmount_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            decimal expectedTradeInAmount = 2000;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            decimal actualTradeInAmount = (decimal)target.GetField("tradeInAmount");
            Assert.AreEqual(expectedTradeInAmount, actualTradeInAmount);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetTradeInAmount_LessThanZero_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            salesQuote.TradeInAmount = -1;
        }

        [TestMethod]
        public void SetAccessoriesChosen_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoAndLeather, ExteriorFinish.Custom);

            //Act
            Accessories expectedAccessoriesChosen = Accessories.LeatherInterior;
            salesQuote.AccessoriesChosen = Accessories.LeatherInterior;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void GetAccessoriesChosen_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Custom);

            //Act
            Accessories expectedAccessoriesChosen = Accessories.LeatherInterior;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            Accessories actualAccessoriesChosen = (Accessories)target.GetField("accessoriesChosen");
            Assert.AreEqual(expectedAccessoriesChosen, actualAccessoriesChosen);
        }

        [TestMethod]
        public void SetExteriorFinishChosen_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoAndLeather, ExteriorFinish.Custom);

            //Act
            ExteriorFinish expectedExteriorFinishChosen =ExteriorFinish.Pearlized;
            salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            ExteriorFinish actualExteriorFinishChosen = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expectedExteriorFinishChosen, actualExteriorFinishChosen);
        }

        [TestMethod]
        public void GetExteriorFinishChosen_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Pearlized);

            //Act
            ExteriorFinish expectedExteriorFinishChosen = ExteriorFinish.Pearlized;

            //Assert
            PrivateObject target = new PrivateObject(salesQuote);
            ExteriorFinish actualExteriorFinishChosen = (ExteriorFinish)target.GetField("exteriorFinishChosen");
            Assert.AreEqual(expectedExteriorFinishChosen, actualExteriorFinishChosen);
        }

        [TestMethod]
        public void GetAccessoryCost_StereoSystem_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoSystem, ExteriorFinish.Pearlized);

           //Assert
            Assert.AreEqual(505.05m, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetAccessoryCost_LeatherInterior_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherInterior, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(1010.10m, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetAccessoryCost_StereoAndLeather_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoAndLeather, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(1515.15m, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetAccessoryCost_ComputerNavigation_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.ComputerNavigation, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(1515.15m, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetAccessoryCost_StereoAndNavigation_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoAndNavigation, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(2020.20m, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetAccessoryCost_LeatherAndNavigation_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherAndNavigation, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(2525.25m, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetAccessoryCost_All_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.All, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(3030.30m, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetAccessoryCost_None_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.None, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(0, salesQuote.AccessoryCost);
        }

        [TestMethod]
        public void GetFinishCost_Standard_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherAndNavigation, ExteriorFinish.Standard);

            //Assert
            Assert.AreEqual(202.02m, salesQuote.FinishCost);
        }

        [TestMethod]
        public void GetFinishCost_Pearlized_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherAndNavigation, ExteriorFinish.Pearlized);

            //Assert
            Assert.AreEqual(404.04m, salesQuote.FinishCost);
        }

        [TestMethod]
        public void GetFinishCost_Custom_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherAndNavigation, ExteriorFinish.Custom);

            //Assert
            Assert.AreEqual(606.06m, salesQuote.FinishCost);
        }

        [TestMethod]
        public void GetFinishCost_None_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.LeatherAndNavigation, ExteriorFinish.None);

            //Assert
            Assert.AreEqual(0, salesQuote.FinishCost);
        }

        [TestMethod]
        public void GetSubTotal_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoSystem, ExteriorFinish.Custom);

            //Act 
            decimal expectedSubTotal = 10000 + 505.05m + 606.06m;
            //decimal actualSubTotal = salesQuote.VehicleSalePrice + salesQuote.AccessoryCost + salesQuote.FinishCost;
            decimal actualSubTotal = salesQuote.SubTotal; 
            //Assert
            Assert.AreEqual(expectedSubTotal, actualSubTotal);
        }

        [TestMethod]
        public void GetSalesTax_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoSystem, ExteriorFinish.Custom);

            //Act 
            decimal expectedSalesTax = (10000 + 505.05m +606.06m) * 0.1m;
            decimal actualSalesTax = salesQuote.SubTotal * salesQuote.salesTaxRate;

            //Assert
            Assert.AreEqual(expectedSalesTax, actualSalesTax);
        }

        [TestMethod]
        public void GetTotal_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoSystem, ExteriorFinish.Custom);

            //Act 
            decimal expectedTotal = (10000 + 505.05m + 606.06m) * 0.1m + 10000 + 505.05m + 606.06m;
            decimal actualTotal = (salesQuote.VehicleSalePrice + salesQuote.AccessoryCost + salesQuote.FinishCost) * salesQuote.salesTaxRate + salesQuote.VehicleSalePrice + salesQuote.AccessoryCost + salesQuote.FinishCost;

            //Assert
            Assert.AreEqual(expectedTotal, actualTotal);
        }

        [TestMethod]
        public void GetAmontDue_Test()
        {
            //Arrange
            SalesQuote salesQuote = new SalesQuote(10000, 2000, 0.1m, Accessories.StereoSystem, ExteriorFinish.Custom);

            //Act 
            decimal expectedAmountDue = ((10000 + 505.05m + 606.06m) * 0.1m + 10000 + 505.05m + 606.06m)- 2000;
            decimal actualAmountDue =((salesQuote.VehicleSalePrice + salesQuote.AccessoryCost + salesQuote.FinishCost) * salesQuote.salesTaxRate + salesQuote.VehicleSalePrice + salesQuote.AccessoryCost + salesQuote.FinishCost) - salesQuote.TradeInAmount;

            //Assert
            Assert.AreEqual(expectedAmountDue, actualAmountDue);
        }

        [TestMethod]
        public void ToString_Test()
        {
            //Arrange
            decimal vehicleSalesPrice = 10000;
            decimal tradeInAmount = 2000;
            decimal salesTaxRate = 0.1m;
            Accessories accessories = Accessories.LeatherInterior;
            ExteriorFinish finish = ExteriorFinish.Custom;
            SalesQuote salesQuote = new SalesQuote(vehicleSalesPrice, tradeInAmount, salesTaxRate, accessories, finish);

            string expectedString = "Vehicle Sale Price: $10,000.00Trade-in Amount: $2,000.00Accessories Cost: $1,010.10Finish Cost: $606.06SubTotal: $11,616.16Total: $12,777.78Amount Due: $10,777.78";
            string actualString = string.Format("Vehicle Sale Price: {0:C}Trade-in Amount: {1:C}Accessories Cost: {2:C}Finish Cost: {3:C}SubTotal: {4:C}Total: {5:C}Amount Due: {6:C}",
                                 salesQuote.VehicleSalePrice,
                                 salesQuote.TradeInAmount,
                                 salesQuote.AccessoryCost,
                                 salesQuote.FinishCost,
                                 salesQuote.SubTotal,
                                salesQuote.Total,
                               salesQuote.AmountDue);

            //Assert
            Assert.AreEqual(expectedString,actualString);
        }
    }
}
