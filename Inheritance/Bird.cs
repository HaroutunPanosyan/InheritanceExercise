using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        
        public enum WingSpan
        {
            Short, Medium, Long, Massive
        }
        public bool CanFly { get; set; }
        public enum BeakType
        {
            Straight, Curved
        }
        public string FeatherColor { get; set; }

    }
}
