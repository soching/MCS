using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("contract")]
    public partial class Contract
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("sd_id")]
        public long? SdId { get; set; }
        [Column("customer_id")]
        public int? CustomerId { get; set; }
        [Column("house_id")]
        public int? HouseId { get; set; }
        [Column("contract_date", TypeName = "datetime")]
        public DateTime? ContractDate { get; set; }
        [Column("contract_amount", TypeName = "decimal(18, 2)")]
        public decimal? ContractAmount { get; set; }
        [Column("duration")]
        public int? Duration { get; set; }
        [Column("create_by")]
        [StringLength(50)]
        public string? CreateBy { get; set; }
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
        [Column("contract_no")]
        [StringLength(50)]
        public string? ContractNo { get; set; }
        [Column("percentage_payment")]
        public int? PercentagePayment { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("status_date", TypeName = "datetime")]
        public DateTime? StatusDate { get; set; }
    }
}
