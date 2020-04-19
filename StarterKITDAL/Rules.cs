using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL
{
    public class Rules:BaseEntity
    {
        public string SalaryItemId { get; set; }
        public bool IsFixedFigure { get; set; }
        public bool IsRelatedTo { get; set; }
        public int RelatedToItemId { get; set; }
        public decimal RelatedPercentage { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal AdditionAmount { get; set; }
        public virtual int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public ICollection<Conditions> Conditions { get; set; }
        public SalaryItem SalaryItem { get; set; }
    }
}
