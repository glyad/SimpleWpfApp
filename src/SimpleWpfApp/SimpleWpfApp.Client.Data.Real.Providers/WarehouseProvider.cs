using System.Collections.Generic;
using JetBrains.Annotations;
using SimpleWpfApp.Client.Data.Contracts.Dto;
using SimpleWpfApp.Client.Data.Contracts.Providers;

namespace SimpleWpfApp.Client.Data.Real.Providers
{
    [UsedImplicitly]
    internal sealed class WarehouseProvider : IWarehouseProvider
    {
        public IEnumerable<WarehouseItemDto> GetWarehouseItems()
        {
            throw new System.NotImplementedException();
        }
    }
}