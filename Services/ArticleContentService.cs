using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services
{
    public class ArticleContentService : IArticleContentService
    {
        private readonly IArticleInfoService _articleInfo;

        public ArticleContentService(IArticleInfoService articleInfo)
        {
            _articleInfo = articleInfo;
        }

        public void SetContent(string content)
        {
            if (_articleInfo is not null)
            {
                _articleInfo.Content = content;
            }
        }
    }
}
