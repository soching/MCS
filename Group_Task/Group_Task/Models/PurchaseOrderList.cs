using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Model
{
    [Table("Purchase_Order_List")]
    public partial class PurchaseOrderList
    {
        [Key]
        [Column("Orderlist_Id")]
        public int OrderlistId { get; set; }
        [Column("P_O_Number")]
        [StringLength(100)]
        public string? PONumber { get; set; }
        [Column("P_R_Number")]
        [StringLength(100)]
        public string? PRNumber { get; set; }
        [Column("P_O_Date", TypeName = "datetime")]
        public DateTime PODate { get; set; }
        [Column("Schedule_Date", TypeName = "datetime")]
        public DateTime ScheduleDate { get; set; }
        [Column("Approved_Date")]
        [StringLength(50)]
        public string? ApprovedDate { get; set; }
        [Column("Item_Type")]
        [StringLength(500)]
        public string? ItemType { get; set; }
        [Column("Sub_Total")]
        [StringLength(50)]
        public string? SubTotal { get; set; }
        [StringLength(50)]
        public string? Discount { get; set; }
        [StringLength(50)]
        public string? Tax { get; set; }
        [StringLength(50)]
        public string? Deposit { get; set; }
        [Column("Grand_Total")]
        [StringLength(50)]
        public string? GrandTotal { get; set; }
        [StringLength(50)]
        public string? Status { get; set; }
        [StringLength(100)]
        public string? Attachment { get; set; }
        [Column("Create_by")]
        [StringLength(50)]
        public string? CreateBy { get; set; }
    }
}
