using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {1,2,3,4,5,6,7,8};

            // regard the Interface as the class and to create an object
            IEnumerator enumerator = intArray.GetEnumerator();
            //因为array类实现了IEnumerator 这个接口，所以天然继承 IEnumerator接口的所有方法
            //所以可以调用 IEnumerator 里的 GetEnumerator() 方法
            //而 int类型的 array 又是 子类，所以他也拥有 GetEnumerator()方法

           /*  while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            } */


           List<int> intList = new List<int>() {1,2,3,4,5,6,44,3};
            IEnumerator enumerator1 = intList.GetEnumerator();
           /* while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);  // enumerator1.Current  是调用IEnumerator里的 属性 
            }

            enumerator1.Reset();
            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current);
            }
            */
            
            foreach(var current in intList)
            {
                Console.WriteLine(current);
            }
        }
    }
}
