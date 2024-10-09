using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("invoice_detail")]
    public partial class InvoiceDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("item_code")]
        [StringLength(100)]
        [Unicode(false)]
        public string? ItemCode { get; set; }
        [Column("item_id")]
        [StringLength(11)]
        [Unicode(false)]
        public string? ItemId { get; set; }
        [Column("invoice_id")]
        public int? InvoiceId { get; set; }
        [Column("description")]
        [StringLength(500)]
        public string? Description { get; set; }
        [Column("sequence_no")]
        public int? SequenceNo { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("over_qty")]
        public int? OverQty { get; set; }
        [Column("unit_price", TypeName = "decimal(10, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column("original_price", TypeName = "decimal(10, 2)")]
        public decimal? OriginalPrice { get; set; }
        [Column("discount_per", TypeName = "decimal(18, 2)")]
        public decimal? DiscountPer { get; set; }
        [Column("discount_amount", TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column("amount", TypeName = "decimal(22, 2)")]
        public decimal? Amount { get; set; }
        [Column("contract_detail_id")]
        public int? ContractDetailId { get; set; }
        [StringLength(50)]
        public string? TransactionNum { get; set; }
        [Column("status")]
        public bool? Status { get; set; }
        [Column("remark", TypeName = "ntext")]
        public string? Remark { get; set; }
    }
}
