using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    [Table("ABCD")]
    public partial class Abcd
    {
        [Column("Assign_House_ID")]
        public int AssignHouseId { get; set; }
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
        [Column("Task_Name")]
        [StringLength(500)]
        public string? TaskName { get; set; }
        [Column("Task_Master_ID")]
        public int TaskMasterId { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        [Column("Task_Code")]
        public bool? TaskCode { get; set; }
        [Column("Zone_ID")]
        public int? ZoneId { get; set; }
        [Column("Zone_Name")]
        [StringLength(150)]
        public string? ZoneName { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 4)")]
        public decimal? TotalAmount { get; set; }
        [Column("LOA_CODE")]
        [StringLength(100)]
        public string? LoaCode { get; set; }
        [Column("Setup_Master_ID")]
        public int? SetupMasterId { get; set; }
    }
}
