using StarterKITDAL;
using StartKitBLL.Request;
using System.Collections.Generic;

namespace StartKitBLL
{
    public interface IRulesService
    {
        int Save(RulesRequest ruleRequest);
        List<Rules> GetRules(int CountryId);
    }
}