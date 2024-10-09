using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Purchase_Request")]
    public partial class PurchaseRequest
    {
        [Key]
        public int Id { get; set; }
        [Column("Transaction_No")]
        [StringLength(50)]
        public string TransactionNo { get; set; } = null!;
        [Column("Transaction_Date", TypeName = "date")]
        public DateTime TransactionDate { get; set; }
        [Column("Delivery_Date", TypeName = "date")]
        public DateTime DeliveryDate { get; set; }
        [Column("Approved_Date", TypeName = "date")]
        public DateTime? ApprovedDate { get; set; }
        [StringLength(50)]
        public string Department { get; set; } = null!;
        [StringLength(50)]
        public string? Status { get; set; }
        [StringLength(100)]
        public string? Note { get; set; }
        [Column("Request_By")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [Column("Updated_By")]
        [StringLength(50)]
        public string? UpdatedBy { get; set; }
        [Column("Checked_By")]
        [StringLength(50)]
        public string? CheckedBy { get; set; }
        [Column("Approved_By")]
        [StringLength(50)]
        public string? ApprovedBy { get; set; }
        [StringLength(50)]
        public string? Attachment { get; set; }
    }
}
