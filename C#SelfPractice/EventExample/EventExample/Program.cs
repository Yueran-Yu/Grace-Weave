using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
/*
 对于一个类来说，最重要的三类成员：
 属性：存储数据，表示该 对象 或 类 处于何种状态
 事件：通知别人，表示他能在什么情况下通知谁
 方法：做具体事，表示 具体操做的什么事情
*/

    //该实例演示了 ①什么是事件？ ②事件怎么使用？
namespace EventExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Event Sender
            Timer timer = new Timer();
            timer.Interval=1000;

            //Event Subscriber
            Boy boy = new Boy();
            Girl girl = new Girl();

            //订阅事件 subscribe     
            //快捷键：Crtl + command + . + enter      
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            //左边：事件       右边：事件处理器

            timer.Start();
            Console.ReadLine();

        }
    }

    //事件响应者 类 
    class Boy
    {
        //事件处理器
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }

    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
