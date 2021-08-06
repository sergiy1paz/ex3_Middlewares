using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Interfaces;

namespace ex3_Middlewares.Middlewares
{
    public class ArticlePublisher
    {
        private readonly RequestDelegate _next;

        public ArticlePublisher(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, IPublishArticleService publishArticleService)
        {
            await context.Response.WriteAsync(publishArticleService.Publish());
        }
    }
}
