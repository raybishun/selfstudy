using System;

namespace DelegatesViaNamedMethods
{
    class HelperClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine("InstanceMethod() invoked...");
        }

        static public void StaticMethod()
        {
            Console.WriteLine("StaticMethod() invoked...");
        }
    }
}
