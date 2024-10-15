using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Money_ByWeek")]
    public partial class MoneyByWeek
    {
        [Key]
        public int Autonum { get; set; }
        [Column("Approve5_By")]
        [StringLength(500)]
        public string? Approve5By { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        [Column("col1", TypeName = "decimal(18, 2)")]
        public decimal? Col1 { get; set; }
        [Column("col2", TypeName = "decimal(18, 2)")]
        public decimal? Col2 { get; set; }
        [Column("col3", TypeName = "decimal(18, 2)")]
        public decimal? Col3 { get; set; }
        [Column("col4", TypeName = "decimal(18, 2)")]
        public decimal? Col4 { get; set; }
        [Column("col5", TypeName = "decimal(18, 2)")]
        public decimal? Col5 { get; set; }
        [Column("paid_month")]
        [StringLength(20)]
        [Unicode(false)]
        public string? PaidMonth { get; set; }
    }
}
