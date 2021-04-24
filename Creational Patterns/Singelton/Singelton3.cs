namespace Singelton
{
    // Big Project with double checked lock
    class Singelton3
    {
        public int Counter3 { get; set; }
        readonly static object obj = new object();
        private static Singelton3 instance;
        public static Singelton3 Instance
        {
            get
            {
                if (instance == null)
                    lock (obj)
                        if (instance == null)
                            instance = new Singelton3();
                return instance;
            }
        }
        private Singelton3() { } //Lock the creation of instances
    }
}
