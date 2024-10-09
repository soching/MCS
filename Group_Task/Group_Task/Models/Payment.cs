using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("payment")]
    public partial class Payment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("invoice_id")]
        [StringLength(50)]
        [Unicode(false)]
        public string? InvoiceId { get; set; }
        [Column("payment_date", TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column("paid_amount", TypeName = "decimal(10, 2)")]
        public decimal? PaidAmount { get; set; }
        [Column("recieve_amount_usd", TypeName = "decimal(10, 2)")]
        public decimal? RecieveAmountUsd { get; set; }
        [Column("return_amount_usd", TypeName = "decimal(10, 2)")]
        public decimal? ReturnAmountUsd { get; set; }
        [Column("recieve_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? RecieveBy { get; set; }
        [Column("term_id")]
        public int? TermId { get; set; }
        [Column("condition_id")]
        public int? ConditionId { get; set; }
        [Column("receipt_no")]
        [StringLength(20)]
        [Unicode(false)]
        public string? ReceiptNo { get; set; }
        [Column("customer_id")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CustomerId { get; set; }
        [Column("discount_type")]
        public int? DiscountType { get; set; }
        [Column("discount_percentage", TypeName = "decimal(18, 2)")]
        public decimal? DiscountPercentage { get; set; }
        [Column("discount_amount", TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column("payment_status")]
        public int? PaymentStatus { get; set; }
        [Column("project_id")]
        public int? ProjectId { get; set; }
        [Column("exchange_rate", TypeName = "decimal(18, 2)")]
        public decimal? ExchangeRate { get; set; }
        [Column("discount_by")]
        [StringLength(50)]
        [Unicode(false)]
        public string? DiscountBy { get; set; }
        [Column("payment_type")]
        public int? PaymentType { get; set; }
        [Column("reference_no")]
        [StringLength(50)]
        public string? ReferenceNo { get; set; }
    }
}
