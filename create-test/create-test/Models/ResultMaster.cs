using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Result_Master")]
    public partial class ResultMaster
    {
        public ResultMaster()
        {
            Results = new HashSet<Result>();
        }

        [Key]
        [Column("Result_ID")]
        public int ResultId { get; set; }
        [Column("Week_Num")]
        public int? WeekNum { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column("Entry_By")]
        [StringLength(50)]
        public string? EntryBy { get; set; }
        [Column("Entry_Date", TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("Allow_Edit")]
        public bool? AllowEdit { get; set; }
        [Column("Allow_Start_Date", TypeName = "datetime")]
        public DateTime? AllowStartDate { get; set; }
        [Column("Allow_By")]
        [StringLength(150)]
        public string? AllowBy { get; set; }
        [StringLength(500)]
        public string? Remark { get; set; }
        [Column("Allow_End_Date", TypeName = "datetime")]
        public DateTime? AllowEndDate { get; set; }
        [Column("End_Date", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
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
        public bool? Cancel { get; set; }
        [Column("Cancel_By")]
        [StringLength(150)]
        [Unicode(false)]
        public string? CancelBy { get; set; }
        [Column("Cancel_Date", TypeName = "datetime")]
        public DateTime? CancelDate { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        [Column("RemarkQC1")]
        [StringLength(500)]
        public string? RemarkQc1 { get; set; }
        [Column("RemarkQC2")]
        [StringLength(500)]
        public string? RemarkQc2 { get; set; }
        [Column("Zone_ID")]
        public int? ZoneId { get; set; }

        [InverseProperty("ResultNavigation")]
        public virtual ICollection<Result> Results { get; set; }
    }
}
