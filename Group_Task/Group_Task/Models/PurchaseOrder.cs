using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("PurchaseOrder")]
    public partial class PurchaseOrder
    {
        [Key]
        [Column("Order_Id")]
        public int OrderId { get; set; }
        [Column("Po_No")]
        [StringLength(50)]
        public string PoNo { get; set; } = null!;
        [Column("Po_Date", TypeName = "datetime")]
        public DateTime PoDate { get; set; }
        [Column("Item_Type")]
        [StringLength(100)]
        public string ItemType { get; set; } = null!;
        [Column("GRN_Address")]
        [StringLength(100)]
        public string GrnAddress { get; set; } = null!;
        [StringLength(100)]
        public string Suppliers { get; set; } = null!;
        [Column("Order_By")]
        [StringLength(50)]
        public string OrderBy { get; set; } = null!;
        [Column("P_R_Numbers")]
        [StringLength(50)]
        public string PRNumbers { get; set; } = null!;
        [Column("Terms_of_Payment")]
        [StringLength(100)]
        public string TermsOfPayment { get; set; } = null!;
        [StringLength(50)]
        public string Status { get; set; } = null!;

        public string Note { get; set; } = null!;
    }
}

