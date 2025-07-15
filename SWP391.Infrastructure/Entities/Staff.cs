using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SWP391.Infrastructure.Entities;

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
