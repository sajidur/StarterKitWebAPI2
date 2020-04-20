using StarterKITDAL;
using StartKitBLL;
using StartKitBLL.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPIStartupKit.Controllers
{
    public class RulesController : ApiController
    {
        // GET: Rules
        private readonly IRulesService _rulesService;
        public RulesController(IRulesService rulesService)
        {
            _rulesService = rulesService;
        }
        public bool Post(RulesRequest request)
        {
            _rulesService.Save(request);
            return true;
        }
        public List<Rules> GetAll()
        {
            var result = new List<Rules>();
            var res= _rulesService.GetRules(1);
            foreach (var item in res)
            {
                var conditions = new List<Conditions>();
                foreach (var condition in item.Conditions)
                {
                    conditions.Add(new Conditions() {Amount= condition.Amount,ISConditions=condition.ISConditions });
                }
                result.Add(new Rules() {Conditions= conditions, AdditionAmount = item.AdditionAmount, Amount = item.Amount, DeductionAmount = item.DeductionAmount, IsFixedFigure = item.IsFixedFigure, IsRelatedTo = item.IsRelatedTo, SalaryItem = new SalaryItem() { Name = item.SalaryItem.Name, Descriptions = item.SalaryItem.Descriptions } });
            }
            return result;
        }
    }
}