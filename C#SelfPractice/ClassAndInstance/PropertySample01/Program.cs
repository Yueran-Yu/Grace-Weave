using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertySample01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student.Amount = -100;
                Console.WriteLine(Student.Amount);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Student stu1 = new Student();
            stu1.Age = 20;
            Student stu2 = new Student();
            stu2.Age = 20;
            Student stu3 = new Student();
            stu3.Age = 200;

            int avgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
            Console.WriteLine(avgAge);
        }
    }

    class Student
    {
       /* private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
             {
                if(value >= 0 && value <= 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Age value has error.");
                }
            }*/
        
        /* public int GetAge()
         {
             return this.age;
         }
         public void SetAge(int value)
         {
             if(value >= 0 && value <= 120)
             {
                 this.age = value;
             }
             else
             {
                 throw new Exception("Age value has error.");
             }
         }*/

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private static int amount;
        public static int Amount
        {
            get { return amount; }
            set
            {
                if(value >= 0)
                {
                    Student.amount = value;
                }
                else
                {
                    throw new Exception("Amount must greater than 0.");
                }
            }
        }

    }
}
