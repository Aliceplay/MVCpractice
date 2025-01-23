using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVCpractice.Models;

[Keyless]
public partial class DanIngredient
{
    [Column("DanID")]
    public int DanId { get; set; }

    [Column("IngreID")]
    public int IngreId { get; set; }
}
