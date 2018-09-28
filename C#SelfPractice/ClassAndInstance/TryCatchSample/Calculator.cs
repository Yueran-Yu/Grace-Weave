using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchSample
{
    class Calculator
    {
        int a = 0;
        int b = 0;
        bool hasError = false;
        public int Add(string arg1, string arg2)
        {
            try
            {
            a = int.Parse(arg1);
            b = int.Parse(arg2);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                hasError = true;
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                hasError = true;
            }
            catch (OverflowException ex)
            {
                // Console.WriteLine(ex.Message);
                throw ex;             
            }
           /* finally
            {
                if(hasError)
                {
                    Console.WriteLine("Exception has error!");
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }
            */
            int result = a + b;
            return result;               
        }
    }
}
