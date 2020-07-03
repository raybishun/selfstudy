using System;
using System.Security.Principal;

namespace ref48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGreeting("Hello World!"));
        }

        static string GetGreeting(string greeting)
        {
            // Summary:
            //  Compilation 1 of 2
            //      C# source code is compiled 
            //      to Common Intermediate Language
            //      (CIL, aka IL, aka MSIL).
            //  Compilation 2 of 2
            //      The Just-in-time (JIT) compiler 
            //      compiles CIL to Native Machine Code
            //      (based on the computer's architecture).
            //  Execution
            //      The Common Language Runtime (CLR)
            //      executes Native Machine Code.
            //  Security & Management
            //      The CLR provides security and memory
            //      management for code it executes.

            try
            {
                return $"{WindowsIdentity.GetCurrent().Name} says {greeting}.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
