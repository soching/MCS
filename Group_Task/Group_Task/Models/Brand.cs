using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Brand")]
    public partial class Brand
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("brand_name")]
        [StringLength(250)]
        public string? BrandName { get; set; }
        [Column("abbreviation")]
        [StringLength(250)]
        public string? Abbreviation { get; set; }
        [Column("create_by")]
        [StringLength(100)]
        public string? CreateBy { get; set; }
        [Column("brand_status")]
        [StringLength(50)]
        public string? BrandStatus { get; set; }
    }
}
