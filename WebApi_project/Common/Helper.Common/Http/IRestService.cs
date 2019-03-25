using System.Threading.Tasks;

namespace Helper.Common.Http
{
    /// <summary>
    /// Service allowing for consumption of external apis.
    /// </summary>
    /// <typeparam name="TDto">Type to which response content will be deserialized.</typeparam>
    public interface IRestService<TDto>
    {
        Task<TDto> GetAsync(string uri);
    }
}
