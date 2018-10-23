using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Event Sender and Event Subsubscriber are the same one.

namespace EventExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Event Sender and Event Subscriber
            MyForm form = new MyForm();
            form.Click += form.FormClicked;
          

            form.ShowDialog();
        }
    }

    //继承
    class MyForm : Form
    {
        //Event Handler
        internal void FormClicked(object sender, EventArgs e)
        {
            this.Text = DateTime.Now.ToString();
        }
    }
}
