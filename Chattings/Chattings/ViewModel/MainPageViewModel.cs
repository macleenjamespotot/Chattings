using System;
using Prism.Navigation;

namespace Chattings.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
