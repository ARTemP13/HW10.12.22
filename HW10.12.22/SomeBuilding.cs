using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10._12._22
{
    internal class SomeBuilding
    {
        public Building[] buildings;
        public SomeBuilding(Building[] build)
        {
            this.buildings = build;
        }
        public Building this[int i]
        {
            get => buildings[i];
            set => buildings[i] = value;
        }
    }
}
