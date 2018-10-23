using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class Adult : Person
    {
        private static int minimumAge;
        public Adult(string lastName, string firstName) : base(lastName, firstName)
        {

        }
        
        //A class or struct can also have a static constructor
        //which initializes static members of the type
        //static constructors are parameterless
        static Adult()  
        {
            minimumAge = 18;
        }
    }
}
