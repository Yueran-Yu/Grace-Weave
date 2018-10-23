using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yueran.Yu.Business
{

    /// <summary>
    /// Represents a ServiceInvoice object.
    /// </summary>
    public class ServiceInvoice : Invoice
    {
        /// <summary>
        /// Gets the amount charged for labour.
        /// </summary>
        public decimal LabourCost
        {
            get; private set;
        }

        /// <summary>
        /// Gets the amount charged for parts.
        /// </summary>
        public decimal PartsCost
        {
            get; private set;
        }

        /// <summary>
        /// Gets the amount charged for shop materials.
        /// </summary>
        public decimal MaterialCost
        {
            get; private set;
           
        }

        /// <summary>
        /// Gets the amount of provincial sales tax charged to the customer. Provincial Sales Tax is not applied to labour cost.
        /// </summary>
        public override decimal ProvincialSalesTaxCharged
        {
            get
            {
                decimal saleTax;
                return  saleTax = (PartsCost + MaterialCost) * ProvincialSalesTaxRate;
            }
        }

        /// <summary>
        /// Gets the amount of goods and services tax charged to the customer.
        /// </summary>
        public override decimal GoodAndServicesTaxCharged
        {
            get
            {
                decimal saleTax;
                return saleTax = SubTotal * GoodsAndServicesTaxRate;
            }
        }

        /// <summary>
        /// Gets the subtotal of the Invoice.
        /// </summary>
        public override decimal SubTotal
        {
            get
            {   decimal subtotal;
                return subtotal = LabourCost + PartsCost + MaterialCost;
            }
        }

        /// <summary>
        /// Initializes an instance of ServiceInvoice with a provincial and goods and services tax rates.    
        /// </summary>
        /// <param name="provincialSalesTaxRate">The rate of provincial tax charged to a customer.</param>
        /// <param name="goodsAndServicesTaxRate">- The rate of goods and services tax charged to a customer.</param>
        public ServiceInvoice(decimal provincialSalesTaxRate, decimal goodsAndServicesTaxRate)
            :base(provincialSalesTaxRate, goodsAndServicesTaxRate)
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
        }

        /// <summary>
        /// Increments a specified cost by the specified amount.
        /// </summary>
        public void AddCost(CostType costType, decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to 0.");
            }
            else if (costType == CostType.Labour)
            {
                LabourCost += amount;
            }
            else if(costType == CostType.Part)
            {
                PartsCost += amount;
            }
            else if(costType == CostType.Material)
            {
                MaterialCost += amount;
            }
            OnCostAdded();
        }

        /// <summary>
        /// Occurs when a cost is added to the invoice.
        /// </summary>
        public event EventHandler CostAdded;

        /// <summary>
        /// Event Sender:Raises the CostAdded event.
        /// </summary>
        protected virtual void OnCostAdded()
        {
            if (CostAdded != null)
            {
                CostAdded(this, new EventArgs());
            }
        }

    }
}
