using System;

namespace storage.blobs
{
    class Program
    {
        static void Main(string[] args)
        {
            Blobs.RunAsync().Wait();
        }
    }
}
