
namespace SeedData.Models
{
    public class CustomerCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Customer>? customer { get; set; }
    }
}
