namespace WithoutDependencyInjection
{
    class User
    {
        private ConsoleNotification _notificationService;

        public User(string username)
        {
            Username = username;
            _notificationService = new ConsoleNotification();
        }

        public string Username { get; private set; }

        public void ChangeUsername(string newUsername)
        {
            Username = newUsername;
            _notificationService.NotifyUsernameChanged(this);
        }
    }
}
