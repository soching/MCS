using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Result_Action")]
    public partial class ResultAction
    {
        [Key]
        [Column("Result_Action_ID")]
        public int ResultActionId { get; set; }
        [Column("Result_ID")]
        public int ResultId { get; set; }
        [Column("Entry_By")]
        [StringLength(50)]
        public string? EntryBy { get; set; }
        [Column("Entry_Date", TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        public bool? AllowApprove1 { get; set; }
        [Column("AllowApprove1_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? AllowApprove1By { get; set; }
        [Column("AllowApprove1_Date", TypeName = "datetime")]
        public DateTime? AllowApprove1Date { get; set; }
        public bool? AllowApprove2 { get; set; }
        [Column("AllowApprove2_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? AllowApprove2By { get; set; }
        [Column("AllowApprove2_Date", TypeName = "datetime")]
        public DateTime? AllowApprove2Date { get; set; }
        public bool? AllowApprove3 { get; set; }
        [Column("AllowApprove3_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? AllowApprove3By { get; set; }
        [Column("AllowApprove3_Date", TypeName = "datetime")]
        public DateTime? AllowApprove3Date { get; set; }
        public bool? AllowApprove4 { get; set; }
        [Column("AllowApprove4_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? AllowApprove4By { get; set; }
        [Column("AllowApprove4_Date", TypeName = "datetime")]
        public DateTime? AllowApprove4Date { get; set; }
        public bool? AllowApprove5 { get; set; }
        [Column("AllowApprove5_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? AllowApprove5By { get; set; }
        [Column("AllowApprove5_Date", TypeName = "datetime")]
        public DateTime? AllowApprove5Date { get; set; }
        public bool? AllowApprove6 { get; set; }
        [Column("AllowApprove6_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? AllowApprove6By { get; set; }
        [Column("AllowApprove6_Date", TypeName = "datetime")]
        public DateTime? AllowApprove6Date { get; set; }
        public bool? AllowApprove7 { get; set; }
        [Column("AllowApprove7_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? AllowApprove7By { get; set; }
        [Column("AllowApprove7_Date", TypeName = "datetime")]
        public DateTime? AllowApprove7Date { get; set; }
        public bool? Deleted { get; set; }
        [Column("Deleted_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? DeletedBy { get; set; }
        [Column("Deleted_Date", TypeName = "datetime")]
        public DateTime? DeletedDate { get; set; }
    }
}
