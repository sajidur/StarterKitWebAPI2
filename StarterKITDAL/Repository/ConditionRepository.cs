using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public class ConditionRepository:IConditionRepository
    {
        ApplicationDbContext _context;
        public ConditionRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public ICollection<Conditions> GetAll(int rulesId)
        {
            return _context.Conditions.Where(a => a.Rules.Id == rulesId).ToList();
        }
    }
}
