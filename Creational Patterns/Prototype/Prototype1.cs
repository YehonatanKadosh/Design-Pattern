using System;

namespace Prototype
{
        /// <summary>
        /// Wrong way to clone,
        /// messy and not comfy
        /// </summary>
        public class Prototype1 : ICloneable
        {
        public IceCream Ice_Cream { get; set; } = new IceCream();
            public int Counter { get; set; }
            public object Clone() => new Prototype1()
            {
                Counter = this.Counter,
                Ice_Cream = new IceCream() { Price = this.Ice_Cream.Price }
                /* more and more properties and fields */
            };
        }
}
