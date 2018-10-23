using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingConstructor
{
    public class Manager : Employee
    {
        public Manager(int annualSalary) : base(annualSalary)
        {

        }

    }
}


/* public Manager(int initialdata)
 * { //Add futher instructions here.}
 * 
 * equals below
 * 
 * public Manager(int initialdata) : base()
 * { //Add futher instructions here.}
 * 
 * If a base class does not offer a default constructor,
 * the derived class must make an explicit call to a base constructor by using base.
 */
