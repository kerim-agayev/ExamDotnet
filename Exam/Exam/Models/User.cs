using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam.Models;

[Table("USERS")]
public partial class User
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? UserName { get; set; }

    [StringLength(50)]
    public string? UserType { get; set; }

    [StringLength(50)]
    public string? UserPassword { get; set; }
}
