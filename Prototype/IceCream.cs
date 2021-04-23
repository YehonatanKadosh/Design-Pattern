using System;

namespace Prototype
{
    public class IceCream : ICloneable { public int Price { get; set; }

        public object Clone()
        => MemberwiseClone();
    }// Refference-Type object
}
