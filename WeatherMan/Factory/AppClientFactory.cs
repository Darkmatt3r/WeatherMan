using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WeatherMan.ApiClient;
using WeatherMan.Util;

namespace WeatherMan.Factory
{
    public class ApiClientFactory
    {
        private static Uri _apiUri;
        private static string _apiKey;

        private static Lazy<IPApiClient> restClient = new Lazy<IPApiClient>(
            () => new IPApiClient(_apiUri, _apiKey),
            LazyThreadSafetyMode.ExecutionAndPublication);

        static ApiClientFactory()
        {
            _apiUri = new Uri(ApplicationSettings.WebApiUrl);
            _apiKey = ApplicationSettings.WebApiKey;
        }

        public static IPApiClient Instance
        {
            get
            {
                return restClient.Value;
            }
        }
    }
}
