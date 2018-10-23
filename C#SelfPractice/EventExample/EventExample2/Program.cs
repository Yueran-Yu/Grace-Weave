using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//该例演示了 Event sender 和 Event Subscriber  分别是不同的类的 操作


namespace EventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Event sender
            Form form = new Form();

            //Event responser
            Controller controller = new Controller(form);

            form.ShowDialog();
            
        }
    }

    class Controller
    {
        private Form form;  

        //该 constructor 只是进行判断 form合不合格
        public Controller(Form form)
        {          
            if(form != null)  //判断是否为空的原因，因为一个对象为空的话，我们无法访问其事件
            {
                this.form = form;           
                this.form.Click += this.FormClicked;   //为form的click事件 添加一个事件处理器
              //Event-click  subscribe+=   Event Handler    
            }
        }

        /*
         Click 事件和 Elapsed事件 的处理方式是不一样的
         也就是说，你不能拿影响事件的Event handler器去响应Click事件
         -----因为遵循的约束不同，所以他们不能通用
         */
         //Event Handler
        private void FormClicked(object sender, EventArgs e)
        {
            //让form 的标题栏显示时间
            this.form.Text = DateTime.Now.ToString();
        }
    }
}
