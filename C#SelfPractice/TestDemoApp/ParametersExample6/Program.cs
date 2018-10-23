using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample6
{
    class Program
    {
        static void Main(string[] args)
        {
          //int[] myIntArray = new int[] {1,2,3};
            int result = CalculateSum(1,2,3);
            Console.WriteLine(result);

            int x = 100;
            int y = 200;
            int z = x + y;
            Console.WriteLine("{0}+{1}={2}",x,y,z);
            Console.WriteLine("===================================");
            string str = "Tim;Tom,Amy.Lisa";
            string[] result1 = str.Split(';', ',', '.');
            foreach(var name in result1)
            {
                Console.WriteLine(name);
            }
        }

        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach(var item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}
