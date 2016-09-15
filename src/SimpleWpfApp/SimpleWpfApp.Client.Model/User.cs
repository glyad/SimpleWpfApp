using JetBrains.Annotations;
using SimpleWpfApp.Client.Model.Contracts;

namespace SimpleWpfApp.Client.Model
{
    internal sealed class User : AppModel, IUser
    {
        public User(string username)
        {
            Username = username;
        }

        public string Username { get; private set; }
    }
}