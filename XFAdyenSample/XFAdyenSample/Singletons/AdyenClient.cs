namespace XFAdyenSample.Singletons
{
    using System;
    using Adyen;

    public sealed class AdyenClient
	{
        private const string ApiKey = "test_OSXJEDLUI5A4FAKXSOKZRP7FA4AK27O3";

        private static readonly Lazy<Client> lazy =
            new Lazy<Client>(() => new Client(ApiKey, Adyen.Model.Enum.Environment.Test));

        public static Client Instance { get { return lazy.Value; } }

        private AdyenClient()
        {
        }
    }
}