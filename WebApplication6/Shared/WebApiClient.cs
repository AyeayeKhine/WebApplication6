using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Shared
{
    public class WebApiClient
    {
        public static string UrlApi = "https://thai2dlive.com";
        public HttpClient _client;
        public string BaseUri { get; private set; }
        private static WebApiClient _instance;
        private WebApiClient(string baseUri, HttpClient client)
        {
            BaseUri = baseUri;
            this._client = client;
        }

        private string BuildActionUri(string action)
        {
            return BaseUri + action;
        }
       
        public static WebApiClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    //_instance = new WebApiClient("https://sp-sanhtar-web.conveyor.cloud");
                    _instance = new WebApiClient("https://thai2dlive.com", new HttpClient());
                }

                return _instance;
            }
        }
        public async Task<ResponseList<S>> PostAsyncForList<T, S>(string action, TestModel data, string authToken = null)
        {
            using (var client = new HttpClient())
            {
                var result = await client.GetAsync(BuildActionUri(action));
                string json = await result.Content.ReadAsStringAsync();
                if (1==1)
                {
                  
                    var obj = JsonConvert.DeserializeObject<ResponseList<S>>(json);
                    return obj;

                }

                throw new Exception();
            }
        }
    }
}
