using AutoMapper;
using StarterKITDAL;
using StarterKITDAL.Repository;
using StartKitBLL.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL
{
    public class RulesService:IRulesService
    {
        private IRulesRepository  _rulesRepository;
        private IMapper _mapper;
        public RulesService(IRulesRepository rulesRepository, IMapper mapper)
        {
            this._rulesRepository = rulesRepository;
            this._mapper = mapper;
        }
        public int Save(RulesRequest ruleRequest)
        {
            var rules = new Rules();
            //rules.CountryId = ruleRequest.CountryId;
            rules.AdditionAmount = ruleRequest.AdditionAmount;
            rules.DeductionAmount = ruleRequest.DeductionAmount;
            rules.IsFixedFigure = ruleRequest.IsFixedFigure;
            rules.RelatedToItemId = ruleRequest.RelatedToItemId;
            rules.SalaryItemId = ruleRequest.SalaryItemId;
            rules.RelatedPercentage = ruleRequest.RelatedPercentage;
            rules.Amount = ruleRequest.Amount;
            rules.Conditions = new List<Conditions>();
            foreach (var item in ruleRequest.Conditions)
            {
                item.Rules = null;
                rules.Conditions.Add(item);
            }
           return  _rulesRepository.Save(rules);

        }
        public List<Rules> GetRules(int CountryId)
        {
           return  _rulesRepository.GetAll(CountryId).ToList();
        }
    }
}
