using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("GoodReceivedReturn")]
    public partial class GoodReceivedReturn
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("photo")]
        [StringLength(250)]
        public string? Photo { get; set; }
        [Column("reference_no")]
        [StringLength(250)]
        public string? ReferenceNo { get; set; }
        [Column("grn_no")]
        [StringLength(250)]
        public string? GrnNo { get; set; }
        [Column("transaction_date", TypeName = "date")]
        public DateTime? TransactionDate { get; set; }
        [Column("supplier")]
        [StringLength(100)]
        public string? Supplier { get; set; }
        [Column("descriptions")]
        [StringLength(250)]
        public string? Descriptions { get; set; }
        [Column("warehouse")]
        [StringLength(250)]
        public string? Warehouse { get; set; }
        [Column("grn_date", TypeName = "date")]
        public DateTime? GrnDate { get; set; }
        [Column("transaction_no")]
        [StringLength(250)]
        public string? TransactionNo { get; set; }
    }
}
