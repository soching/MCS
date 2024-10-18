using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("BoqWorkingType")]
    public partial class BoqWorkingType
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("boq_no")]
        [StringLength(250)]
        public string? BoqNo { get; set; }
        [Column("zones")]
        [StringLength(50)]
        public string? Zones { get; set; }
        [Column("blocks")]
        [StringLength(50)]
        public string? Blocks { get; set; }
        [Column("building")]
        [StringLength(100)]
        public string? Building { get; set; }
        [Column("house")]
        [StringLength(250)]
        public string? House { get; set; }
        [Column("working_type")]
        [StringLength(250)]
        public string? WorkingType { get; set; }
        [Column("amount")]
        [StringLength(250)]
        public string? Amount { get; set; }
        [Column("transaction_data", TypeName = "datetime")]
        public DateTime? TransactionData { get; set; }
        [Column("trans_by")]
        [StringLength(50)]
        public string? TransBy { get; set; }
        [Column("trans_ref")]
        [StringLength(50)]
        public string? TransRef { get; set; }
        [Column("reference")]
        [StringLength(100)]
        public string? Reference { get; set; }
        [Column("boq_status")]
        [StringLength(50)]
        public string? BoqStatus { get; set; }
        [Column("revise_count")]
        [StringLength(250)]
        public string? ReviseCount { get; set; }
    }
}
