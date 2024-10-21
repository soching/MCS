using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Model
{
    [Table("Purchase_Request_List")]
    public partial class PurchaseRequestList
    {
        [Key]
        [Column("Requestlist_Id")]
        public int RequestlistId { get; set; }
        [Column("P_R_Number")]
        [StringLength(100)]
        public string? PRNumber { get; set; }
        [Column("Item_Type")]
        [StringLength(500)]
        public string? ItemType { get; set; }
        [Column("P_R_Date", TypeName = "datetime")]
        public DateTime PRDate { get; set; }
        [Column("Approved_Date")]
        [StringLength(50)]
        public string? ApprovedDate { get; set; }
        [Column("Schedule_Date", TypeName = "datetime")]
        public DateTime ScheduleDate { get; set; }
        [Column("Request_by")]
        [StringLength(50)]
        public string? RequestBy { get; set; }
        [StringLength(100)]
        public string? Department { get; set; }
        [StringLength(50)]
        public string? Status { get; set; }
        public string? Note { get; set; }
        [StringLength(100)]
        public string? Attachment { get; set; }
    }
}
