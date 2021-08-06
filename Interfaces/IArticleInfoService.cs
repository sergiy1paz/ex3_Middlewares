using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IArticleInfoService
    {
        string Header { get; set; }
        string Content { get; set; }
        string Author { get; set; }
    }
}
