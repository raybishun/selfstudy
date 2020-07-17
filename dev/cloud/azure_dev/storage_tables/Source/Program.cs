using System;

namespace storage.tables
{
    class Program
    {
        static void Main(string[] args)
        {
            Tables.runDemoAsync().Wait();
        }
    }
}