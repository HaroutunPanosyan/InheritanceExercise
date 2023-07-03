using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool HasScales { get; set; }
        public string ScaleColor { get; set; }
        public bool CanCamo { get; set; }
        public bool CanSwim { get; set; }
    }
}
