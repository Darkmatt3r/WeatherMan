using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using WeatherMan.Models;

namespace WeatherMan.ApiClient
{
    public class IPApiClient: ApiClient
    {
        private readonly string _apiKey;

        public IPApiClient(Uri baseUri, string apiKey)
            :base(baseUri)
        {
            if (String.IsNullOrEmpty(apiKey))
                throw new ArgumentNullException("IPApiClient needs an api key");
            else
                _apiKey = apiKey;
        }

        public async Task<IPDataResponseModel> GetAllData()
        {
            var query = String.Concat("api-key=", _apiKey);
            var requestUrl = CreateRequestUri("", query);
            return await GetAsync<IPDataResponseModel>(requestUrl);
        }
    }
}
