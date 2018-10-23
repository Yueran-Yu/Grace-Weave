using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            // (new Form()).ShowDialog();
            Form myForm = new Form();
            myForm.Text = "My Form!";
            myForm.ShowDialog();
         
        }
    }
}
