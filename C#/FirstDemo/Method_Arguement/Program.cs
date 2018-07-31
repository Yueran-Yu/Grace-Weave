using System;
using System.Collections.Generic;

namespace Method_Arguement  //namespace 是不同程序的一种划分
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            Console.Write("What's your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("In what city were you born?");
            string city = Console.ReadLine();
           
            DisplayResult(ReverseString(firstName), 
                          ReverseString(lastName), 
                          ReverseString(city));
            
            Console.WriteLine();
        }

        private static string ReverseString(string message){
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            return String.Concat(messageArray);
        }
        private static void DisplayResult(string reversedName, 
                                          string reversedLastName,
                                          string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}",
                                        reversedName,
                                        reversedLastName,
                                        reversedCity));
        }

        private static void DisplayResult(string message){
            Console.Write("Results: ");
            Console.Write(message);
        }


        //string zig = "ad wg sdfsd dfaf ewgeg sdfs d";
        //char[] chArray = zig.ToCharArray();
        //Array.Reverse(chArray); //反转

        //foreach(char zigchar in chArray){
        //    Console.Write(zigchar);
        //}
        //Console.ReadLine();


        //for (int i = 0; i < 10; i++)
        //{
        //    if (i == 7)
        //    {
        //        Console.WriteLine("Found seven!");
        //        break;
        //    }
        //}
        //Console.ReadLine();

        //string x;
        //var list = new List<int>();
        //list.Add(3);
        //TestClass.Add(list, out x);

        //foreach(var i in list){
        //    Console.WriteLine(i);
        //}
        //Console.Read();


        //int a = 1;
        //int b = 3;
        //TestClass.Swap(ref a, ref b);
        //Console.WriteLine("a={0} b={1}", a, b);

        //var list = new List<int>();
        //list.Add(1);
        //list.Add(2);
        //list.Add(8);
        //list.Add(4);
        //list.Add(6);

        //Console.WriteLine(TestClass.Average(list));

        //Console.WriteLine(TestClass.Average());

    }
} 
