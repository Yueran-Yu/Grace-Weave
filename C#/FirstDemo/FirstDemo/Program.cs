using System.Text;
using System;
using System.Diagnostics;

namespace FirstDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var str1 = Console.ReadLine();
            var str2 = Console.ReadLine();
            int a1 = int.Parse(str1); 

            if(int.TryParse(str1, out a1)){
                Console.WriteLine(a1);
            }else{
                Console.WriteLine("解析失败。");
            }

            //int a2 = int.Parse(str2); 
            //Console.WriteLine(a1 + a2);


            // 该程序溢出
            //int a;
            //checked
            //{
            //    a = int.MaxValue;
            //    a = a + 1;
            //}
            //Console.WriteLine(a);





            //Stopwatch counter = new Stopwatch();
            //counter.Start();

            //String str = string.Empty;
            //for (int i = 0; i < 10000; i++){
            //str += i.ToString();
            //}


            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < 10000; i++){
            //    sb.Append(i.ToString());
            //}
            //counter.Stop();
            //Console.WriteLine(counter.ElapsedMilliseconds);
           



            // var就是系统自动识别你的变量是什么类型
            //var number = 1;

            //double num = 1.23456789123456789;
            //Console.WriteLine(num);
            //String str1 = "123\\t123";
            //String str2 = "1234\t123";
            //String str3 = @"F:123.txt\ee\123";
            //String str4 = "abc";
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(str4.ToUpper());


            //Console.WriteLine("I really happy I can use this tool!");
            //Console.WriteLine(Add(2, 3));


            //String name;
            //System.Console.Write("你的名字是：");
            //name = System.Console.ReadLine();
            //System.Console.WriteLine("我的名字：{0}",name);
        }

        //public static int Add(int a, int b)
        //{
        //    return a + b;
        //}
    }
}
