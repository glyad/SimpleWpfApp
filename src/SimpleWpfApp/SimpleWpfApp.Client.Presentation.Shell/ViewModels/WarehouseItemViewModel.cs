using JetBrains.Annotations;
using LogoFX.Client.Mvvm.ViewModel;
using SimpleWpfApp.Client.Model.Contracts;

namespace SimpleWpfApp.Client.Presentation.Shell.ViewModels
{
    [UsedImplicitly]
    public class WarehouseItemViewModel : ObjectViewModel<IWarehouseItem>
    {
        public WarehouseItemViewModel(IWarehouseItem model) : base(model)
        {

        }
    }
}