using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("SupplierItem")]
    public partial class SupplierItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("supplier")]
        [StringLength(250)]
        public string? Supplier { get; set; }
        [Column("item_material")]
        [StringLength(250)]
        public string? ItemMaterial { get; set; }
        [Column("uom")]
        [StringLength(250)]
        public string? Uom { get; set; }
        [Column("price")]
        public int? Price { get; set; }
        [Column("supplier_status")]
        [StringLength(100)]
        public string? SupplierStatus { get; set; }
    }
}
