using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SWP391.Infrastructure.Entities
{
    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int Id { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string VoucherCode { get; set; } = string.Empty;

        public float ValueDiscount { get; set; }

        // Foreign key to User
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; } = null!;

        // Navigation property cho AdviseNotes (mới)
        public ICollection<AdviseNote> AdviseNotes { get; set; } = new List<AdviseNote>();

        // Navigation property cho TestResults (mới)
        public ICollection<TestResult> TestResults { get; set; } = new List<TestResult>();
    }
}