using SWP391.Infrastructure.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Infrastructure.Entities
{
    [Table("TestResult")]
    public partial class TestResult
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string? Result { get; set; }

        [StringLength(255)]
        public string? Suggestion { get; set; }

        [StringLength(255)]
        public string? Note { get; set; }
        public ServiceStatus ServiceStatus { get; set; } = ServiceStatus.Pending;

        public int? AppointmentId { get; set; }

        [ForeignKey("AppointmentId")]
        public Appointment? Appointment { get; set; }
        public int TestServiceId { get; set; }

        [ForeignKey("TestServiceId")]
        public TestService TestService { get; set; } = null!;
    }
}