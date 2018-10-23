using System;

namespace Yueran.Yu.Business
{

    //From documentation for EventHandler
    public delegate void EventHandler(object sender, EventArgs e);

    /// <summary>
    /// Represents a SalesQuote object.
    /// </summary>
    public class SalesQuote
    {   
        private decimal vehicleSalesPrice;
        private decimal tradeInAmount;
        public decimal salesTaxRate;
        private Accessories accessoriesChosen;
        private ExteriorFinish exteriorFinishChosen;

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price,
        /// trade-in value, sales tax rate, accessories chosen and exterior finish chosen.        
        /// </summary>
        /// <param name="vehicleSalesPrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <param name="accessoriesChosen">The value of the chosen accessories.</param>
        /// <param name="exteriorFinishChosen">The value of the chosen exterior finish.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when argument cannot be less than or equal ot 0.</exception>
        public SalesQuote(decimal vehicleSalesPrice,
                          decimal tradeInAmount,
                          decimal salesTaxRate,
                          Accessories accessoriesChosen,
                          ExteriorFinish exteriorFinishChosen)
        {
            if(vehicleSalesPrice <= 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to 0.");
            }
            if(tradeInAmount < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            if(salesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            else if(salesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 0.");
            }
            this.vehicleSalesPrice = vehicleSalesPrice;
            this.tradeInAmount = tradeInAmount;
            this.salesTaxRate = salesTaxRate;
            this.accessoriesChosen = accessoriesChosen;
            this.exteriorFinishChosen = exteriorFinishChosen;
        }

        /// <summary>
        /// Initializes an instance of SalesQuote with a vehicle price,
        /// trade-in value, sales tax rate.        
        /// </summary>
        /// <param name="vehicleSalesPrice">The selling price of the vehicle being sold.</param>
        /// <param name="tradeInAmount">The amount offered to the customer for the trade in of their vehicle.</param>
        /// <param name="salesTaxRate">The tax rate applied to the sale of a vehicle.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when argument cannot be less than or equal ot 0.</exception>
        public SalesQuote(decimal vehicleSalesPrice, decimal tradeInAmount, decimal salesTaxRate)
            : this(vehicleSalesPrice, tradeInAmount, salesTaxRate, Accessories.None, ExteriorFinish.None)
        {
            
        }

        /// <summary>
        /// Gets and sets the sale price of the vehicle.
        /// </summary>
       /// <exception cref="System.ArgumentOutOfRangeException">Thrown when argument cannot be less than or equal ot 0.</exception>
        public decimal VehicleSalePrice
        {
            get
            {
                return vehicleSalesPrice;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than or equal to 0.");
                }

                if (this.vehicleSalesPrice != value)
                {
                    this.vehicleSalesPrice = value;
                    OnVehiclePriceChanged();
                }                
            }
        }

        /// <summary>
        ///Gets and sets the trade in amount. 
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when argument cannot be less than or equal ot 0.</exception>
        public decimal TradeInAmount
        {
            get
            {
                return tradeInAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                if(this.tradeInAmount != value)
                {
                      this.tradeInAmount = value;
                    OnTradeInAmountChanged();
                }                
             }
        }

        /// <summary>
        /// Gets and sets the accessories chosen for the vehicle. 
        /// </summary>
        public Accessories AccessoriesChosen
        {
            get { return accessoriesChosen; }
            set {

                if (this.accessoriesChosen != value)
                {
                    this.accessoriesChosen = value;
                    OnAccessoriesChosenChanged();
                }                 
            }
        }

        /// <summary>
        /// Gets and sets the exterior finish chosen for the vehicle.
        /// </summary>
        public ExteriorFinish ExteriorFinishChosen
        {
            get { return exteriorFinishChosen; }
            set {
                if(this.exteriorFinishChosen != value)
                {
                  this.exteriorFinishChosen = value;
                    OnExteriorFinishChosenChanged();
                }
            
            }
        }

        /// <summary>
        /// Returns the cost of the accessories chosen.
        /// </summary>
        public decimal AccessoryCost
        {
            get
            {
                decimal accessoriesCost;
                const decimal STEREO = 505.05m;
                const decimal LEATHER = 1010.10m;
                const decimal NAVIGATION = 1515.15m;

                switch (AccessoriesChosen)
                {
                    case Accessories.StereoSystem:
                        accessoriesCost = STEREO;
                        break;
                    case Accessories.LeatherInterior:
                        accessoriesCost = LEATHER;
                        break;
                    case Accessories.StereoAndLeather:
                        accessoriesCost = STEREO + LEATHER;
                        break;
                    case Accessories.ComputerNavigation:
                        accessoriesCost = NAVIGATION;
                        break;
                    case Accessories.StereoAndNavigation:
                        accessoriesCost = STEREO + NAVIGATION;
                        break;
                    case Accessories.LeatherAndNavigation:
                        accessoriesCost = LEATHER + NAVIGATION;
                        break;
                    case Accessories.All:
                        accessoriesCost = STEREO + LEATHER + NAVIGATION;
                        break;
                    default:
                        accessoriesCost = 0m;
                        break;
                }
                return accessoriesCost;
            }
        }

        /// <summary>
        /// Returns the cost of the exterior finish chosen.
        /// </summary>
        public decimal FinishCost
        {
            get
            {
                decimal finishCost;
                switch (ExteriorFinishChosen)
                {
                    case ExteriorFinish.Standard:
                        finishCost = 202.02m;
                        break;
                    case ExteriorFinish.Pearlized:
                        finishCost = 404.04m;
                        break;
                    case ExteriorFinish.Custom:
                        finishCost = 606.06m;
                        break;
                    default:
                        finishCost = 0m;
                        break;
                }
                return finishCost;
            }
        }


        /// <summary>
        /// Returns the sum of the vehicle’s sale price, accessories and exterior finish costs.
        /// </summary>
        public decimal SubTotal
        {
            get {
                decimal subTotal;
                return subTotal = VehicleSalePrice + AccessoryCost + FinishCost;
            }
        }

        /// <summary>
        /// Returns the amount of tax to charge based on the subtotal.
        /// </summary>
        public decimal SalesTax
        {
            get
            {
                decimal salesTax;
                return salesTax = SubTotal * salesTaxRate;
            }
        }

        /// <summary>
        /// Returns the sum of the subtotal and taxes.
        /// </summary>
        public decimal Total
        {
            get
            {
                decimal total;
                return total = SubTotal + SalesTax;
            }
        }

        /// <summary>
        /// Returns the difference of the total and  trade in amount.
        /// </summary>
        public decimal AmountDue
        {
            get { 
                decimal amountDue;
                return amountDue = Total - TradeInAmount;
            }
        }

        /// <summary>
        /// Returns the String representation of a SalesQuote.
        /// </summary>
        override public String ToString()
        {
            return String.Format("Vehicle Sale Price: {0:C}Trade-in Amount: {1:C}Accessories Cost: {2:C}Finish Cost: {3:C}SubTotal: {4:C}Total: {5:C}Amount Due: {6:C}", 
                                 VehicleSalePrice, 
                                 TradeInAmount,
                                 AccessoryCost, 
                                 FinishCost, 
                                 SubTotal, 
                                 Total, 
                                 AmountDue);
        }

        /// <summary>
        /// Occurs when the price of the vehicle being quoted on changes.
        /// </summary>
        public event EventHandler VehiclePriceChanged;

        /// <summary>
        /// Occurs when the amount for the trade in vehicle changes.
        /// </summary>
        public event EventHandler TradeInAmountChanged;

        /// <summary>
        /// Occurs when the chosen accessories changes.
        /// </summary>
        public event EventHandler AccessoriesChosenChanged;

        /// <summary>
        /// Occurs when the chose exterior finish changes.
        /// </summary>
        public event EventHandler ExteriorFinishChosenChanged;

        /// <summary>
        /// Raises the VehiclePriceChanged event.
        /// </summary>
        protected virtual void OnVehiclePriceChanged()
        {
            if(VehiclePriceChanged != null)
            {
                VehiclePriceChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the TradeInAmountChanged event.
        /// </summary>
        protected virtual void OnTradeInAmountChanged()
        {
            if(TradeInAmountChanged != null)
            {
                TradeInAmountChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the AccessoriesChosenChanged event.
        /// </summary>
        protected virtual void OnAccessoriesChosenChanged()
        {
            if (AccessoriesChosenChanged != null)
            {
                AccessoriesChosenChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Raises the ExteriorFinishChosenChanged event.
        /// </summary>
        protected virtual void OnExteriorFinishChosenChanged()
        {
            if (ExteriorFinishChosenChanged != null)
            {
                ExteriorFinishChosenChanged(this, new EventArgs());
            }
        }
    }
}
