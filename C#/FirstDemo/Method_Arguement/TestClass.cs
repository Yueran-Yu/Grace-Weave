using System;
using System.Collections.Generic;
namespace Method_Arguement
{
    public class TestClass
    {
        public TestClass()
        {
            
        }

        public static void Add(List<int> list, out String abc){
            list.Add(2);
            abc = "hehahhaha";
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;
        }

        public static double Average(List<int> app)
        {
            int sum = 0;
            //int counter = 0;
            foreach(var li in app){
                sum += li;
                //counter++;
            }
            return (double)sum / app.Count;
        }
    }
}
