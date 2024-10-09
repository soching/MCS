using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("payMonth")]
    public partial class PayMonth
    {
        [Key]
        [Column("monid")]
        public int Monid { get; set; }
        [Column("monname")]
        [StringLength(50)]
        public string? Monname { get; set; }
    }
}
