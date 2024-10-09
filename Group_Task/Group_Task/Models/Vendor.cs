using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Vendor")]
    public partial class Vendor
    {
        [Key]
        [Column("Vendor_ID")]
        public int VendorId { get; set; }
        [Column("Vendor_Name")]
        [StringLength(500)]
        public string? VendorName { get; set; }
        [StringLength(500)]
        public string? Tel { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(500)]
        public string? Address { get; set; }
        [Column("Vendor_Type")]
        public int? VendorType { get; set; }
        [Column("Vendor_Status")]
        public int? VendorStatus { get; set; }
    }
}
