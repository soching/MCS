using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Expendmonth_ByWeek")]
    public partial class ExpendmonthByWeek
    {
        [Key]
        public int Autonum { get; set; }
        [Column("task_id")]
        public int? TaskId { get; set; }
        [Column("task_name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
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
        [Column("order_by")]
        public int? OrderBy { get; set; }
    }
}
