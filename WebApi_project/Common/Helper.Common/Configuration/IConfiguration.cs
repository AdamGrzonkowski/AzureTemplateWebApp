namespace Helper.Common.Configuration
{
    /// <summary>
    /// Facade to wrap around configuration manager - allows easy mocking.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Api key used to query http://api.um.warszawa.pl/api
        /// </summary>
        string ApiKeyUmWarszawa { get; }


        /// <summary>
        /// Base address of Api in the format
        /// protocol:ip/dns:port/
        /// </summary>
        string BaseApiAddress { get; }

        /// <summary>
        /// Uri of Post method on Requests controller.
        /// </summary>
        string GetRequestsUri { get; }
    }
}
