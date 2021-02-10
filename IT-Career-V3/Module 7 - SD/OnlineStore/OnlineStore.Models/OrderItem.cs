namespace OnlineStore.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    public class OrderItem
    {
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }


        [ForeignKey(nameof(Item))]
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
