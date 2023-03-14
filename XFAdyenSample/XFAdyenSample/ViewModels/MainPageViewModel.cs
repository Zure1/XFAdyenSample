namespace XFAdyenSample.ViewModels
{
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;
    using XFAdyenSample.Services;

    public class MainPageViewModel
	{
		public ICommand StartCheckoutCommand { get; set; }
        private IAdyenService adyenService { get; }

        public MainPageViewModel()
        {
            StartCheckoutCommand = new Command(StartCheckout);
            adyenService = DependencyService.Resolve<IAdyenService>();
        }

        public void StartCheckout()
        {
            adyenService.StartCheckout();
        }
	}
}

