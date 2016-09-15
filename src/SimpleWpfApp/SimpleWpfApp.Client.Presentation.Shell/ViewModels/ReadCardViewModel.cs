using System;
using System.Windows.Input;
using Caliburn.Micro;
using LogoFX.Client.Mvvm.Commanding;
using LogoFX.Client.Mvvm.ViewModel.Contracts;
using SimpleWpfApp.Client.Model.Contracts;

namespace SimpleWpfApp.Client.Presentation.Shell.ViewModels
{
    public class ReadCardViewModel : Screen , ICanBeBusy
    {
        private readonly IDataService _dataService;

        public ReadCardViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        ICommand _readCommand;

        public ICommand ReadCommand
        {
            get
            {
                return _readCommand ?? (_readCommand = ActionCommand
                    .Do(async () => 
                    {
                        try
                        {
                            IsBusy = true;
                            await _dataService.ReadCard();
                        }
                        catch (Exception e)
                        {
                            
                        }
                        finally
                        {
                            IsBusy = false;
                        }
                    }));
            }
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (_isBusy == value)
                {
                    return;
                }

                _isBusy = value;

                NotifyOfPropertyChange();
            }
        }
    }
}   