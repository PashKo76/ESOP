using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }

        [Required]
        [StringLength(1000)]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string ProductCode { get; set; } = string.Empty;

        [Required]
        [Range(0, int.MaxValue)]
        public int AvailableQuantity { get; set; }

        public bool IsDeleted { get; set; } = false;

        [StringLength(100)]
        public string CreateBy { get; set; } = "SYSTEM";

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        public string ModifyBy { get; set; } = "SYSTEM";

        public DateTime ModifyDate { get; set; } = DateTime.UtcNow;

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
