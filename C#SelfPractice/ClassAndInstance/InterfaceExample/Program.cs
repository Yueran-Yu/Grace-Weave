using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[] { 1, 2, 3, 4, 5, 6 };
            ArrayList num2 = new ArrayList { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(Sum(num1));
            Console.WriteLine(Avg(num1));
            Console.WriteLine(Sum(num2));
            Console.WriteLine(Avg(num2));
        }

        //因为 int[]数组和 ArrayList都 继承 IEnumerable的接口
        //所以，一下方法体 的 parameter  类型就可以统一的用 IEnumerable
        static int Sum(IEnumerable nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }

        static double Avg(IEnumerable nums)
        {
            int sum = 0;
            int count = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                count++;
            }
            return sum / count;
        }
        /*static int Sum(int[] nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += n;
            }
            return sum;
        }

        static double Avg(int[] nums)
        {
            int sum = 0;
            int count = 0;
            foreach(var n in nums)
            {
                sum += n;
                count++;
            }
            return sum / count;
        }*/

        //ArrayList 里面存储的元素时 Object类型，所以需要强制类型转换
        /*static int Sum(ArrayList nums)
        {
            int sum = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
            }
            return sum;
        }

        static double Avg(ArrayList nums)
        {
            int sum = 0;
            int count = 0;
            foreach (var n in nums)
            {
                sum += (int)n;
                count++;
            }
            return sum / count;
        }*/
    }
}
