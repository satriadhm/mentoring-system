using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.Implementation
{
    internal class ApiClient
    {
        private static HttpClient _client = new HttpClient();

        public Task<HttpResponseMessage> GetAsync(string url)
        {
            return _client.GetAsync(url);
        }

        public Task<HttpResponseMessage> PostAsJsonAsync(string url, object data)
        {
            return _client.PostAsJsonAsync(url, data);
        }
    }
}
