using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace Altima.ViewModels
{
    public class RootPageViewModel : BaseViewModel
    {
        private INavigationService _navigationService;

        public DelegateCommand<string> NavigateCommand { get; set; }

        public RootPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(DoNavigate);
        }

        private void DoNavigate(string page)
        {
            _navigationService.Navigate(page);
        }
    }
}
