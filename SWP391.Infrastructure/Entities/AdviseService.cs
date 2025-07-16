using SWP391.Infrastructure.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWP391.Infrastructure.Entities
{
    [Table("AdviseService")]
    public partial class AdviseService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public ContactTypeEnum ContactType { get; set; }
        [Required]
        [StringLength(255)]
        public string? ConsultationType { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? Duration { get; set; } // Ví dụ: "30 minutes", "1 hour"

        public decimal Price { get; set; }
        public ServiceStatus ServiceStatus { get; set; } = ServiceStatus.Pending;

        public int? AppointmentId { get; set; }

        [ForeignKey("AppointmentId")]
        public Appointment Appointment { get; set; } = null!;

        public int? AdviseNoteId { get; set; }

        [ForeignKey("AdviseNoteId")]
        public AdviseNote AdviseNote { get; set; } = null!;
    }
}