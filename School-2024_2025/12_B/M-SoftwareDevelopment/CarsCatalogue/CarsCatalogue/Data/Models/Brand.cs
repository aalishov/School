namespace CarsCatalogue.Data.Models
{
    public class Brand
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public int? EstablishedOn { get; set; }
        public virtual ICollection<Model> Models { get; set; } = new HashSet<Model>();
    }
}
