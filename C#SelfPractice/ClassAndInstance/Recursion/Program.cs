using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Program v = new Program();
            v.PrintXTo(10);

            Calculator c = new Calculator();
            int result = c.SumFrom1ToX(100);
            Console.WriteLine(result);
        }
    

    public void PrintXTo(int x)
    {
            if(x==1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXTo(x-1);
            }
    }

        class Calculator
        {
            public int SumFrom1ToX(int x)
            {
                //int result = 0;
                //for(int i = 1; i < x+1; i++)
               // {
                //    result = result +i;
               // }
               // return result;


                if(x == 1)
                {
                    return 1;
                }
                else 
                {
                    int result = x + SumFrom1ToX(x - 1);
                    return result;
                }
            }
        }
    }
}
