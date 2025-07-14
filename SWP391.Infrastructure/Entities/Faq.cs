using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SWP391.Infrastructure;

[Table("FAQ")]
public partial class Faq
{
    [Key]
    public int Id { get; set; }

    [StringLength(1000)]
    public string? Question { get; set; }

    [StringLength(1000)]
    public string? Answer { get; set; }
}
