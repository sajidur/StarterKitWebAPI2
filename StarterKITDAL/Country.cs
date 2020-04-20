using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StarterKITDAL
{
    public class Country: BaseEntity
    {
        public Country()
        {
            this.SalaryItems = new HashSet<SalaryItem>();
        }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<SalaryItem> SalaryItems { get; set; }
    }
}