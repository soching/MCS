using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("BoQ_Task")]
    public partial class BoQTask
    {
        public BoQTask()
        {
            BoQTaskDetails = new HashSet<BoQTaskDetail>();
        }

        [Key]
        [Column("BoQ_Task_ID")]
        public int BoQTaskId { get; set; }
        [Column("BoQ_Floor_ID")]
        public int BoQFloorId { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Quantity { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; }
        [StringLength(50)]
        public string? Measure { get; set; }
        [Column("Standard_Date")]
        public int? StandardDate { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Along { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Height { get; set; }
        [Column("Total_Quantity", TypeName = "decimal(18, 4)")]
        public decimal? TotalQuantity { get; set; }
        [Column("Task_ID")]
        public int? TaskId { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 4)")]
        public decimal? TotalAmount { get; set; }
        [Column("Order_by")]
        public int? OrderBy { get; set; }
        [Column("Can_Edit")]
        public bool? CanEdit { get; set; }
        [Column("Is_Require")]
        public int? IsRequire { get; set; }
        [Column("Reference_Num")]
        public int? ReferenceNum { get; set; }
        [Column("Paid_Amount", TypeName = "decimal(18, 4)")]
        public decimal? PaidAmount { get; set; }
        [Column("Item_ID")]
        public int? ItemId { get; set; }
        [Column("Setup_Task_ID")]
        public int? SetupTaskId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Area { get; set; }
        [Column(TypeName = "ntext")]
        public string? Specs { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Factor { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Volumn { get; set; }

        [ForeignKey("BoQFloorId")]
        [InverseProperty("BoQTasks")]
        public virtual BoQFloor BoQFloor { get; set; } = null!;
        [InverseProperty("BoQTask")]
        public virtual ICollection<BoQTaskDetail> BoQTaskDetails { get; set; }
    }
}
