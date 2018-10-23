using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); //有了实例才能调用委托方法
            Action action = new Action(calculator.Report);
            //encapsulates a method that has no parameters and does not return a value
            //Action()的提示为了告诉你，Action能指向什么样的目标方法，这里需要放入一个 无参数，无返回值 的方法,只有Report符合要求
            //Action(calculator.Report)这里的Report不加括号，因为仅仅需要这个方法的名字
            //若果加了括号，意思就是调用Report()方法了
            //现在，我们就已经让 Action这个委托指向 calculator.Report 这个方法了

            //直接调用Report()方法
            calculator.Report();

            //间接调用Report()方法
            action.Invoke();

            //以下为简便的写法，这是为了模仿函数指针的书写格式
            action();

            //Func<>s是泛型委托 Generic Delegate, 能够指向Add和Sub方法的Delegate
            //语法解释：2个int参数 + int返回值
            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);
            int x = 100;
            int y = 200;
            int z = 0;
            z = func1.Invoke(x,y); //函数指针式写法：z=func1(x,y);
            Console.WriteLine(z);
            z = func2.Invoke(x,y); //函数指针式写法：z=func2(x,y);
            Console.WriteLine(z);
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Sub(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
