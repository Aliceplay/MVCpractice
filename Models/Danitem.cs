using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVCpractice.Models;

public partial class Danitem
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(10)]
    public string? Name { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ImageUrl { get; set; }

    public int? Price { get; set; }
}
