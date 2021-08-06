using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Interfaces;

namespace ex3_Middlewares.Middlewares
{
    public class ArticleChecker
    {
        private readonly RequestDelegate _next;

        public ArticleChecker(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, ICheckArticleService checkArticleService)
        {
            if (checkArticleService.Check())
            {
                Console.WriteLine("Article was checked successfully");
                await _next.Invoke(context);
            } else
            {
                await context.Response.WriteAsync("Article did not pass the test!");
            }
        }
    }
}
