using System;

namespace WithDependencyInjection
{
    class ConsoleNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            Console.WriteLine($"User name was changed to: {user.Username}.");
        }
    }
}
