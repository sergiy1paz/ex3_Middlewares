using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services
{
    public class PublishArticleService : IPublishArticleService
    {
        private readonly IArticleInfoService _articleInfo;

        public PublishArticleService(IArticleInfoService articleInfo)
        {
            _articleInfo = articleInfo;
        }

        public string Publish()
        {
            string text = null;
            try
            {
                // some logic ... 
                text = _articleInfo.Content;
                Console.WriteLine("Article was published");

            }
            catch (Exception)
            {
                Console.WriteLine("Error of publishing!");
                text = "Error!";
            }
            return text;
        }
    }
}
