using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class DeveloperInfoAttribute: Attribute
    {
        public string NameDeveloper { get; set;  }
        public string DateDevelop { get; set; }
        public DeveloperInfoAttribute() { }
        public DeveloperInfoAttribute(string name, string date)
        {
            NameDeveloper = name;
            DateDevelop = date;
        }
    }
}
