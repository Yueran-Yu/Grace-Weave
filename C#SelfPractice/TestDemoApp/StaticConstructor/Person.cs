using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class Person
    {
        private string last;
        private string first;

        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }

    }
}
