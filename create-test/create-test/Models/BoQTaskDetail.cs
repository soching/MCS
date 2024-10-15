using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("BoQ_Task_Detail")]
    public partial class BoQTaskDetail
    {
        [Key]
        [Column("BoQ_Task_Detail_ID")]
        public int BoQTaskDetailId { get; set; }
        [Column("BoQ_Task_ID")]
        public int? BoQTaskId { get; set; }
        [Column("Task_Detail_ID")]
        public int? TaskDetailId { get; set; }
        [Column("Standard_Date")]
        public int? StandardDate { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Price { get; set; }
        [StringLength(50)]
        public string? Measure { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 3)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Along { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Height { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Formulas { get; set; }
        [Column("Total_Quantity", TypeName = "decimal(18, 3)")]
        public decimal? TotalQuantity { get; set; }
        public int? Level { get; set; }
        [Column("Order_By")]
        public int? OrderBy { get; set; }
        [Column("Is_Require")]
        public int? IsRequire { get; set; }
        [Column("Task_Detail_Name")]
        [StringLength(500)]
        public string? TaskDetailName { get; set; }
        [Column("Setup_TaskDetail_ID")]
        public int? SetupTaskDetailId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "ntext")]
        public string? Specs { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Factor { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Volumn { get; set; }

        [ForeignKey("BoQTaskId")]
        [InverseProperty("BoQTaskDetails")]
        public virtual BoQTask? BoQTask { get; set; }
    }
}
