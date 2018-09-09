using System;
using System.Text;

namespace String
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life.";
            //string myString = "What if I need a\nnew line?";
            //string myString = "Go to your c:\\ drive";
            //string myString = @"Go to your c:\ drive";
            //string myString = string.Format("{1} = {0}","First", "Second");
            //string myString = string.Format("{0:C}", 123.45);
            string myString = string.Format("{0:C}", 12.34566788);
            //string myString = string.Format("Percentage:{0:P} ", .123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 123456785);
            //string myString = "Today is a nice day.  ";
            //myString = myString.Substring(6, 12);
            //myString = myString.ToUpper();
            //myString = myString.Replace("a", "--");
            //myString = myString.Remove(6, 14);
            //myString = string.Format("Length before: {0} -- Length after: {1}", 
            //myString.Length, 
            //myString.Trim().Length);
            //string myString = "";
            //for (int i = 0; i < 100; i++){
            //    myString += "--" + i.ToString();
            //}

            // StringBuilder myString = new StringBuilder();
            // {
            //     for (int i = 0; i < 100; i++)
            //     {
            //         myString.Append("--");
            //         myString.Append(i);
            //     }

            // }
            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
