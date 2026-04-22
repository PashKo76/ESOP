using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Order
    {
        [Key]
        public long OrderId { get; set; }

        public long? CustomerId { get; set; }

        [Required]
        [StringLength(1000)]
        public string OrderNumber { get; set; } = string.Empty;

        [Required]
        public DateTime OrderDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        [StringLength(100)]
        public string CreateBy { get; set; } = "SYSTEM";

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        public string ModifyBy { get; set; } = "SYSTEM";

        public DateTime ModifyDate { get; set; } = DateTime.UtcNow;

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
