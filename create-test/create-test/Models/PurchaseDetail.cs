using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Purchase_Detail")]
    public partial class PurchaseDetail
    {
        [Key]
        [Column("Purchase_Detail_ID")]
        public int PurchaseDetailId { get; set; }
        [Column("Purchase_ID")]
        public int PurchaseId { get; set; }
        [Column("Item_ID")]
        public int ItemId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Qty { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("Account_ID")]
        public int AccountId { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        [Column("Shift_No")]
        public int? ShiftNo { get; set; }
    }
}
