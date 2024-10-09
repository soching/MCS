using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Keyless]
    public partial class ReportPvcClaim
    {
        [Column("Constructor_Name")]
        [StringLength(150)]
        public string? ConstructorName { get; set; }
        [Column("Task_Master_Name")]
        [StringLength(500)]
        public string? TaskMasterName { get; set; }
        [Column("Week_Num")]
        public int? WeekNum { get; set; }
        [Column("Zone_Name")]
        [StringLength(150)]
        public string? ZoneName { get; set; }
        [Column("Block_No")]
        [StringLength(200)]
        public string? BlockNo { get; set; }
        [Column("Building_No")]
        [StringLength(200)]
        public string? BuildingNo { get; set; }
        [Column("Street_No")]
        [StringLength(200)]
        public string? StreetNo { get; set; }
        [Column("House_No")]
        [StringLength(200)]
        public string? HouseNo { get; set; }
        [Column("House_Type_Name")]
        [StringLength(250)]
        public string? HouseTypeName { get; set; }
        [Column("Weekly_Amount", TypeName = "decimal(18, 4)")]
        public decimal? WeeklyAmount { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 4)")]
        public decimal? TotalAmount { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("Result_ID")]
        public int ResultId { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        [Column("Setup_Task_ID")]
        public int? SetupTaskId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? RetentionAmount { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("House_Type_ID")]
        public int HouseTypeId { get; set; }
        [Column("Project_Name")]
        [StringLength(200)]
        public string? ProjectName { get; set; }
        [StringLength(200)]
        public string? Label { get; set; }
        [Column("Task_Code")]
        [StringLength(50)]
        public string? TaskCode { get; set; }
        [Column("Setup_Master_ID")]
        public int SetupMasterId { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        [Column("LOA_CODE")]
        [StringLength(100)]
        public string? LoaCode { get; set; }
        [Column("boq_code")]
        [StringLength(500)]
        public string? BoqCode { get; set; }
        [Column("Total_Paid", TypeName = "decimal(18, 3)")]
        public decimal? TotalPaid { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
    }
}
