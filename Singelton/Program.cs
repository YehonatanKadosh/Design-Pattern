using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singelton1.Instance.Counter1 = 1; //Create Singelton1.Instance and set Counter1 = 1
            Singelton2.Instance.Counter2 = 2; //Create Singelton2.Instance and set Counter2 = 2
            Console.WriteLine(Singelton1.Instance.Counter1 + Singelton2.Instance.Counter2); //3
        }

        // Small projects where there's less Risk with multythreading
        class Singelton1
        {
            public int Counter1 { get; set; }
            public static Singelton1 Instance { get; } = new Singelton1();
            private Singelton1() { }//Lock the creation of instances
        }

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
}
