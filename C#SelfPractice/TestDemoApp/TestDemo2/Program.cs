using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo2
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var gen = new NumberGenerator();
            int index = 9;                      
            try
            {
                int value = gen.GetNumber(index);
                Console.WriteLine($"Retrieved {value}");
            }catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"{e.GetType().Name}: {index} is outside the bounds of the array");
            }
                // The example displays the following output:
                //        IndexOutOfRangeException: 10 is outside the bounds of the array

            var s = new Sentence(null);
            Console.WriteLine($"The first character is {s.GetFirstCharacter()}");
            // The example displays the following output:
            //    Unhandled Exception: System.NullReferenceException: Object reference not set to an instance of an object.
            //       at Sentence.GetFirstCharacter()
            //       at Example.Main()
        }
    }
}

