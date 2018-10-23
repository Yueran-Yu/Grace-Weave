using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//最广泛的应用
// Event Sender is a field member of Event Subscriber 
// Event subscriber use a method to subscribe an evnet of one of its own field members
namespace EventExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyForm form = new MyForm();
            form.ShowDialog();

        }
    }

    class MyForm : Form
    {
        private TextBox textBox;

        //Event Sender
        private Button button;

       //constructor
        public MyForm()
        {

            this.textBox = new TextBox();
            this.button = new Button();

            this.Controls.Add(button);
            this.Controls.Add(textBox);

            this.button.Click += this.ButtonClicked;
            //Event:Click      Subscriber: the object of MyForm  MyForm的对象 是响应者
            //Handler: ButtonClicked
            this.button.Text = "Button";
            this.button.Top = 100;
        }

        private void ButtonClicked(object sender, EventArgs e)
        {
            this.textBox.Text = "Hello World.hahahhahahahhahahah";
        }
    }
}
