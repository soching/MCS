using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Keyless]
    public partial class View7
    {
        [Column("House_ID")]
        public int HouseId { get; set; }
        [Column("House_Code")]
        [StringLength(100)]
        public string? HouseCode { get; set; }
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
        [Column("House_Type_ID")]
        public int HouseTypeId { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? Length { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }
        [StringLength(100)]
        public string? Available { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Status_House")]
        public int? StatusHouse { get; set; }
        public int? Classify { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        public int? Unify { get; set; }
        [Column("Parent_ID")]
        public int? ParentId { get; set; }
        [Column("Task_Project")]
        [StringLength(500)]
        public string? TaskProject { get; set; }
        public int? Level { get; set; }
        [StringLength(200)]
        public string? Label { get; set; }
        [Column("Delivery_Date", TypeName = "datetime")]
        public DateTime? DeliveryDate { get; set; }
        [Column("Warranty_Date", TypeName = "datetime")]
        public DateTime? WarrantyDate { get; set; }
        [Column("Other_Code")]
        [StringLength(50)]
        public string? OtherCode { get; set; }
        [Column("Zone_ID")]
        public int? ZoneId { get; set; }
        [Column("Group_Project_ID")]
        public int? GroupProjectId { get; set; }
        [Column("CHouseNo")]
        [StringLength(50)]
        public string? ChouseNo { get; set; }
        public double? Size { get; set; }
        [Column("TStreet")]
        [StringLength(200)]
        public string? Tstreet { get; set; }
        [Column("DPath")]
        [StringLength(1000)]
        [Unicode(false)]
        public string? Dpath { get; set; }
        public int? Duration { get; set; }
        public int? Buffer { get; set; }
    }
}
