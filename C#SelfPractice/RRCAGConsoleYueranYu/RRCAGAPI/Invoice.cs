using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yueran.Yu.Business
{
    /// <summary>
    /// Represents a Invoice object.
    /// </summary>
    public abstract class Invoice
    {
        private decimal provincialSalesTaxRate;
        private decimal goodsAndServicesTaxRate;

        /// <summary>
        /// Gets and sets the provincial sales tax rate .
        /// </summary>
        public decimal ProvincialSalesTaxRate
        {
            get
            {
                return provincialSalesTaxRate;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                else if(value > 1)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.");
                }
                if(this.provincialSalesTaxRate != value)
                {
                    this.provincialSalesTaxRate = value;
                    OnProvincialSalesTaxChanged();
                }
                
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate .
        /// </summary>
        public decimal GoodsAndServicesTaxRate
        {
            get
            {
                return goodsAndServicesTaxRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be less than 0.");
                }
                else if (value > 1)
                {
                    throw new ArgumentOutOfRangeException("The value cannot be greater than 1.");
                }
                if(this.goodsAndServicesTaxRate != value)
                {
                    this.goodsAndServicesTaxRate = value;
                    OnGoodsAndServicesTaxChanged();
                }
             
            }
        }

        /// <summary>
        /// Gets and sets the goods and services tax rate .
        /// </summary>
        public abstract decimal ProvincialSalesTaxCharged
        {
           get;
        }

        /// <summary>
        /// Gets and sets the provincial sales tax rate.
        /// </summary>
        public abstract decimal GoodAndServicesTaxCharged
        {
            get;
        }

        /// <summary>
        /// Gets the subtotal of the Invoice
        /// </summary>
        public abstract decimal SubTotal
        {
            get;
        }

        /// <summary>
        /// Gets the total of the Invoice (Subtotal + Taxes).
        /// </summary>
        public decimal Total
        {
            get
            {
                decimal total;
                return total = SubTotal + ProvincialSalesTaxCharged + GoodAndServicesTaxCharged;
            }
        }

        /// <summary>
        /// Initializes an instance of Invoice with a provincial and goods and services tax rates.
        /// </summary>
        public Invoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
        {
            if(provincialSalesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            else if(provincialSalesTaxRate >1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 0.");
            }
            else if(goodsAndServicesTaxRate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            else if(goodsAndServicesTaxRate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 0.");
            }
            this.provincialSalesTaxRate = provincialSalesTaxRate;
            this.goodsAndServicesTaxRate = goodsAndServicesTaxRate;
        }

        /// <summary>
        /// Occurs when the provincial sales tax rate of the Invoice changes.
        /// </summary>
        public event EventHandler ProvincialSalesTaxChanged;
      
        /// <summary>
        /// Occurs when the provincial sales tax rate of the Invoice changes.
        /// </summary>
        public event EventHandler GoodsAndServicesTaxChanged;

        /// <summary>
        ///Event Sender:Raises the ProvincialSalesTaxChanged event.
        /// </summary>
        protected virtual void OnProvincialSalesTaxChanged()
        {
            if (ProvincialSalesTaxChanged != null)
            {
                ProvincialSalesTaxChanged(this, new EventArgs());
            }
        }

        /// <summary>
        ///Event Sender:Raises the Goods And Services Tax Changed event.
        /// </summary>
        protected virtual void OnGoodsAndServicesTaxChanged()
        {
            if (GoodsAndServicesTaxChanged != null)
            {
                GoodsAndServicesTaxChanged(this, new EventArgs());
            }
        }
    }
}
