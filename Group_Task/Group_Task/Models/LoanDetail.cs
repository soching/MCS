using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("loan_detail")]
    public partial class LoanDetail
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("loan_id")]
        public long? LoanId { get; set; }
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
    }
}
