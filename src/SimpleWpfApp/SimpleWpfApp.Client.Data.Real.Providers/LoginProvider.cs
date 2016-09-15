using JetBrains.Annotations;
using SimpleWpfApp.Client.Data.Contracts.Providers;

namespace SimpleWpfApp.Client.Data.Real.Providers
{
    [UsedImplicitly]
    internal sealed class LoginProvider : ILoginProvider
    {
        public void Login(string username, string password)
        {
            // TODO: Add login logic here
        }
    }
}