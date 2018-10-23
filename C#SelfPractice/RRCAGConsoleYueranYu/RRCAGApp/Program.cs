using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yueran.Yu.Business;

namespace Yueran.Yu.Business
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test SalesQuote Class
            //Event Sender
            SalesQuote salesQuote = new SalesQuote(20000,2000,0.2m,Accessories.ComputerNavigation,ExteriorFinish.Custom);

            //EventHandler:VehiclePriceChanged - subscribe - Event Invocation list
            salesQuote.VehiclePriceChanged += SalesQuote_VehiclePriceChanged;

            //change vehicle price
            salesQuote.VehicleSalePrice = 10000;

            //EventHandler:TradeInAmountChanged - subscribe - Event Invocation list
            salesQuote.TradeInAmountChanged += SalesQuote_TradeInAmountChanged;

            //change trade in amount
            salesQuote.TradeInAmount = 1000;

            //EventHandler:AccessoriesChosenChanged - subscribe - Event Invocation list
            salesQuote.AccessoriesChosenChanged += SalesQuote_AccessoriesChosenChanged;

            //change accessories
            salesQuote.AccessoriesChosen = Accessories.LeatherAndNavigation;

            //EventHandler:ExteriorFinishChosenChanged - subscribe - Event Invocation list
            salesQuote.ExteriorFinishChosenChanged += SalesQuote_ExteriorFinishChosenChanged;

            //change exterior finish
            salesQuote.ExteriorFinishChosen = ExteriorFinish.Pearlized;

            //Test Invoice abstract Class
            //Event Sender
            Invoice invoice = new ServiceInvoice(0.2m,0.2m);

            //EventHandler:ProvincialSalesTaxChanged - subscribe - Event Invocation list
            invoice.ProvincialSalesTaxChanged += Invoice_ProvincialSalesTaxChanged;

            //change PST rate
            invoice.ProvincialSalesTaxRate = 0.3m;

            //EventHandler:GoodsAndServicesTaxChanged - subscribe - Event Invocation list
            invoice.GoodsAndServicesTaxChanged += Invoice_GoodsAndServicesTaxChanged;

            //change GST rate
            invoice.GoodsAndServicesTaxRate = 0.3m;

            // Test ServiceInvoice Class
            //Event Sender 
            ServiceInvoice serviceInvoice = new ServiceInvoice(0.2m,0.2m);

            //EventHandler:PackageCostChanged - subscribe - Event Invocation list
            serviceInvoice.CostAdded += ServiceInvoice_CostAdded;

            //add cost
            serviceInvoice.AddCost(CostType.Labour, 500);
            serviceInvoice.AddCost(CostType.Material,500);
            serviceInvoice.AddCost(CostType.Part,500);

            // Test CarWashInvoice Class
            //Event Sender
            CarWashInvoice carWashInvoice = new CarWashInvoice(0.2m,0.2m,300,300);

            //EventHandler:PackageCostChanged - subscribe - Event Invocation list
            carWashInvoice.PackageCostChanged += CarWashInvoice_PackageCostChanged;

            //modify the cost of package
            carWashInvoice.PackageCost = 500;

            //EventHandler:FragranceCostChanged - subscribe -  Event Invocation list
            carWashInvoice.FragranceCostChanged += CarWashInvoice_FragranceCostChanged;

            //modify the cost of package
            carWashInvoice.FragranceCost = 500;

        }

        private static void SalesQuote_ExteriorFinishChosenChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Exterior finish has been changed.");
        }

        private static void SalesQuote_AccessoriesChosenChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Accessory has been changed.");
        }

        private static void SalesQuote_TradeInAmountChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Trade in amount has been changed.");
        }

        private static void SalesQuote_VehiclePriceChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Vehicle price has been changed.");
        }

        private static void Invoice_GoodsAndServicesTaxChanged(object sender, EventArgs e)
        {
            Console.WriteLine("GST rate has been changed.");
        }

        private static void Invoice_ProvincialSalesTaxChanged(object sender, EventArgs e)
        {
            Console.WriteLine("PST rate has been changed.");
        }

        private static void ServiceInvoice_CostAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Cost has been added.");
        }

        private static void CarWashInvoice_PackageCostChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Package cost has been changed.");
        }

        private static void CarWashInvoice_FragranceCostChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Fragrance cost has been changed.");
        }
    }
}
