using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("sale_order")]
    public partial class SaleOrder
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("issue_date", TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        [Column("seller_id")]
        public int? SellerId { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("customer_id")]
        public int? CustomerId { get; set; }
        [Column("status_date", TypeName = "datetime")]
        public DateTime? StatusDate { get; set; }
        [Column("grand_total", TypeName = "decimal(18, 2)")]
        public decimal? GrandTotal { get; set; }
        [Column("net_amount", TypeName = "decimal(18, 2)")]
        public decimal? NetAmount { get; set; }
        [Column("discount_per", TypeName = "decimal(18, 2)")]
        public decimal? DiscountPer { get; set; }
        [Column("discount_amount", TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmount { get; set; }
        [Column("order_no")]
        [StringLength(50)]
        public string? OrderNo { get; set; }
        [Column("submit")]
        public bool? Submit { get; set; }
        [Column("submit_by")]
        [StringLength(50)]
        public string? SubmitBy { get; set; }
        [Column("submit_date", TypeName = "datetime")]
        public DateTime? SubmitDate { get; set; }
        [Column("verify")]
        public bool? Verify { get; set; }
        [Column("verify_by")]
        [StringLength(50)]
        public string? VerifyBy { get; set; }
        [Column("verify_date", TypeName = "datetime")]
        public DateTime? VerifyDate { get; set; }
        [Column("approve1")]
        public bool? Approve1 { get; set; }
        [Column("approve1_by")]
        [StringLength(50)]
        public string? Approve1By { get; set; }
        [Column("approve1_date", TypeName = "datetime")]
        public DateTime? Approve1Date { get; set; }
        [Column("approve2")]
        public bool? Approve2 { get; set; }
        [Column("approve2_by")]
        [StringLength(50)]
        public string? Approve2By { get; set; }
        [Column("approve2_date", TypeName = "datetime")]
        public DateTime? Approve2Date { get; set; }
    }
}
