using System.Threading.Tasks;
using JetBrains.Annotations;
using SimpleWpfApp.Client.Data.Contracts.Providers;
using SimpleWpfApp.Client.Model.Contracts;
using SimpleWpfApp.Client.Model.Shared;

namespace SimpleWpfApp.Client.Model
{
    [UsedImplicitly]
    public sealed class LoginService : ILoginService
    {
        private readonly ILoginProvider _loginProvider;

        public LoginService(ILoginProvider loginProvider)
        {
            _loginProvider = loginProvider;
        }

        public async Task LoginAsync(string username, string password)
        {
            await Task.Run(() =>
            {
                _loginProvider.Login(username, password);
            });
            UserContext.Current = new User(username);
        }
    }
}