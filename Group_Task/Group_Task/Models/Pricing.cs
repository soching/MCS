using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("pricing")]
    public partial class Pricing
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("price_date", TypeName = "datetime")]
        public DateTime? PriceDate { get; set; }
        [Column("increment", TypeName = "decimal(18, 2)")]
        public decimal? Increment { get; set; }
        [Column("increment_amount", TypeName = "decimal(18, 2)")]
        public decimal? IncrementAmount { get; set; }
        [Column("approved")]
        public int? Approved { get; set; }
        [Column("entry_by")]
        [StringLength(150)]
        public string? EntryBy { get; set; }
        [Column("last_price", TypeName = "decimal(18, 2)")]
        public decimal? LastPrice { get; set; }
        [Column("original_price", TypeName = "decimal(18, 2)")]
        public decimal? OriginalPrice { get; set; }
        [Column("attached_file")]
        [StringLength(300)]
        public string? AttachedFile { get; set; }
        [Column("comment")]
        [StringLength(500)]
        public string? Comment { get; set; }
    }
}
