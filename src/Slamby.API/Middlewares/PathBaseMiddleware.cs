﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Slamby.API.Helpers;
using Slamby.Common.Config;
using System.Threading.Tasks;

namespace Slamby.API.Middlewares
{
    public class PathBaseMiddleware
    {
        readonly RequestDelegate next;
        readonly ILogger _logger;
        readonly SiteConfig siteConfig;

        public PathBaseMiddleware(RequestDelegate next, SiteConfig siteConfig)
        {
            this.siteConfig = siteConfig;
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Request.PathBase = HostUrlHelper.GetPathBase(context.Request, siteConfig.BaseUrlPrefix);
            // Call next Middleware
            await next(context);
        }
    }
}
