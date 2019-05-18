using System;
using System.Collections.Generic;
using System.Text;

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherMan.ApiClient
{
    public abstract class ApiClient
    {
        protected readonly HttpClient _httpClient;
        protected Uri _baseEndpoint;

        protected static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }
    

        public ApiClient(Uri baseEndpoint)
        {
            _baseEndpoint = baseEndpoint ?? throw new ArgumentException("baseEndpoint");
            _httpClient = new HttpClient();
        }

        protected async Task<T> GetAsync<T>(Uri requestUrl)
        {
            var response = await _httpClient.GetAsync(requestUrl, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(data);
        }

        protected Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            var endpoint = new Uri(_baseEndpoint, relativePath);
            var uriBuilder = new UriBuilder(endpoint)
            {
                Query = queryString
            };
            return uriBuilder.Uri;
        }
    }
}
