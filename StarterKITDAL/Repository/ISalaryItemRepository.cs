using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL.Repository
{
    public interface ISalaryItemRepository
    {
        ICollection<SalaryItem> GetAll(int CompanyId);
    }
}
