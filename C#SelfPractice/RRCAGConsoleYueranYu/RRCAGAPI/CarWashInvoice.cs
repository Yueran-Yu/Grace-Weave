using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yueran.Yu.Business
{
    /// <summary>
    /// Represents a CarWashInvoice object.
    /// </summary>
    public class CarWashInvoice:Invoice
    {
        private decimal packageCost;
        private decimal fragranceCost;

        /// <summary>
        /// Gets and sets the amount charged for the chosen package.
        /// </summary>
        public decimal PackageCost
        {
            get
            {
                return packageCost;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                if(this.packageCost != value)
                {
                    this.packageCost = value;
                    OnPackageCostChanged();
                }              
            }
        }

        /// <summary>
        /// - Gets and sets the amount charged for the chosen fragrance.
        /// </summary>
        public decimal FragranceCost
        {
            get
            {
                return fragranceCost;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }

                if(value != this.fragranceCost)
                {
                    this.fragranceCost = value;
                    OnFragranceCostChanged();
                }
                
            }
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer. No provincial sales tax is charged for a car wash.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer.
        /// </summary>
        public override decimal GoodAndServicesTaxCharged
        {
            get
            {
                return (PackageCost + FragranceCost) * GoodsAndServicesTaxRate;
            }
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {
                decimal subtotal;
                return  subtotal = PackageCost + FragranceCost;
            }
        }

        /// <summary>
        /// Initializes an instance of CarWashInvoice with a provincial and goods and services tax rates. 
        /// The package cost and fragrance cost are zero.    
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when argument cannot be less than or equal ot 0.</exception>
        public CarWashInvoice(decimal provincialSalesTaxRate,decimal goodsAndServicesTaxRate)
            :this(provincialSalesTaxRate, goodsAndServicesTaxRate, 0, 0)
        {
         
        }

        /// <summary>
        ///- Initializes an instance of CarWashInvoice with a provincial and goods, 
        ///services tax rate, package cost and fragrance cost.        
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">The rate of goods and services tax charged to a customer.</param>
        /// <param name="packageCost">The cost of the chosen package.</param>
        /// <param name="fragranceCost">The cost of the chosen fragrance.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when argument cannot be less than or equal ot 0.</exception>

        public CarWashInvoice(decimal provincialSalesTaxRate,
                              decimal goodsAndServicesTaxRate,
                              decimal packageCost,
                              decimal fragranceCost): base(provincialSalesTaxRate, goodsAndServicesTaxRate)
        {
            if (provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            else if (provincialSalesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 0.");
            }
            else if (goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            else if (goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 0.");
            }
            else if(packageCost < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            else if(fragranceCost < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            this.packageCost = packageCost;
            this.fragranceCost = fragranceCost;
        }


        /// <summary>
        /// Occurs when the package cost changes.
        /// </summary>
        public event EventHandler PackageCostChanged;

        /// <summary>
        /// Occurs when the fragrance cost changes.
        /// </summary>
        public event EventHandler FragranceCostChanged;

        /// <summary>
        /// Event Sender:Raises the PackageCostChanged event.
        /// </summary>
        protected virtual void OnPackageCostChanged()
        {
            if (PackageCostChanged != null)
            {
                PackageCostChanged(this, new EventArgs());
            }
        }

        /// <summary>
        /// Event Sender:Raises the FragranceCostChanged event.
        /// </summary>
        protected virtual void OnFragranceCostChanged()
        {
            if (FragranceCostChanged != null)
            {
                FragranceCostChanged(this, new EventArgs());
            }
        }

    }

}
