using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace mentoring_system.Abstraction
{
    internal class IApiClient
    {
        public Task<HttpResponseMessage> GetAsync(string url) 
        {
            return Task.FromResult<HttpResponseMessage>(default);
        }
        public Task<HttpResponseMessage> PostAsJsonAsync(string url, object data) 
        {
            return Task.FromResult<HttpResponseMessage>(default);
        }
    }
}
