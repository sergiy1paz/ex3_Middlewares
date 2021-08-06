using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;

namespace ex3_Middlewares.Middlewares
{
    public class ArticleContentSetter
    {
        private readonly RequestDelegate _next;
        private readonly string _content;
        public ArticleContentSetter(RequestDelegate next, string content)
        {
            _next = next;
            _content = content;
        }

        public async Task InvokeAsync(HttpContext context, IArticleContentService articleContentService)
        {
            articleContentService.SetContent(_content);
            Console.WriteLine("SetContent");
            await _next.Invoke(context);
        }
    }
}
