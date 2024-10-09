using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Items_Material.Models
{
    [Table("itemsmaterial")]
    public partial class Itemsmaterial
    {
        [Key]
        [Column("item_id")]
        public int ItemId { get; set; }
        [Column("groups")]
        [StringLength(250)]
        public string? Groups { get; set; }
        [Column("subgroup")]
        [StringLength(250)]
        public string? Subgroup { get; set; }
        [Column("itemCode")]
        [StringLength(250)]
        public string? ItemCode { get; set; }
        [Column("brandCode")]
        [StringLength(250)]
        public string? BrandCode { get; set; }
        [Column("description_kh")]
        [StringLength(250)]
        public string? DescriptionKh { get; set; }
        [Column("description_en")]
        [StringLength(250)]
        public string? DescriptionEn { get; set; }
        [Column("brand")]
        [StringLength(250)]
        public string? Brand { get; set; }
        [Column("uomStock")]
        [StringLength(250)]
        public string? UomStock { get; set; }
        [Column("cost")]
        [StringLength(250)]
        public string? Cost { get; set; }
        [Column("photo")]
        [StringLength(250)]
        public string? Photo { get; set; }
        [Column("statuses")]
        [StringLength(250)]
        public string? Statuses { get; set; }
        [Column("itemtype")]
        [StringLength(250)]
        public string? Itemtype { get; set; }
        [Column("materialtype")]
        [StringLength(250)]
        public string? Materialtype { get; set; }
        [Column("actions")]
        [StringLength(250)]
        public string? Actions { get; set; }
    }
}
