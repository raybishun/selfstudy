using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref48
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
        }

        static void Greeting()
        {
            // Summary:
            //      C# source code is compiled to Common Intermediate Language (CIL, aka IL, MSIL).
            //      Just-in-time compilation compiles the code to Native Machine Code (based on 
            //      the computer's architecture).
            //      The Common Language Runtime (CLR) executes this Native Machine Code.
            //      The CLR provides security and memory management for the code it executes.
            
            Console.WriteLine("Hello, World!");
        }
    }
}
