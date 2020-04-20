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
    public class SalaryItemController : ApiController
    {
        // GET: SalaryItem
        private readonly ISalaryItemService _salaryItemService;
        public SalaryItemController(ISalaryItemService salaryItemService)
        {
            _salaryItemService = salaryItemService;
        }
        public bool Post(SalaryItemRequest request)
        {
            request.CountryId = 1;
            _salaryItemService.Save(request);
            return true;
        }
        public List<SalaryItemResponse> GetAll()
        {
           return _salaryItemService.GetAll(1);
        }
    }
}