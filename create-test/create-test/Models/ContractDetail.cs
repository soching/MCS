using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("contract_detail")]
    public partial class ContractDetail
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("contract_id")]
        public long? ContractId { get; set; }
        [Column("schedule_date", TypeName = "datetime")]
        public DateTime? ScheduleDate { get; set; }
        [Column("payment_type")]
        public int? PaymentType { get; set; }
        [Column("principle_amount", TypeName = "decimal(18, 3)")]
        public decimal? PrincipleAmount { get; set; }
        [Column("interest_amount", TypeName = "decimal(18, 3)")]
        public decimal? InterestAmount { get; set; }
        [Column("loan_amount", TypeName = "decimal(18, 3)")]
        public decimal? LoanAmount { get; set; }
        [Column("last_amount", TypeName = "decimal(18, 3)")]
        public decimal? LastAmount { get; set; }
        [Column("is_invoice")]
        public bool? IsInvoice { get; set; }
        [Column("is_paid")]
        public bool? IsPaid { get; set; }
        [Column("payment_date", TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
        [Column("reference_no")]
        [StringLength(50)]
        public string? ReferenceNo { get; set; }
        [Column("type")]
        [StringLength(50)]
        public string? Type { get; set; }
        [Column("percentage_s", TypeName = "decimal(18, 3)")]
        public decimal? PercentageS { get; set; }
        [Column("down_payment", TypeName = "decimal(18, 3)")]
        public decimal? DownPayment { get; set; }
    }
}
