using SimpleWpfApp.Client.Model.Contracts;

namespace SimpleWpfApp.Client.Model.Shared
{
    public static class UserContext
    {
        private static IUser _currentUser;

        public static IUser Current
        {
            get { return _currentUser; }
            set
            {
                if (_currentUser == value)
                {
                    return;
                }

                _currentUser = value;
            }
        }
    }
}
