using System.Net.Http;
using System.Threading.Tasks;

namespace Helper.Common.Http
{
    public class HttpHandler : IHttpHandler
    {
        /// <inheritdoc />
        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.PostAsync(url, content);
            }
        }
    }
}
