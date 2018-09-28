using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo2
{
   public class Sentence
    {
        public Sentence(string s) // Constructor
        {
            Value = s;
        }
        public string Value { get; set;} // Property


        public char GetFirstCharacter() //method
        {
            try
            {
                return Value[0];
            }
            catch (NullReferenceException e)
            {
                throw;
            }
        }

    }
}
