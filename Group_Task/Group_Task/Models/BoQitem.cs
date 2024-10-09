using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("BoQItem")]
    public partial class BoQitem
    {
        [Key]
        [Column("BoQ_Item_ID")]
        public int BoQItemId { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("House_Type_ID")]
        public int? HouseTypeId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Unit { get; set; }
        [Column("BoQ_Type")]
        public int? BoQType { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        [Column("Created_By")]
        public int? CreatedBy { get; set; }
        public int? Approve1 { get; set; }
        public int? Approve2 { get; set; }
        public int? Approve3 { get; set; }
        public int? Approve4 { get; set; }
        [Column("Approve_By1")]
        [StringLength(150)]
        public string? ApproveBy1 { get; set; }
        [Column("Approve_By2")]
        [StringLength(150)]
        public string? ApproveBy2 { get; set; }
        [Column("Approve_By3")]
        [StringLength(150)]
        public string? ApproveBy3 { get; set; }
        [Column("Approve_By4")]
        [StringLength(150)]
        public string? ApproveBy4 { get; set; }
        [Column("Approve_Date1", TypeName = "datetime")]
        public DateTime? ApproveDate1 { get; set; }
        [Column("Approve_Date2", TypeName = "datetime")]
        public DateTime? ApproveDate2 { get; set; }
        [Column("Approve_Date3", TypeName = "datetime")]
        public DateTime? ApproveDate3 { get; set; }
        [Column("Approve_Date4", TypeName = "datetime")]
        public DateTime? ApproveDate4 { get; set; }
        [Column("Item_ID")]
        public int? ItemId { get; set; }
    }
}
