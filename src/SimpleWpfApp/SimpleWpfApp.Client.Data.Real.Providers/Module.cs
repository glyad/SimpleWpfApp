using JetBrains.Annotations;
using SimpleWpfApp.Client.Data.Contracts.Providers;
using Solid.Practices.IoC;
using Solid.Practices.Modularity;

namespace SimpleWpfApp.Client.Data.Real.Providers
{
    [UsedImplicitly]
    internal sealed class Module : ICompositionModule<IIocContainerRegistrator>
    {
        public void RegisterModule(IIocContainerRegistrator iocContainer)
        {
            iocContainer.RegisterSingleton<IWarehouseProvider, WarehouseProvider>();
            iocContainer.RegisterSingleton<ILoginProvider, LoginProvider>();
        }
    }
}