using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldSample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Student stu1 = new Student();
               stu1.Age = 40;
               stu1.Score = 90;

               Student stu2 = new Student();
               stu2.Age = 24;
               stu2.Score = 90;
               Student.ReportAmount(); */

            List<Student> stuList = new List<Student>();
            for(int i = 0; i < 100; i++)
            {
                Student stu = new Student();
                stu.Age = 24;
                stu.Score = i;
                stuList.Add(stu);
            }
            Student.ReportAmount();

            int totalAge = 0;
            int totalScore = 0;
            foreach(var stu in stuList)
            {
                totalAge += stu.Age;
                totalScore += stu.Score;
            }
            Student.AverageAge = totalAge / Student.Amount;
            Student.AverageScore = totalScore / Student.Amount;
            Student.ReportAverageAge();
            Student.ReportAverageScore();

            Student stu1 = new Student(453);
            Console.WriteLine("This student's ID：",stu1.ID);
           // stu1.ID = 222;  所以 readonly  fields  只能被初始化，不能被重新修改赋值
           
        }
        class Student
        {
            //对于 readonly的字段，只能 进行初始化，不能被重新赋值
            public readonly int ID;

            public int Age;
            public int Score;

            public static int AverageAge; 
            public static int AverageScore;
            public static int Amount;  

            public Student(int id)
            {
                this.ID = id;
                //readonly 的成员 只能在 构造器里声明变量，一旦被赋值完，这个ID 就再也不能改动了
            }
            
            static Student() //静态构造器 会在 环境加载时执行，而且只执行一次
            {
                //而且也可以在静态构造器里面初始化 静态字段
                //  Student.Amount = 100;
            }
           
            public Student()  //默认构造器
            {
                Student.Amount++;
            }

            public static void ReportAmount()
            {
                Console.WriteLine(Student.Amount);
            }

            public static void ReportAverageAge()
            {
                Console.WriteLine(Student.AverageAge);
            }
            public static void ReportAverageScore()
            {
                Console.WriteLine(Student.AverageScore);
            }
        }
    }
}
