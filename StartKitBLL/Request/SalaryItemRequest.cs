using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL.Request
{
   public  class SalaryItemRequest
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public virtual int CountryId { get; set; }
    }
}
