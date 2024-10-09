using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("HistoryFol")]
    public partial class HistoryFol
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("lead_id")]
        public int? LeadId { get; set; }
        [Column("follow_date", TypeName = "datetime")]
        public DateTime? FollowDate { get; set; }
        [Column("comment")]
        [StringLength(500)]
        public string? Comment { get; set; }
        [Column("seller_name")]
        [StringLength(50)]
        public string? SellerName { get; set; }
        [Column("result")]
        [StringLength(500)]
        public string? Result { get; set; }
        [Column("alert_date", TypeName = "datetime")]
        public DateTime? AlertDate { get; set; }
    }
}
