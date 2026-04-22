using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class OrderItem
    {
        [Key]
        public long OrderItemId { get; set; }

        public long? OrderId { get; set; }

        public long? ProductId { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        public bool IsDeleted { get; set; } = false;

        [StringLength(100)]
        public string CreateBy { get; set; } = "SYSTEM";

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        public string ModifyBy { get; set; } = "SYSTEM";

        public DateTime ModifyDate { get; set; } = DateTime.UtcNow;

        [ForeignKey("OrderId")]
        public Order? Order { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }
    }
}
