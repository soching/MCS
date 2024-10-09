using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Delay")]
    public partial class Delay
    {
        [Key]
        [Column("Delay_ID")]
        public int DelayId { get; set; }
        [Column("Delay_Date", TypeName = "datetime")]
        public DateTime? DelayDate { get; set; }
        [StringLength(500)]
        public string? Note { get; set; }
        [Column("Complain_ID")]
        public int ComplainId { get; set; }
        [Column("Is_Delay")]
        public bool? IsDelay { get; set; }
        [Column("Request_By")]
        public int? RequestBy { get; set; }
        [Column("Approve_By")]
        public int? ApproveBy { get; set; }
        [Column("Approve_Date", TypeName = "datetime")]
        public DateTime? ApproveDate { get; set; }
    }
}
