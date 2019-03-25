using Helper.Common.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Helper.Common.Http
{
    /// <inheritdoc />
    public class RestService<TDto> : IRestService<TDto> where TDto : class
    {
        private readonly IHttpHandler _httpHandler;

        public RestService(IHttpHandler httpHandler)
        {
            _httpHandler = httpHandler;
        }

        public async Task<TDto> GetAsync(string uri)
        {
            var response = await _httpHandler.GetAsync(uri).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<TDto>(content, new UnixDateTimeConverter());
            }

            return null;
        }
    }
}
