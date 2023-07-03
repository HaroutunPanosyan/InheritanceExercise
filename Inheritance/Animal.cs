using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common

        public int NumOfLegs { get; set; }
        public bool HasToes { get; set; }
        public int NumOfToes(int numToes)
        {
            if (HasToes)
            {
                return numToes;
            }
            else
            {
                return 0;
            }
        }
        public enum TailLength
        {           
            No, Short, Medium, Long            
        }

    }
}
