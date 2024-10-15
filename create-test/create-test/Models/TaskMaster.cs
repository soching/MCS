using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Task_Master")]
    public partial class TaskMaster
    {
        [Key]
        [Column("Task_Master_ID")]
        public int TaskMasterId { get; set; }
        public int? TaskGroup { get; set; }
        [Column("Task_Code")]
        [StringLength(50)]
        public string? TaskCode { get; set; }
        [Column("Task_Name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
        public bool? Status { get; set; }
        [Column("Task_Type")]
        [StringLength(500)]
        public string? TaskType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Category { get; set; }
        [Column("Reference_Num")]
        [StringLength(50)]
        public string? ReferenceNum { get; set; }
        [Column("Old_Code")]
        [StringLength(50)]
        public string? OldCode { get; set; }
        [Column("Order_No")]
        public int? OrderNo { get; set; }
        [Column("Formular_Side", TypeName = "decimal(18, 4)")]
        public decimal? FormularSide { get; set; }
        [Column("Formular_Middle", TypeName = "decimal(18, 4)")]
        public decimal? FormularMiddle { get; set; }
    }
}
