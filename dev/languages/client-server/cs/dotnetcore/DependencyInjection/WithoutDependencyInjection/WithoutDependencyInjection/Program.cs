using System;

namespace WithoutDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("Jennifer");
            user1.ChangeUsername("Jessica");

            Console.ReadKey();
        }
    }
}
