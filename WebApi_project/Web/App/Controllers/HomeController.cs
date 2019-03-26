using Application.Model.Notifications;
using Helper.Common.Configuration;
using Helper.Common.Http;
using log4net;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(HomeController));

        private readonly IRestService<NotificationResponseDto> _service;
        private readonly IConfiguration _config;

        public HomeController(IRestService<NotificationResponseDto> restService, IConfiguration config)
        {
            _service = restService;
            _config = config;
        }

        public async Task<ActionResult> Index()
        {
            try
            {
                const string cacheKey = "nck";
                var model = HttpContext.Cache.Get(cacheKey) as IList<NotificationDto>;

                if (model == null)
                {
                    var dt = DateTime.Now;

                    var dateTimeOffsetNow = new DateTimeOffset(dt);
                    var unixDateTimeNow = dateTimeOffsetNow.ToUnixTimeMilliseconds();

                    var dateTimeOffsetBefore = new DateTimeOffset(dt).AddHours(-6);
                    var unixDateTimeFrom = dateTimeOffsetBefore.ToUnixTimeMilliseconds();

                    string uri = $"{_config.BaseApiAddress}{_config.GetRequestsUri}" +
                                 "?id=28dc65ad-fff5-447b-99a3-95b71b4a7d1e" +
                                 $"&dateFrom={unixDateTimeFrom}" +
                                 $"&dateTo={unixDateTimeNow}" +
                                 $"&apikey={_config.ApiKeyUmWarszawa}";

                    model = (await _service.GetAsync(uri))?.result.result.notifications;
                    // store in cache for some time, to limit external calls;
                    // normally we'd store that data in our database, to save bandwidth
                    HttpContext.Cache.Add(cacheKey, model, null, DateTime.Now.AddMinutes(5), Cache.NoSlidingExpiration,
                        CacheItemPriority.Normal, null);
                }

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                return null;
            }
        }
    }
}