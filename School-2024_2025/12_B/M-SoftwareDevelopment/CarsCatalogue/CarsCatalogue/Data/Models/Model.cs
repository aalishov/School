namespace CarsCatalogue.Data.Models
{
    public class Model
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string BrandId { get; set; } //!!!!
        public virtual Brand? Brand { get; set; }
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
