using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SWP391.Infrastructure;

public partial class Staff
{
    [Key]
    public int Id { get; set; }

    [StringLength(255)]
    public string? WorkType { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("Staff")]
    public virtual User IdNavigation { get; set; } = null!;
}
