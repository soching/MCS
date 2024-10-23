using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("StockEntry")]
    public partial class StockEntry
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("reference_no")]
        [StringLength(250)]
        public string? ReferenceNo { get; set; }
        [Column("transaction_date", TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        [Column("supplier")]
        [StringLength(100)]
        public string? Supplier { get; set; }
        [Column("descriptions")]
        [StringLength(250)]
        public string? Descriptions { get; set; }
    }
}
