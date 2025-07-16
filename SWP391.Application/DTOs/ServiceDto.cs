using SWP391.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP391.Application.DTOs
{
    public class AddTestServiceDto
    {
        [Required]
        [StringLength(255)]
        public string TestName { get; set; } = null!;

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Duration { get; set; } = null!;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal Price { get; set; }
    }

    public class AddAdviseServiceDto
    {
        [Required]
        [StringLength(255)]
        public string ConsultationType { get; set; } = null!;

        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Duration { get; set; } = null!;

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal Price { get; set; }
    }
    public class UpdateTestServiceDto
    {
        [StringLength(255)]
        public string? TestName { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? Duration { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal? Price { get; set; }
    }

    public class UpdateAdviseServiceDto
    {

        [StringLength(255)]
        public string? ConsultationType { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? Duration { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive number.")]
        public decimal? Price { get; set; }
    }
    public class TestServiceDto
    {
        public int Id { get; set; }
        public string TestName { get; set; } = null!;
        public string? Description { get; set; }
        public string Duration { get; set; } = null!;
        public decimal Price { get; set; }
    }
    public class AdviseServiceDto
    {
        public int Id { get; set; }
        public string ConsultationType { get; set; } = null!;
        public string? Description { get; set; }
        public string Duration { get; set; } = null!;
        public decimal Price { get; set; }
    }

}
