using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class Location
    {
        private string locationName;
        public Location(string name) => Name = name;
        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }
}
