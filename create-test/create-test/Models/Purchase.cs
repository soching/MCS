using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Purchase")]
    public partial class Purchase
    {
        [Key]
        [Column("Purchase_ID")]
        public int PurchaseId { get; set; }
        [Column("Purchase_Date", TypeName = "datetime")]
        public DateTime? PurchaseDate { get; set; }
        [Column("Purchase_No")]
        [StringLength(50)]
        public string? PurchaseNo { get; set; }
        [Column("Purchase_Status")]
        public int? PurchaseStatus { get; set; }
        [StringLength(500)]
        public string? Note { get; set; }
        [Column("Vendor_ID")]
        public int? VendorId { get; set; }
        [Column("Account_ID")]
        public int? AccountId { get; set; }
        [Column("Order_By")]
        public int? OrderBy { get; set; }
        [Column("Reference_No")]
        [StringLength(50)]
        public string? ReferenceNo { get; set; }
        [Column("Control_By")]
        public int? ControlBy { get; set; }
        [Column("Approve_By")]
        public int? ApproveBy { get; set; }
    }
}
