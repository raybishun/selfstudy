using System;

namespace WithoutDependencyInjection
{
    class ConsoleNotification
    {
        internal void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"User name was changed to: {user.Username}.");
        }
    }
}
