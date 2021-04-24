namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wrong way, right implementation
            Prototype1 prototype1_0 = new Prototype1() { Counter = 1 };
            Prototype1 prototype1_1 = (Prototype1)prototype1_0.Clone();
            prototype1_1.Counter++;
            /// Prototype1_0.Counter = 1
            /// Prototype1_1.Counter = 2 - Good but messy



            // Half Right way, right implementation Shallow clone
            Prototype2 prototype2_0 = new Prototype2() { Counter = 3 };
            Prototype2 prototype2_1 = (Prototype2)prototype2_0.Clone();
            prototype2_1.Counter++;
            /// Prototype2_0.Counter = 3
            /// Prototype2.1.Counter = 4

            prototype2_0.Ice_Cream.Price = 10;
            /// Prototype2_0.Ice_Cream.Price = 10
            /// Prototype2_1.Ice_Cream.Price = 10 - BAD!



            // Right way, right implementation Deep clone
            Prototype3 prototype3_0 = new Prototype3() { Counter = 5 };
            Prototype3 prototype3_1 = (Prototype3)prototype3_0.Clone();
            prototype3_1.Counter++;
            /// Prototype3_0.Counter = 5
            /// Prototype3.1.Counter = 6

            prototype3_1.Ice_Cream.Price = 10;
            /// Prototype3_0 Ice_Cream.Price = 0
            /// Prototype3_1 Ice_Cream.Price = 10 - Best!
        }
    }
}
