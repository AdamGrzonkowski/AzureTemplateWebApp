using System.Net.Http;
using System.Threading.Tasks;

namespace Helper.Common.Http
{
    public class HttpHandler : IHttpHandler
    {
        /// <remarks>
        /// Class is a singleton, so having initialization of HttpClient here saves some resources.
        /// </remarks>
        private readonly HttpClient _client = new HttpClient();

        /// <inheritdoc />
        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            return await _client.GetAsync(uri);
        }

        /// <inheritdoc />
        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            return await _client.PostAsync(url, content);
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
