using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Task_Detail")]
    public partial class TaskDetail
    {
        [Key]
        [Column("Task_Detail_ID")]
        public int TaskDetailId { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Price { get; set; }
        [Column("Task_Code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TaskCode { get; set; }
        [StringLength(50)]
        public string? Measure { get; set; }
        [Column("Standard_Date")]
        public int? StandardDate { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Along { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Height { get; set; }
        [Column("Total_Quantity", TypeName = "decimal(18, 3)")]
        public decimal? TotalQuantity { get; set; }
        [Column("Task_ID")]
        public int TaskId { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Formulas { get; set; }
    }
}
