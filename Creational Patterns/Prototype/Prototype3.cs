using System;

namespace Prototype
{
        /// <summary> - Deep Clone
        /// Right way
        /// </summary>
        public class Prototype3 : ICloneable
        {
            public IceCream Ice_Cream { get; set; } = new IceCream();
            public int Counter { get; set; }
            public object Clone()
            {
                Prototype3 DeepClone = (Prototype3)MemberwiseClone();// Create a shallow copy of the object
                DeepClone.Ice_Cream = new IceCream() { Price = this.Ice_Cream.Price };// Create new Instance for refference-Type
                return DeepClone;
            }
        }
    
}
