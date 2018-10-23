using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDefineDelegate
{
    //因为委托是一种类，所以应该将其声明在 namespace里面，所以是跟program类 平级
    //delegate里的double是目标方法的返回值类型
    public delegate double Calc(double x, double y);
    class Program
    {
        static void Main(string[] args)
        {
            // Type t = typeof(Action);
            // Console.WriteLine(t.IsClass);

            Calculator calculator = new Calculator();
            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Mul);
            Calc calc4 = new Calc(calculator.Div);

            double a = 100;
            double b = 200;
            double c = 0;
            c = calc1.Invoke(a, b);
            Console.WriteLine(c);
            c = calc2.Invoke(a, b);
            Console.WriteLine(c);
            c = calc3.Invoke(a, b);
            Console.WriteLine(c);
            c = calc4.Invoke(a, b);
            Console.WriteLine(c);



        }
    }

    class Calculator
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }

        public double Sub(double a, double b)
        {
            double result = a - b;
            return result;
        }
        public double Mul(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double Div(double a, double b)
        {
            double result = a/b;
            return result;
        }
    }
}
