using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Keyless]
    public partial class PenaltyReport
    {
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        [Column("Constructor_Name")]
        [StringLength(150)]
        public string? ConstructorName { get; set; }
        [Column("Constructor_Code")]
        [StringLength(100)]
        public string? ConstructorCode { get; set; }
        [Column("item_id")]
        [StringLength(11)]
        [Unicode(false)]
        public string? ItemId { get; set; }
        [Column("issue_date", TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        [Column("invoice_no")]
        [StringLength(13)]
        [Unicode(false)]
        public string InvoiceNo { get; set; } = null!;
        [Column("block_no")]
        [StringLength(50)]
        public string? BlockNo { get; set; }
        [Column("house_no")]
        [StringLength(50)]
        public string? HouseNo { get; set; }
        [Column("item_code")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ItemCode { get; set; }
        [Column("name")]
        [StringLength(500)]
        public string? Name { get; set; }
        [Column("mou")]
        [StringLength(150)]
        public string? Mou { get; set; }
        [Column("price", TypeName = "decimal(18, 2)")]
        public decimal? Price { get; set; }
        [Column("status")]
        public bool? Status { get; set; }
        [Column("remark")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Remark { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("over_qty")]
        public int? OverQty { get; set; }
        [Column("unit_price", TypeName = "decimal(10, 2)")]
        public decimal? UnitPrice { get; set; }
        [Column("category_id")]
        public int? CategoryId { get; set; }
    }
}
