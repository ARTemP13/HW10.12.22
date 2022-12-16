using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov_2
{
    internal class BuildingInfoAttribute: Attribute
    {
        
            public string Name { get; set; }
            public string Organization { get; set; }
            public BuildingInfoAttribute() { }
            public BuildingInfoAttribute(string Name, string Organization)
            {
                this.Name = Name;
                this.Organization = Organization;
            }
        
    }
}
