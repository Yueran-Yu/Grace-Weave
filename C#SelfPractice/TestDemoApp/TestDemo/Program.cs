using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x = 0.99m;
            decimal y = 999999999999999999m;
            Console.WriteLine("My amount = {0:C}", x);
            Console.WriteLine("Your amount = {0:C}", y);

        }


    }
}
