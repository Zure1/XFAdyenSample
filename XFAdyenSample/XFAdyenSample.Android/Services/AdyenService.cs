namespace XFAdyenSample.Droid.Services
{
    using System;
    using System.Threading.Tasks;
    using XFAdyenSample.Services;
    using XFAdyenSample.Singletons;

    public class AdyenService : IAdyenService
    {
        public Task StartCheckout()
        {
            var client = AdyenClient.Instance;
            return Task.CompletedTask;
        }
    }
}