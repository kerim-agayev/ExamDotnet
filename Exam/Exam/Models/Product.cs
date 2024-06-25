using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Exam.Models;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? ProductName { get; set; }

    public int? ProductCount { get; set; }

    public int? ProductPrice { get; set; }

    public int? CategoryId { get; set; }
}
