using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WhoIsWho("Mr.Hello"));
        }

        static string WhoIsWho(string alias)
        {
            if(alias == "Mr.Okay")
            {
                return "Tim";
            }
            else
            {
                return "I don't know";
            }
        }
        static void Greeting(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return;
            }
            Console.WriteLine("Hello, {0}", name);
        }
    }
}
