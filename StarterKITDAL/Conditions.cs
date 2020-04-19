using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterKITDAL
{
    public class Conditions:BaseEntity
    {
        public string IFCondition { get; set; }
        public string ISConditions { get; set; }
        public string ISValueConditions { get; set; }
        public decimal Amount { get; set; }
        public int RulesId { get; set; }
        public Rules Rules { get; set; }
    }
}
