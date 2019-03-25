using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Helper.Common.Http
{
    /// <summary>
    /// Abstraction over HttpClient for easy mocking.
    /// </summary>
    public interface IHttpHandler : IDisposable
    {
        /// <summary>
        /// Send a GET request to the specified url as an asynchronous operation.
        /// </summary>
        /// <param name="uri"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> GetAsync(string uri);

        /// <summary>
        /// Send a POST request to the specified url as an asynchronous operation.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        Task<HttpResponseMessage> PostAsync(string url, HttpContent content);
    }
}
