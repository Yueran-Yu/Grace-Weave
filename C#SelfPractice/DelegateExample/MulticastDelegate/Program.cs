using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MulticastDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow};
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Magenta};

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            // action1.Invoke();
            // action2.Invoke();
            // action3.Invoke();

            //用一个委托封装多个方法的使用方式，就叫做多播委托
            //多播委托执行顺序，是按照你封装方法的先后顺序来执行的
            action1 += action2;
            action1 += action3;

            action1.Invoke();
        }
    }

    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
          for(int i =0; i <5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} do homework {1} hour(s).",this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
