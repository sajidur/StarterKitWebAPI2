using StarterKITDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartKitBLL.Request
{
    public class RulesRequest
    {
        public int SalaryItemId { get; set; }
        public bool IsFixedFigure { get; set; }
        public bool IsRelatedTo { get; set; }
        public int RelatedToItemId { get; set; }
        public decimal RelatedPercentage { get; set; }
        public decimal Amount { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal AdditionAmount { get; set; }
        public List<Conditions> Conditions { get; set; }
    }
}
