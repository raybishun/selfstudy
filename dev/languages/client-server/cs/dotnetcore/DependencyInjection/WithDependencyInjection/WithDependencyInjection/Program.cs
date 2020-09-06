using System;

namespace WithDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new ConsoleNotification(); 
            
            var user1 = new User("Jennifer", notificationService);
            user1.ChangeUsername("Jessica");

            Console.ReadKey();
        }
    }
}
