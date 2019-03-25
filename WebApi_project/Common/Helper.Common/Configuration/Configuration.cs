namespace Helper.Common.Configuration
{
    public class Configuration : IConfiguration
    {
        public string ApiKeyUmWarszawa => ConfigurationManagerHelper.ReadConfig(ConfigKey.ApiKey);

        /// <inheritdoc />
        public string BaseApiAddress => ConfigurationManagerHelper.ReadConfig(ConfigKey.ApiBaseAddress);
        /// <inheritdoc />
        public string GetRequestsUri => ConfigurationManagerHelper.ReadConfig(ConfigKey.GetRequestsUri);
    }
}
