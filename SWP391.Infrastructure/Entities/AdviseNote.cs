using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using SWP391.Infrastructure.Enums;

namespace SWP391.Infrastructure.Entities
{
    [Table("AdviseNote")]
    public partial class AdviseNote
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string? Note { get; set; }

        [StringLength(255)]
        public string? Suggestion { get; set; }
        [Required]
        public ServiceStatus ServiceStatus { get; set; } = ServiceStatus.Pending;

        [Required]
        public ContactTypeEnum ContactType { get; set; }

        public int? AppointmentId { get; set; }

        [ForeignKey("AppointmentId")]
        public Appointment? Appointment { get; set; }

        public int? ConsultantId { get; set; }

        [ForeignKey("ConsultantId")]
        public User? Consultant { get; set; }

        [ForeignKey("AdviseServiceId")]
        public AdviseService AdviseService { get; set; } = null!;
    }
}