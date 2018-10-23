using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double result1 = Calculator.Add(3,4);
            Console.WriteLine("The result is {0}",result1);
            double result2 = Calculator.Sub(3, 4);
            Console.WriteLine("The result is {0}", result2);
            double result3 = Calculator.Mul(3, 4);
            Console.WriteLine("The result is {0}", result3); */
            double result4 = Calculator.Div(0, 0);
            Console.WriteLine( result4);
        }
    }
}
