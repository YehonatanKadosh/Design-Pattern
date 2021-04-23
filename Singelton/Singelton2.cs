namespace Singelton
{
    // Big projects with multythreading
    class Singelton2
    {
        public int Counter2 { get; set; }
        readonly static object obj = new object();
        private static Singelton2 instance;
        public static Singelton2 Instance
        {
            get
            {
                lock (obj)
                    if (instance == null)
                        instance = new Singelton2();
                return instance;
            }
        }
        private Singelton2() { }//Lock the creation of instances
    }
}
