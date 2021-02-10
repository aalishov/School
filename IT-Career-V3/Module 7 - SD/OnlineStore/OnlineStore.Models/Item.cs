namespace OnlineStore.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Item
    {
        public Item()
        {
            this.Orders = new HashSet<OrderItem>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(ItemType))]
        public int ItemTypeId { get; set; }

        public virtual ItemType ItemType { get; set; }

        public virtual ICollection<OrderItem> Orders { get; set; }

    }
}
