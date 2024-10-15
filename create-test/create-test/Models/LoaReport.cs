using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    public partial class LoaReport
    {
        [Column("ID")]
        public long? Id { get; set; }
        [Column("House_ID")]
        public int HouseId { get; set; }
        [Column("LOA_CODE")]
        [StringLength(100)]
        public string? LoaCode { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Zone_ID")]
        public int? ZoneId { get; set; }
        [Column("Block_No")]
        [StringLength(200)]
        public string? BlockNo { get; set; }
        [Column("Building_No")]
        [StringLength(200)]
        public string? BuildingNo { get; set; }
        [Column("House_No")]
        [StringLength(200)]
        public string? HouseNo { get; set; }
        [Column("Street_No")]
        [StringLength(200)]
        public string? StreetNo { get; set; }
        [Column("House_Type_Name")]
        [StringLength(250)]
        public string? HouseTypeName { get; set; }
        [StringLength(200)]
        public string? Label { get; set; }
        public int? Approve5 { get; set; }
        public bool? Status { get; set; }
        [Column("Task_Type")]
        [StringLength(500)]
        public string? TaskType { get; set; }
        [Column("Setup_Master_ID")]
        public int? SetupMasterId { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        [Column("Task_Master_Name")]
        [StringLength(500)]
        public string? TaskMasterName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Unit { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        [Column("House_Type_ID")]
        public int? HouseTypeId { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string Remark { get; set; } = null!;
        [Column("Total_Amount", TypeName = "decimal(18, 3)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "decimal(19, 3)")]
        public decimal? PaidAmount { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? RetentionAmount { get; set; }
        [Column("remaining_amount", TypeName = "decimal(19, 3)")]
        public decimal? RemainingAmount { get; set; }
    }
}
