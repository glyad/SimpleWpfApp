using System.Security;
using JetBrains.Annotations;
using SimpleWpfApp.Client.Data.Contracts.Providers;

namespace SimpleWpfApp.Client.Data.Fake.Providers
{
    [UsedImplicitly]
    internal sealed class FakeLoginProvider : ILoginProvider
    {
        public void Login(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                return;
            }

            throw new SecurityException("Wrong name or password.");
        }
    }
}