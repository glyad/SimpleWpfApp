using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleWpfApp.Client.Model.Contracts
{
    public interface IDataService
    {
        IEnumerable<IWarehouseItem> WarehouseItems { get; }

        Task GetWarehouseItemsAsync();
        Task ReadCard();
    }
}