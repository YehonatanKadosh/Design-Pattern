using System;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Small projects where there's less Risk with multythreading
            Singelton1.Instance.Counter1 = 1; //Create Singelton1.Instance and set Counter1 = 1

            // Big projects with multythreading (basic lock() safety)
            Singelton2.Instance.Counter2 = 2; //Create Singelton2.Instance and set Counter2 = 2

            // Big Project with double checked lock
            Singelton3.Instance.Counter3 = 3; //Create Singelton1.Instance and set Counter3 = 3

            // Big Project with double checked lock and Volatile use in case creating the instance takes time
            Singelton4.Instance.Counter4 = 4; //Create Singelton2.Instance and set Counter4 = 4

            Console.WriteLine(Singelton1.Instance.Counter1 + Singelton2.Instance.Counter2
                              + Singelton3.Instance.Counter3 + Singelton4.Instance.Counter4); //10
        }

        /// Searching the diffrences between Lock(obj) and Synchronized(obj):
        /// 
        /// From Microsoft Core Execution Engine (EE)-
        /// If you lock an object, all other threads that need to access THIS PARTICULAR OBJECT will wait,
        /// until the other object finishes.
        /// However if you mark a method as Synchronized,
        /// THIS PARTICULAR METHOD will not be executed at more than one thread.
        /// 
        //  --Lock secures the object, Synchronized secures the method.--
    }
}
