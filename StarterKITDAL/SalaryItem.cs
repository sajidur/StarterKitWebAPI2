using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarterKITDAL
{
    public class SalaryItem : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Descriptions { get; set; }
        [Required]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}