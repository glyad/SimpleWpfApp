using Caliburn.Micro;
using JetBrains.Annotations;
using LogoFX.Client.Mvvm.ViewModel.Services;
using SimpleWpfApp.Client.Model.Contracts;

namespace SimpleWpfApp.Client.Presentation.Shell.ViewModels
{
    [UsedImplicitly]
    public sealed class MainViewModel : Screen
    {
        private readonly IViewModelCreatorService _viewModelCreatorService;
        private readonly IDataService _dataService;
        private ReadCardViewModel _readCardViewModel;

        public MainViewModel(
            IViewModelCreatorService viewModelCreatorService,
            IDataService dataService)
        {
            _viewModelCreatorService = viewModelCreatorService;
            _dataService = dataService;
        }

        public ReadCardViewModel ReadCardViewModel => _readCardViewModel ?? (_readCardViewModel = _viewModelCreatorService.CreateViewModel<ReadCardViewModel>());

        private WarehouseItemsViewModel _warehouseItems;
        public WarehouseItemsViewModel WarehouseItems
        {
            get { return _warehouseItems ?? (_warehouseItems = _viewModelCreatorService.CreateViewModel<WarehouseItemsViewModel>()); }
        }

        protected override async void OnInitialize()
        {
            base.OnInitialize();
            await _dataService.GetWarehouseItemsAsync();
        }
    }
}