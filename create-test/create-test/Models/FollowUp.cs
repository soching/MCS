using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("FollowUp")]
    public partial class FollowUp
    {
        [Key]
        [Column("FollowUp_ID")]
        public int FollowUpId { get; set; }
        [Column("FollowUp_Date", TypeName = "datetime")]
        public DateTime? FollowUpDate { get; set; }
        [StringLength(500)]
        public string? Result { get; set; }
        [Column("Complain_ID")]
        public int? ComplainId { get; set; }
        [Column("FollowUp_By")]
        public int? FollowUpBy { get; set; }
        [StringLength(250)]
        public string? Source { get; set; }
        [StringLength(250)]
        public string? Purpose { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? PurchasePower { get; set; }
        [StringLength(300)]
        public string? AttractReason { get; set; }
        [StringLength(300)]
        public string? CurrentAddress { get; set; }
        [StringLength(250)]
        public string? Action { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextDate { get; set; }
        public string? Feedback { get; set; }
        [StringLength(250)]
        public string? KnowUs { get; set; }
        [Column("LeadID")]
        public int? LeadId { get; set; }
        [Column("seller_name")]
        [StringLength(250)]
        public string? SellerName { get; set; }
        [StringLength(250)]
        public string? OtherSource { get; set; }
    }
}
