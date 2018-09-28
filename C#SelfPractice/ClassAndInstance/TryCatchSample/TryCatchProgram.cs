using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchSample
{
    public class TryCatchProgram
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int r = 0;
            try
            {
                r = c.Add("9999999999999999", "200");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(r);
        }
    }
}
