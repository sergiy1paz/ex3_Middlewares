using Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex3_Middlewares.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddArticleServices(this IServiceCollection services)
        {
            services.AddScoped<IArticleInfoService, ArticleInfoService>();
            services.AddTransient<IArticleContentService, ArticleContentService>();
            services.AddScoped<ICheckArticleService, CheckArticleService>();
            services.AddScoped<IPublishArticleService, PublishArticleService>();

            return services;
        }
    }
}
