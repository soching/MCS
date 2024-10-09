using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("payment_detail")]
    public partial class PaymentDetail
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("payment_id")]
        public int PaymentId { get; set; }
        [Column("payment_type")]
        [StringLength(550)]
        [Unicode(false)]
        public string? PaymentType { get; set; }
        [Column("amount", TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("for_date")]
        [StringLength(500)]
        [Unicode(false)]
        public string? ForDate { get; set; }
        [Column("deposit")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Deposit { get; set; }
        [Column("schedule")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Schedule { get; set; }
        [Column("loan")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Loan { get; set; }
        [Column("discount", TypeName = "decimal(18, 2)")]
        public decimal? Discount { get; set; }
        [Column("description")]
        [StringLength(500)]
        public string? Description { get; set; }
        [Column("qty", TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column("contract_detail_id")]
        public int? ContractDetailId { get; set; }
        [Column("payment_date", TypeName = "datetime")]
        public DateTime? PaymentDate { get; set; }
    }
}
