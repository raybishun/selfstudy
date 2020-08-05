using System;

namespace LambdaExpressionsWithDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeDelegateByAnonymousFunction();
        }

        static void InvokeDelegateByAnonymousFunction()
        {
            // Named Method Example
            StringDelegate sd = HelperClass.StringMethod;
            sd("Named Method Example...");

            // Anonymous Method Example
            StringDelegate sd2 = delegate (string s) { Console.WriteLine(s); };
            sd2("Anonymous Method Example...");

            // Lambda Expression
            StringDelegate sd3 = (x) => { Console.WriteLine(x); };
            sd3("Lambda Expression Example...");
        }
    }
}
