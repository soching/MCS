using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("invoice")]
    public partial class Invoice
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("customer_id")]
        [StringLength(20)]
        [Unicode(false)]
        public string? CustomerId { get; set; }
        [Column("discount", TypeName = "decimal(5, 2)")]
        public decimal? Discount { get; set; }
        [Column("discount_amount", TypeName = "decimal(8, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column("issue_date", TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        [Column("invoice_no")]
        [StringLength(13)]
        [Unicode(false)]
        public string InvoiceNo { get; set; } = null!;
        [Column("invoice_status")]
        public int? InvoiceStatus { get; set; }
        [Column("reference_no")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ReferenceNo { get; set; }
        [Column("sold_by")]
        [StringLength(250)]
        [Unicode(false)]
        public string? SoldBy { get; set; }
        [Column("sub_total", TypeName = "decimal(8, 2)")]
        public decimal? SubTotal { get; set; }
        [Column("total_amount", TypeName = "decimal(21, 2)")]
        public decimal? TotalAmount { get; set; }
        [Column("vat", TypeName = "decimal(5, 2)")]
        public decimal? Vat { get; set; }
        [Column("vat_amount", TypeName = "decimal(8, 2)")]
        public decimal? VatAmount { get; set; }
        [Column("remark")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Remark { get; set; }
        [Column("term_id")]
        public int? TermId { get; set; }
        [Column("term_condition_id")]
        public int TermConditionId { get; set; }
        [Column("include_vat")]
        [StringLength(50)]
        [Unicode(false)]
        public string? IncludeVat { get; set; }
        [Column("exchange_rate", TypeName = "decimal(18, 2)")]
        public decimal? ExchangeRate { get; set; }
        [Column("due_date", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("deposit_amount", TypeName = "decimal(18, 2)")]
        public decimal? DepositAmount { get; set; }
        [Column("bad_debt_amount", TypeName = "decimal(18, 2)")]
        public decimal? BadDebtAmount { get; set; }
        [Column("recieved_amount", TypeName = "decimal(8, 2)")]
        public decimal? RecievedAmount { get; set; }
        [Column("block_no")]
        [StringLength(50)]
        public string? BlockNo { get; set; }
        [Column("house_no")]
        [StringLength(50)]
        public string? HouseNo { get; set; }
    }
}
