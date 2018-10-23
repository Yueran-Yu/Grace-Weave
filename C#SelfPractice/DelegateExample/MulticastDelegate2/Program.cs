using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MulticastDelegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student() { ID = 1, PenColor = ConsoleColor.Yellow };
            Student stu2 = new Student() { ID = 2, PenColor = ConsoleColor.Green };
            Student stu3 = new Student() { ID = 3, PenColor = ConsoleColor.Magenta };

            /*stu1.DoHomework();
            stu2.DoHomework();
            stu3.DoHomework();*/

            Action action1 = new Action(stu1.DoHomework);
            Action action2 = new Action(stu2.DoHomework);
            Action action3 = new Action(stu3.DoHomework);

            // action1.Invoke();
            // action2.Invoke();
            // action3.Invoke();

            //多播委托同步
            // action1 += action2;
            // action1 += action3;
            // action1.Invoke();
            
            //隐式异步，线程是由BeginInvoke 自动生成的
            action1.BeginInvoke(null,null);
            action2.BeginInvoke(null, null);
            action3.BeginInvoke(null, null);


            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main thread {0}.", i);
                Thread.Sleep(1000);
            }
        }
    }
    class Student
    {
        public int ID { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomework()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Student {0} do homework {1} hour(s).", this.ID, i);
                Thread.Sleep(1000);
            }
        }
    }
}
