using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

using Prism.Autofac.Windows;

using Prism.Windows;

namespace Feedly_UWP
{
    
    sealed partial class App : PrismAutofacApplication
    {

        public App()
        {
            this.InitializeComponent();
        }
        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate("Main", null);
            return Task.FromResult<object>(null);
        }

    }
}
