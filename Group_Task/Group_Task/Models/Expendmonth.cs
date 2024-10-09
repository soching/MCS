using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Expendmonth")]
    public partial class Expendmonth
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
        [Column("col6", TypeName = "decimal(18, 2)")]
        public decimal? Col6 { get; set; }
        [Column("col7", TypeName = "decimal(18, 2)")]
        public decimal? Col7 { get; set; }
        [Column("col8", TypeName = "decimal(18, 2)")]
        public decimal? Col8 { get; set; }
        [Column("col9", TypeName = "decimal(18, 2)")]
        public decimal? Col9 { get; set; }
        [Column("col10", TypeName = "decimal(18, 2)")]
        public decimal? Col10 { get; set; }
        [Column("col11", TypeName = "decimal(18, 2)")]
        public decimal? Col11 { get; set; }
        [Column("col12", TypeName = "decimal(18, 2)")]
        public decimal? Col12 { get; set; }
        [Column("col13", TypeName = "decimal(18, 2)")]
        public decimal? Col13 { get; set; }
        [Column("col14", TypeName = "decimal(18, 2)")]
        public decimal? Col14 { get; set; }
        [Column("col15", TypeName = "decimal(18, 2)")]
        public decimal? Col15 { get; set; }
        [Column("col16", TypeName = "decimal(18, 2)")]
        public decimal? Col16 { get; set; }
        [Column("col17", TypeName = "decimal(18, 2)")]
        public decimal? Col17 { get; set; }
        [Column("col18", TypeName = "decimal(18, 2)")]
        public decimal? Col18 { get; set; }
        [Column("col19", TypeName = "decimal(18, 2)")]
        public decimal? Col19 { get; set; }
        [Column("col20", TypeName = "decimal(18, 2)")]
        public decimal? Col20 { get; set; }
        [Column("col21", TypeName = "decimal(18, 2)")]
        public decimal? Col21 { get; set; }
        [Column("col22", TypeName = "decimal(18, 2)")]
        public decimal? Col22 { get; set; }
        [Column("col23", TypeName = "decimal(18, 2)")]
        public decimal? Col23 { get; set; }
        [Column("col24", TypeName = "decimal(18, 2)")]
        public decimal? Col24 { get; set; }
        [Column("col25", TypeName = "decimal(18, 2)")]
        public decimal? Col25 { get; set; }
        [Column("col26", TypeName = "decimal(18, 2)")]
        public decimal? Col26 { get; set; }
        [Column("col27", TypeName = "decimal(18, 2)")]
        public decimal? Col27 { get; set; }
        [Column("col28", TypeName = "decimal(18, 2)")]
        public decimal? Col28 { get; set; }
        [Column("col29", TypeName = "decimal(18, 2)")]
        public decimal? Col29 { get; set; }
        [Column("col30", TypeName = "decimal(18, 2)")]
        public decimal? Col30 { get; set; }
        [Column("col31", TypeName = "decimal(18, 2)")]
        public decimal? Col31 { get; set; }
        [Column("paid_month")]
        [StringLength(20)]
        [Unicode(false)]
        public string? PaidMonth { get; set; }
    }
}
