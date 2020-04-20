using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public interface IRulesRepository
    {
        ICollection<Rules> GetAll(int CompanyId);
        int Save(Rules rules);
    }
}
