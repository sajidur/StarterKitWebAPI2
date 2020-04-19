using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIStartupKit.RequestBody
{
    public class SalaryItemRequest
    {
        public string ItemName { get; set; }
        public decimal Amount { get; set; }

    }
}