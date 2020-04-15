namespace StarterKITDAL
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}