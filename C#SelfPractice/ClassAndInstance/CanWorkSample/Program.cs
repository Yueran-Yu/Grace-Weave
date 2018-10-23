using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanWorkSample
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu = new Student();
            stu.Age = 19;
            Console.WriteLine(stu.CanWork);
        }
    }

    class Student
    {
        private int age;
        // property Age
        public int Age
        {
            get { return age; }            
            set { age = value;
                this.CalculateCanWork();
            }                                      
        }

        //property CanWork
       /* public bool CanWork
        {
            get
            {
                if (this.age >=16)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }*/

        private bool canWork;

        //property  CanWork
        public bool CanWork
        {
            get { return canWork; }         
        }

        //method CalculateCanWork 注意此方法为  private！
        private void CalculateCanWork()
        {
            if(this.age >= 16)
            {
                this.canWork = true;
            }
            else
            {
                this.canWork = false;
            }
        }
    }
}
