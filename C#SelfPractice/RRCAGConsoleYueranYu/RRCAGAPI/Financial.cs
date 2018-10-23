using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yueran.Yu.Business
{
    /// <summary>
    /// Represents a Financial object.
    /// </summary>
    public static class Financial
    {
        /// <summary>
        ///  Returns the payment amount for an annuity based on periodic, fixed payments and a fixed interest rate.    
        /// </summary>
        /// <param name="rate">the interest rate per period. For example, if the rate is an annual percentage rate (APR) of 10 percent and the customer makes monthly payments, the rate per period is 0.1/12, or 0.0083.</param>
        /// <param name="numberOfPaymentPeriods">the total number of payment periods in the annuity. For example, if you make monthly payments on a four</param>
        /// <param name="presentValue">the present value (or lump sum) that a series of payments to be paid in the future is worth now. For example, when a customer finances a car, the loan amount is the present value to the lender of the car payments the customer will make.</param>
        public static decimal GetPayment(decimal rate, int numberOfPaymentPeriods, decimal presentValue)
        {
            decimal futureValue = 0;
            decimal type = 0;

            if (rate < 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than 0.");
            }
            else if (rate > 1)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be greater than 0.");
            }
            else if (numberOfPaymentPeriods <= 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to 0.");
            }
            else if (presentValue <= 0)
            {
                throw new ArgumentOutOfRangeException("The argument cannot be less than or equal to 0.");
            }

            return (rate == 0) ? presentValue / numberOfPaymentPeriods
                : (futureValue + presentValue * (decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods))
                / (((decimal)Math.Pow((double)(1 + rate), (double)numberOfPaymentPeriods) - 1) * (1 + rate * type));
        }
    }
}
