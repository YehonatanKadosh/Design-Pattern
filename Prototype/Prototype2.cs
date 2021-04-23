using System;

namespace Prototype
{
    /// <summary> - Shallow clone
    /// this is Half right way
    /// </summary>
    public class Prototype2 : ICloneable
    {
        public IceCream Ice_Cream { get; set; } = new IceCream();
        public int Counter { get; set; }
        public object Clone() => MemberwiseClone(); //Create a shallow copy of the object
    }

    /// The MemberwiseClone method creates a shallow copy by creating a new object,
    /// and then copying the nonstatic fields of the current object to the new object.
    /// If a field is a value type, a bit-by-bit copy of the field is performed.
    /// If a field is a reference type, the reference is copied but the referred object is not;
    //  - therefore, the original object and its clone refer to the same object. -

}
