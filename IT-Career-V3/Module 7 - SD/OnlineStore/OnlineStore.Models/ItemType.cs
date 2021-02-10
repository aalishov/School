namespace OnlineStore.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ItemType
    {
        public ItemType()
        {
            this.Items = new HashSet<Item>();
        }

        [Key]
        public int Id{ get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Item> Items { get; set; }


    }
}
