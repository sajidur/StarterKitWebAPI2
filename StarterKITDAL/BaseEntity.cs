using System;

namespace StarterKITDAL
{
    public class BaseEntity
    {
        public bool IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public virtual int CompanyId { get; set; }
        public virtual Company Company { get; set; }
    }
}