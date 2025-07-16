using SWP391.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Infrastructure.Entities
{
    [Table("TestService")]
    public partial class TestService
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string TestName { get; set; } = null!;

        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? Duration { get; set; }

        public decimal Price { get; set; }
        public ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();

    }
}