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

        public bool IsVisible { get; set; } = true;
        public ServiceStatus ServiceStatus { get; set; } = ServiceStatus.Pending;

        // Foreign key to Appointment
        public int? AppointmentId { get; set; }

        // Navigation property to Appointment
        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; } = null!;

        // Foreign key to TestResult
        public int? TestResultId { get; set; }

        // Navigation property to TestResult
        [ForeignKey("TestResultId")]
        public TestResult TestResult { get; set; } = null!;
    }
}