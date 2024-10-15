using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Column("Product_ID")]
        public int ProductId { get; set; }
        [Column("Description_KH")]
        [StringLength(500)]
        public string? DescriptionKh { get; set; }
        [Column("Description_EN")]
        [StringLength(500)]
        public string? DescriptionEn { get; set; }
        [Column("Category_ID")]
        public int? CategoryId { get; set; }
        [Column("Classify_ID")]
        public int? ClassifyId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        [Column("Account_ID")]
        public int? AccountId { get; set; }
        [Column("COGS_ID")]
        public int? CogsId { get; set; }
        [Column("Income_ID")]
        public int? IncomeId { get; set; }
        [Column("Brand_ID")]
        public int? BrandId { get; set; }
        [Column("Vendor_ID")]
        public int? VendorId { get; set; }
        [StringLength(500)]
        public string? Photo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Height { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Width { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Along { get; set; }
        [Column("UM")]
        [StringLength(50)]
        public string? Um { get; set; }
    }
}
