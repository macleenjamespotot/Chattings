using System;
using Chattings.ViewModel;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chattings
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            #region Pages
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            #endregion
        }
    }
}
