﻿using StartKitBLL.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL
{
    public interface ISalaryItemService
    {
        List<SalaryItemResponse> GetAll(int CountryId);
    }
}
