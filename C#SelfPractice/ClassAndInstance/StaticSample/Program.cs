using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello!");
            //Form form = new Form();
            // form.Text = "Hello";
            // form.ShowDialog();

            var x = 3;
            Console.WriteLine(x.GetType().Name);
            var y = 3L;
            Console.WriteLine(y.GetType().Name);
            var z = 3.3m;
            Console.WriteLine(z.GetType().Name);
        }
    }
}
