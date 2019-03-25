using Application.Model.Notifications;
using Helper.Common.Http;
using System.Threading.Tasks;
using Xunit;

namespace Test.IntegrationTests
{
    public class UmWarszawaApiTest
    {
        [Fact]
        public async Task ApiReturnsDataCorrectlyTest()
        {
            IRestService<NotificationResponseDto> service = new RestService<NotificationResponseDto>(new HttpHandler());
            var result = await service.GetAsync("https://api.um.warszawa.pl/api/action/" +
                                                "19115store_getNotificationsForDate/" +
                                                "?id=28dc65ad-fff5-447b-99a3-95b71b4a7d1e" +
                                                "&dateFrom=1427088587865" +
                                                "&dateTo=1449381387965" +
                                                "&apikey=7437f147-6d8e-409e-80be-14b722b9ff9a");
            Assert.NotNull(result);
        }
    }
}
