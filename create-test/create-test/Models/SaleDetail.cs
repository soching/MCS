using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("sale_detail")]
    public partial class SaleDetail
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("so_id")]
        public long? SoId { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("description")]
        [StringLength(250)]
        public string? Description { get; set; }
        [Column("amount", TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("qty", TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column("discount_amt", TypeName = "decimal(18, 2)")]
        public decimal? DiscountAmt { get; set; }
        [Column("discount_per", TypeName = "decimal(18, 2)")]
        public decimal? DiscountPer { get; set; }
        [Column("sub_total", TypeName = "decimal(18, 2)")]
        public decimal? SubTotal { get; set; }
        [Column("account_id")]
        public int? AccountId { get; set; }
        [Column("representative")]
        public int? Representative { get; set; }
        [Column("sale_agent")]
        public int? SaleAgent { get; set; }
        [Column("coordinate_by")]
        public int? CoordinateBy { get; set; }
        [Column("payment_term")]
        public int? PaymentTerm { get; set; }
        [Column("loan_period")]
        public int? LoanPeriod { get; set; }
        [Column("contract_status")]
        public int? ContractStatus { get; set; }
        [Column("deposit", TypeName = "decimal(18, 2)")]
        public decimal? Deposit { get; set; }
        [Column("payment_method")]
        public int? PaymentMethod { get; set; }
    }
}
