﻿using log4net;
using System.Web;

namespace App.Security
{
    /// <summary>
    /// Provides security methods for Web applications.
    /// </summary>
    /// <remarks>
    /// Some security rules are defined in Web.main.config files, in addition to this class.
    /// </remarks>
    public static class Secure
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(Secure));

        /// <summary>
        /// Run at Application_PreSendRequestHeaders event.
        /// </summary>
        public static void ProtectRequest(HttpContext context)
        {
            if (context != null)
            {
                RemoveServerInfoFromResponseHeaders(context);
                PreventXss(context);
            }
            else
            {
                _logger.Error("HttpContext was null while securing request.");
            }
        }


        private static void PreventXss(HttpContext context)
        {
            // Csp.ApplyCsp(context);
            context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
            context.Response.Headers.Add("X-Content-Type-Options", "NOSNIFF");
            context.Response.Headers.Add("X-Frame-Options", "SAMEORIGIN");
            context.Response.Headers.Add("X-Permitted-Cross-Domain-Policies", "master-only");
        }

        private static void RemoveServerInfoFromResponseHeaders(HttpContext context)
        {
            context.Response.Headers.Remove("Server");
            context.Response.Headers.Remove("X-AspNet-Version");
            context.Response.Headers.Remove("X-AspNetMvc-Version");
            context.Response.Headers.Remove("X-Powered-By");
        }
    }
}