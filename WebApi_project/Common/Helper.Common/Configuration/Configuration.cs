namespace Helper.Common.Configuration
{
    public class Configuration : IConfiguration
    {
        public string ApiKeyUmWarszawa => ConfigurationManagerHelper.ReadConfig(ConfigKey.ApiKey);

        /// <inheritdoc />
        public string BaseApiAddress => ConfigurationManagerHelper.ReadConfig(ConfigKey.WarsawApiUrl);
        /// <inheritdoc />
        public string GetRequestsUri => ConfigurationManagerHelper.ReadConfig(ConfigKey.GetRequestsUri);
    }
}
