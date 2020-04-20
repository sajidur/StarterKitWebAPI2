using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL
{
    public class Rules:BaseEntity
    {
        public Rules()
        {
            this.Conditions =new HashSet<Conditions>();
        }
        public bool IsFixedFigure { get; set; }
        public bool IsRelatedTo { get; set; }
        public int RelatedToItemId { get; set; }
        public decimal RelatedPercentage { get; set; }
        public decimal Amount { get; set; }
        public decimal DeductionAmount { get; set; }
        public decimal AdditionAmount { get; set; }
        [Required]
        public ICollection<Conditions> Conditions { get; set; }
        [Required]
        public int SalaryItemId { get; set; }
        [ForeignKey("SalaryItemId")]
        public SalaryItem SalaryItem { get; set; }
    }
}
