using StarterKITDAL;
using StartKitBLL.Request;
using System.Collections.Generic;

namespace StartKitBLL
{
    public interface INewsContentService
    {
        int Save(NewsContent newsContent);
        List<NewsContent> GetList(string type);
    }
}