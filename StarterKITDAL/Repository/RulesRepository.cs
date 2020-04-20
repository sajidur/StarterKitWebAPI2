using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public class RulesRepository : IRulesRepository
    {
        ApplicationDbContext _context;
        public RulesRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public int Save(Rules rules)
        {
            rules.SalaryItem = null;
            _context.Rules.Add(rules);
           return _context.SaveChanges();
        }

        ICollection<Rules> IRulesRepository.GetAll(int CountryId)
        {
           return _context.Rules.Include("Conditions").Include("SalaryItem").Where(a => a.SalaryItem.CountryId == CountryId).ToList();
        }
    }
}
