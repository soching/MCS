using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    [Table("report")]
    public partial class Report
    {
        [Column("Block_No")]
        [StringLength(200)]
        public string? BlockNo { get; set; }
        [Column("Building_No")]
        [StringLength(200)]
        public string? BuildingNo { get; set; }
        [Column("House_ID")]
        public int HouseId { get; set; }
        [Column("House_No")]
        [StringLength(200)]
        public string? HouseNo { get; set; }
        [Column("House_Type_Name")]
        [StringLength(250)]
        public string? HouseTypeName { get; set; }
        [Column("Project_Name")]
        [StringLength(200)]
        public string? ProjectName { get; set; }
        [Column("Street_No")]
        [StringLength(200)]
        public string? StreetNo { get; set; }
        [Column("Project_ID")]
        public int ProjectId { get; set; }
        [Column("House_Type_ID")]
        public int HouseTypeId { get; set; }
        [StringLength(200)]
        public string? Label { get; set; }
        [Column("Task_Master_Name")]
        [StringLength(500)]
        public string? TaskMasterName { get; set; }
        [Column("Task_Master_ID")]
        public int TaskMasterId { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        [Column("Task_Code")]
        [StringLength(50)]
        public string? TaskCode { get; set; }
        [Column("TaskGroup_Name")]
        [StringLength(300)]
        public string? TaskGroupName { get; set; }
        [Column("Setup_Master_ID")]
        public int? SetupMasterId { get; set; }
        public int TaskGroup { get; set; }
        [Column("LOA_CODE")]
        [StringLength(100)]
        public string? LoaCode { get; set; }
        [Column("boq_code")]
        [StringLength(100)]
        public string? BoqCode { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 3)")]
        public decimal? TotalAmount { get; set; }
        [Column("Total_Paid", TypeName = "decimal(18, 3)")]
        public decimal? TotalPaid { get; set; }
    }
}
