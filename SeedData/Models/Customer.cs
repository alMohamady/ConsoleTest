
namespace SeedData.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public long telephone { get; set; }
        public int age { get; set; }
        public decimal spendAverage { get; set; }
        public int categoryId { get; set; }
        public bool isActive { get; set; }
        public DateTime joinDate { get; set; }
    }
}
