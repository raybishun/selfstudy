using System;

namespace WithDependencyInjection
{
    class WebNotification : INotificationService
    {
        public void NotifyUsernameChanged(User user)
        {
            // ...now any other Notification Service can implement the INotificationService
            // without making changes to any other code
        }
    }
}
