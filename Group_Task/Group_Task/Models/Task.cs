using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Task")]
    public partial class Task
    {
        [Key]
        [Column("Task_ID")]
        public int TaskId { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Price { get; set; }
        [Column("Task_Code")]
        [StringLength(20)]
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
        [Column("Floor_ID")]
        public int FloorId { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 3)")]
        public decimal? TotalAmount { get; set; }

        [ForeignKey("FloorId")]
        [InverseProperty("Tasks")]
        public virtual Floor Floor { get; set; } = null!;
    }
}
