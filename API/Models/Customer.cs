using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }

        [Required]
        [StringLength(1000)]
        public string CustomerNumber { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public DateTime Dob { get; set; }

        public bool IsDeleted { get; set; } = false;

        [StringLength(100)]
        public string CreateBy { get; set; } = "SYSTEM";

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [StringLength(100)]
        public string ModifyBy { get; set; } = "SYSTEM";

        public DateTime ModifyDate { get; set; } = DateTime.UtcNow;
    }
}
