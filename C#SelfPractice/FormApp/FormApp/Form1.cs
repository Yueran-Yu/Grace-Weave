using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
            this.mybutton.Click += this.ButtonClick;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            this.myTextBox.Text = "Hello World.";
                }
    }
}
