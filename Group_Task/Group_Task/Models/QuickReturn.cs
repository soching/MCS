using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("QuickReturn")]
    public partial class QuickReturn
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("reference_no")]
        [StringLength(250)]
        public string? ReferenceNo { get; set; }
        [Column("transaction_date", TypeName = "date")]
        public DateTime? TransactionDate { get; set; }
        [Column("reference")]
        [StringLength(250)]
        public string? Reference { get; set; }
        [Column("engineer")]
        [StringLength(100)]
        public string? Engineer { get; set; }
        [Column("subcontractor")]
        [StringLength(100)]
        public string? Subcontractor { get; set; }
        [Column("descriptions")]
        [StringLength(250)]
        public string? Descriptions { get; set; }
    }
}
