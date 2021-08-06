using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services
{
    public class CheckArticleService : ICheckArticleService
    {
        private readonly IArticleInfoService _articleInfo;

        public CheckArticleService(IArticleInfoService articleInfo)
        {
            _articleInfo = articleInfo;
        }

        public bool Check()
        {
            return !string.IsNullOrEmpty(_articleInfo.Content);
        }
    }
}
