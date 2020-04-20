using Newtonsoft.Json;
using StartKitBLL;
using StartKitBLL.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIStartupKit.Controllers
{
    public class SalaryController : ApiController
    {
        private readonly ISalaryItemService _salaryItemService;
        public SalaryController(ISalaryItemService salaryItemService)
        {
            _salaryItemService = salaryItemService;
        }
        public dynamic GetAll()
        {
            var sheet= _salaryItemService.SalarySheet(1);
            return JsonConvert.SerializeObject(sheet);
        }
    }
}
