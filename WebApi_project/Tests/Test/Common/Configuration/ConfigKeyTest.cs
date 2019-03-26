using Helper.Common.Configuration;
using Xunit;

namespace Test.Common.Configuration
{
    public class ConfigKeyTest
    {
        [Fact]
        public void ApiKeyHasCorrectKeyTest()
        {
            Assert.Equal("ApiKey", ConfigKey.ApiKey);
        }

        [Fact]
        public void WarsawApiUrlHasCorrectKeyTest()
        {
            Assert.Equal("WarsawApiUrl", ConfigKey.WarsawApiUrl);
        }

        [Fact]
        public void PostRequestsUriHasCorrectKeyTest()
        {
            Assert.Equal("GetRequestsUri", ConfigKey.GetRequestsUri);
        }
    }
}
