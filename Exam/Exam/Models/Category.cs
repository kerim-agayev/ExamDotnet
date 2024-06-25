using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam.Models;

[Keyless]
public partial class Category
{
    public int Id { get; set; }

    [StringLength(50)]
    public string? CategoryName { get; set; }
}
