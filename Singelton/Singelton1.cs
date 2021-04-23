namespace Singelton
{
    // Small projects where there's less Risk with multythreading
    class Singelton1
    {
        public int Counter1 { get; set; }
        public static Singelton1 Instance { get; } = new Singelton1();
        private Singelton1() { }//Lock the creation of instances
    }
}
