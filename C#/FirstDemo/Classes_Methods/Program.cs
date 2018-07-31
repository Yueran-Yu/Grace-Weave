using System;

namespace Classes_Methods
{
    class MainClass
    {
        private static string k = " "; 
        // k is a sibling of 'static Main'
        // and 'static void HelpMethod'

        public static void Main(string[] args)
        {
            string j = " ";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                  //Console.WriteLine(l);
            }

            Console.WriteLine("eeee {0}",j);
            Console.WriteLine("eeee {0}", k);
           
            HelperMethod();
            Car myCar = new Car();
            myCar.DoSomething();

            Console.WriteLine();
        }


        static void HelperMethod(){
            Console.WriteLine("value of k from the HelpMethod(): " + k);
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());
            }

            private string helperMethod()
            {
                return "Hello world!";
            }
        }
    }
}
