namespace StarterKITDAL
{
    public class SalaryItem:BaseEntity
    {
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public virtual int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}