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
        }
    }
}
