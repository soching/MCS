using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("CursorTest")]
    public partial class CursorTest
    {
        [Key]
        public int Autonum { get; set; }
        [Column("task_id")]
        public int? TaskId { get; set; }
        [Column("task_name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
        [Column("paid_date")]
        [StringLength(20)]
        [Unicode(false)]
        public string? PaidDate { get; set; }
        [Column("col")]
        [StringLength(6)]
        [Unicode(false)]
        public string? Col { get; set; }
        [Column("amount", TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("paid_month")]
        [StringLength(20)]
        [Unicode(false)]
        public string? PaidMonth { get; set; }
    }
}
