using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int y = 100;
            stu.AddOne(y); //改变的是copy版本的值，因此不会影响到方法体外部的值
            Console.WriteLine(y);

            //alt + enter  键修改所有相同的名称
            Student deete = new Student() {Name = "Tim" };
            ExampleMethod(deete);
            Console.WriteLine("{0}:{1}",deete.Name,deete.GetHashCode());        
        }

        static void ExampleMethod(Student stu)
        {
            //一般情况下为引用变量赋值，赋值号的右边都是 右操作符的表达式
            //右操作符的作用就是根据数据类型创建对象，并且调用对象的实例构造器
            //然后再把实例在堆内存上的地址通过赋值符号交给我们的引用变量
            //以下操作是对我们的stu参数 赋了一个新对象的地址，也就是把一个新对象交给这个参数去引用
            //这不会影响到方法外部的变量，也就是说，该方法外部的变量，仍然引用的先前的对象
            stu = new Student() {Name = "Tim"};
            Console.WriteLine("{0}:{1}", stu, stu.GetHashCode());

        }
    }
    class Student
    {
        //值类型的传值参数 value parameter
        public void AddOne(int x)
        {
            x = x + 1;
            Console.WriteLine(x); //完成对方法声明
        }

        public string Name { get; set; }
    }
}
