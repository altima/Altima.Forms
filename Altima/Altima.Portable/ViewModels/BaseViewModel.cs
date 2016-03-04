using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;
using Prism.Navigation;

namespace Altima.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        public virtual void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public virtual void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}
