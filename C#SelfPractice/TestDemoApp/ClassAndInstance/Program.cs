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
            //(new Form()).Text = "My Form"; //这是第一个对象
            //(new Form()).ShowDialog(); // 其实这里又创建了一个对象

            //引用变量,
            Form myForm1;
            Form myForm2;
            Form myForm3;
            myForm1 = new Form(); 
            //这里只有一个实例，所以可以无论有多少直接或间接的引用变量，修改的总是这里实例的值
            myForm2 = myForm1;
            myForm3 = myForm2;
            myForm1.Text = "My From";
            myForm2.Text = "Science hhhhh";
            myForm3.Text = "Harry Potter";
            myForm1.ShowDialog();
            //多个小孩牵着同一个气球
        }
    }
}
