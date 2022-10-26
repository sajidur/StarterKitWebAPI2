using StarterKITDAL;
using StartKitBLL;
using StartKitBLL.Request;
using StartKitBLL.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPIStartupKit.Controllers
{
    public class NewsContentController : ApiController
    {
        // GET: SalaryItem
        private readonly INewsContentService _newsContent;
        public NewsContentController(INewsContentService newsContent)
        {
            _newsContent = newsContent;
        }
        public bool Post(NewsContent request)
        {
            _newsContent.Save(request);
            return true;
        }
        public List<NewsContent> GetAll()
        {
           return _newsContent.GetList("");
        }
    }
}