using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Condition_Bonus")]
    public partial class ConditionBonu
    {
        [Key]
        public int ConAutonum { get; set; }
        [StringLength(200)]
        public string? ConName { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Condition { get; set; }
        public int? Status { get; set; }
    }
}
