using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex3_Middlewares.Middlewares;

namespace ex3_Middlewares.Extensions
{
    public static class ArticleMiddlewareExtension
    {
        public static IApplicationBuilder UseArticleProcessing(this IApplicationBuilder app, string articleContent)
        {
            app.Map("/publish", appBuilder =>
            {
                appBuilder.UseMiddleware<ArticleContentSetter>(articleContent);
                appBuilder.UseMiddleware<ArticleChecker>();
                appBuilder.UseMiddleware<ArticlePublisher>();
            });

            return app;
        }
    }
}
