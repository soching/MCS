using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("item")]
    public partial class Item
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(500)]
        public string? Name { get; set; }
        [Column("category_id")]
        public int? CategoryId { get; set; }
        [Column("classify_id")]
        public int? ClassifyId { get; set; }
        [Column("mou")]
        [StringLength(150)]
        public string? Mou { get; set; }
        [Column("location_id")]
        public int? LocationId { get; set; }
        [Column("vendor_name")]
        [StringLength(250)]
        public string? VendorName { get; set; }
        [Column("item_code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ItemCode { get; set; }
        [Column("image_path")]
        [StringLength(500)]
        public string? ImagePath { get; set; }
        [Column("price", TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        [Column("check_history")]
        public bool? CheckHistory { get; set; }
    }
}
