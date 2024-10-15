using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
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
