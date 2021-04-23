using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Wrong way, right implementation
            Prototype1 Prototype1_0 = new Prototype1() { Counter = 3 };
            Prototype1 prototype1_1 = (Prototype1)Prototype1_0.Clone();

            //Right way, right implementation
            Prototype2 Prototype2_0 = new Prototype2() { Counter = 3 };
            Prototype2 prototype2_1 = (Prototype2)Prototype1_0.Clone();
        }

        /// <summary>
        /// Wrong way to clone,
        /// messy and not comfy
        /// </summary>
        public class Prototype1 : ICloneable
        {
            public int Counter { get; set; }
            public object Clone()
            {
                return new Prototype1() { Counter = this.Counter /* more and more properties and fields */};
            }
        }

        /// <summary>
        /// Best practice,
        /// this is the right way
        /// </summary>
        public class Prototype2 : ICloneable
        {
            public int Counter { get; set; }
            public object Clone()
            {
                return MemberwiseClone(); //Create a shallow copy of the object
            }
        }
    }
}
