namespace XFAdyenSample.iOS.Services
{
    using System;
    using System.Threading.Tasks;
    using XFAdyenSample.Services;

    public class AdyenService : IAdyenService
	{
        public Task StartCheckout()
        {
            return Task.CompletedTask;
        }
    }
}

