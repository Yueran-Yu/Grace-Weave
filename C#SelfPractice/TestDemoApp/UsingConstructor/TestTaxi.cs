using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstructor
{
    class TestTaxi
    {
        static void Main(string[] args)
        {
            Taxi t = new Taxi();
            Console.WriteLine(t.isInitialized);

            int a = 44; //Initialize the value type...
            int b;
            b = 33;    // Or assign it before using it.
            Console.WriteLine("{1} {0}", b, a);

            Employee e1 = new Employee(30000);
            Employee e2 = new Employee(500, 52);
        }
    }
}
