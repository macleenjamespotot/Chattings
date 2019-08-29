using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace Chattings.ViewModel
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        bool _IsLoading;
        public bool IsLoading { get { return _IsLoading; } set { _IsLoading = value; RaisePropertyChanged(nameof(IsLoading)); } }
        bool _IsClicked;
        public bool IsClicked { get { return _IsClicked; } set { _IsClicked = value; RaisePropertyChanged(nameof(IsClicked)); } }



        public ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {

        }

        public virtual void OnBackButtonPressed()
        {

        }
    }
}
