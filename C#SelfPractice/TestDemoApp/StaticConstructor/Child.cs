using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Child : Person
    {
        private static int maximumAge;

        public Child(string lastName, string firstName) : base(lastName, firstName)
        { }

        static Child() => maximumAge = 18;
    }
}
