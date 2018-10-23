using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterExample1
{
    //传值参数，引用类型，只操作对象，不创建对象
    //提醒：在现实工作当中，通过传进来的参数修改他引用类对象值的情况比较少见
    //因为作为一个方法而言，他的主要输出还是靠return值
    //一般情况下我们把这种修改参数和引用对象的值得操作，叫做某个方法的副作用 side-effect
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() {Name="Tim"};
            Update(stu);
            Console.WriteLine("HashCode={0}, Name={1}", stu.GetHashCode(), stu.Name);
        }

        static void Update(Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("HashCode={0}, Name={1}",stu.GetHashCode(),stu.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}
