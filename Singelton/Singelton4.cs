namespace Singelton
{
    // Big Project with double checked lock and Volatile use in case creating the instance takes time
    /// <summary>
    /// Threads Won't be able to proceed until the instance is made completly
    /// 1. Construct an empty resource
    /// 2. Assign to instance -- Danger of another thread using the incomplete instance (Solved by volatile)
    /// 3. Call the constructor
    /// </summary>
    class Singelton4
    {
        public int Counter4 { get; set; }
        readonly static object obj = new object();
        private static volatile Singelton4 instance;
        public static Singelton4 Instance
        {
            get
            {
                if (instance == null)
                    lock (obj)
                        if (instance == null)
                            instance = new Singelton4();
                return instance;
            }
        }
        private Singelton4() { } //Lock the creation of instances
    }
}
