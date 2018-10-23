using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 100;
            bool b = DoubleParser.TryParse("aaa", out x);
            if(b==true)
            {
                Console.WriteLine(x+1);
            }
            else
            {
                Console.WriteLine(x);
            }
        }
    }
    class DoubleParser
    {
        //仿照 try parse的方法，也声明一个TryPase的方法
        //参数一：我们传入的字符串，参数二：我们需要输出的参数
        public static bool TryParse(string input, out double result)
        {
            //bool类型的返回值用于告诉调用者，本次解析是否成功
            //如果成功，我们就用double类型的输出参数把值 传递出来 
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;

            }
        }
    }
}
