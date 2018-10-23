using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersExample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = null;
            bool b = StudentFactory.Create("Tim",34, out stu);
            if(b == true)
            {
                Console.WriteLine("Student {0} , age is {1}.",stu.Name,stu.Age);
            }
        }
    }
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class StudentFactory
    {
        //一下方法接收传入的两个参数
        //参数一：传入的 stuName，参数二：传入的stuAge，参数三：输出参数 result 类型为Student
        //逻辑：当传入的 stuName不为空和 stuAge 大于20，小于80，我们就可以创建Student 对象
        //并且此时可以将传入的stuName,stuAge 赋给我创建出来的Student实例的property
        public static bool Create(string stuName, int stuAge, out Student result)
        {
            result = null;
            if (string.IsNullOrEmpty(stuName))
            {
                return false;
            }
            if(stuAge < 20 || stuAge > 80)
            {
                return false;
            }
            result = new Student() {Name = stuName, Age = stuAge};
            return true;
        }
    }
}
