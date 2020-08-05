using System;

namespace DelegatesViaNamedMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mc = new MathClass();

            MathDelegate md = mc.MultiplyNums;

            for (int i = 0; i < 3; i++)
            {
                md(i, 2);
            }

            InvokeDelegate();
        }

        static void InvokeDelegate()
        {
            HelperClass helper = new HelperClass();

            // Link to instance method
            SampleDelegate sd = helper.InstanceMethod;
            sd();

            // Link to static method
            sd = HelperClass.StaticMethod;
            sd();
        }
    }
}

// Reference: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/delegates-with-named-vs-anonymous-methods
