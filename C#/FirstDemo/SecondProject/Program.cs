using System;

namespace SecondProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {



            //空结合运算符
            //表达式1 ？？表达式2
            String fileName = null;
            fileName = fileName ?? "default.txt";
            Console.WriteLine(fileName);
           


            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("最大的数字是{0}: ",a > b?(a > c ? a : c):(b > c ? b : c) );
            //Console.WriteLine("最大的数字:{0}", a > b ? a :b);
           


            //bool isAmorethanB = a > b;
            //if(isAmorethanB){
            //    Console.WriteLine("{0} > {1}", a, b);
            //}else
            //{
            //    Console.WriteLine("{0}<= {1}", a, b);
            //}



            //bool exp = 1 == 2 && 2 > 2;
            //if (exp)
                //Console.Read();


            //int a = int.Parse(Console.ReadLine());
           
            //if(a >10){
            //    Console.WriteLine("a大于10");
            //}else{
            //    Console.WriteLine("a小于10");
            //}
            //Console.Read();
        }
    }
}
