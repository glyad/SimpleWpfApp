using System.Collections.Generic;
using SimpleWpfApp.Client.Data.Contracts.Dto;

namespace SimpleWpfApp.Client.Data.Contracts.Providers
{
    public interface IWarehouseProvider
    {
        IEnumerable<WarehouseItemDto> GetWarehouseItems();
    }
}