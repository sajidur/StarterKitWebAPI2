﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public interface IConditionRepository
    {
        List<Conditions> GetAll(int RulesId);
    }
}
