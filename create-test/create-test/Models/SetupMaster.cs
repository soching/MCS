using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Setup_Master")]
    public partial class SetupMaster
    {
        public SetupMaster()
        {
            SetupFloors = new HashSet<SetupFloor>();
        }

        [Key]
        [Column("Setup_Master_ID")]
        public int SetupMasterId { get; set; }
        [Column("House_Type_ID")]
        public int HouseTypeId { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        [Column("House_ID")]
        public int? HouseId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Unit { get; set; }
        [Column("Barrel_Type")]
        public int? BarrelType { get; set; }
        public int? Approve1 { get; set; }
        public int? Approve2 { get; set; }
        public int? Approve3 { get; set; }
        public int? Approve4 { get; set; }
        public int? Approve5 { get; set; }
        [Column("Created_By")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [StringLength(250)]
        public string? Remark { get; set; }
        [Column("Reject_Date", TypeName = "datetime")]
        public DateTime? RejectDate { get; set; }
        public int? Canceled { get; set; }
        [Column("Canceled_By")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CanceledBy { get; set; }
        [Column("Approve1_By")]
        [StringLength(250)]
        public string? Approve1By { get; set; }
        [Column("Approve1_Date", TypeName = "datetime")]
        public DateTime? Approve1Date { get; set; }
        [Column("Approve2_By")]
        [StringLength(250)]
        public string? Approve2By { get; set; }
        [Column("Approve2_Date", TypeName = "datetime")]
        public DateTime? Approve2Date { get; set; }
        [StringLength(250)]
        public string? Remark1 { get; set; }
        [StringLength(250)]
        public string? Remark2 { get; set; }
        [StringLength(250)]
        public string? Remark3 { get; set; }
        [StringLength(250)]
        public string? Remark4 { get; set; }
        [StringLength(250)]
        public string? Remark5 { get; set; }
        [Column("Approve3_By")]
        [StringLength(50)]
        public string? Approve3By { get; set; }
        [Column("Approve4_By")]
        [StringLength(50)]
        public string? Approve4By { get; set; }
        [Column("Approve5_By")]
        [StringLength(50)]
        public string? Approve5By { get; set; }
        [Column("Approve3_Date", TypeName = "datetime")]
        public DateTime? Approve3Date { get; set; }
        [Column("Approve4_Date", TypeName = "datetime")]
        public DateTime? Approve4Date { get; set; }
        [Column("Approve5_Date", TypeName = "datetime")]
        public DateTime? Approve5Date { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        public int? Unused { get; set; }
        [StringLength(250)]
        public string? Layout { get; set; }
        [Column("Zone_ID")]
        public int? ZoneId { get; set; }
        public int? ApproveAcc { get; set; }
        [Column("ApproveAcc_Date", TypeName = "datetime")]
        public DateTime? ApproveAccDate { get; set; }
        [StringLength(250)]
        public string? RemarkAcc { get; set; }
        [Column("ApproveAcc_By")]
        [StringLength(50)]
        public string? ApproveAccBy { get; set; }
        [Column("boq_code")]
        [StringLength(500)]
        public string? BoqCode { get; set; }
        public int? ApproveFin { get; set; }
        [Column("ApproveFin_Date", TypeName = "datetime")]
        public DateTime? ApproveFinDate { get; set; }
        [StringLength(250)]
        public string? RemarkFin { get; set; }
        [Column("ApproveFin_By")]
        [StringLength(50)]
        public string? ApproveFinBy { get; set; }
        [Column("LOA_CODE")]
        [StringLength(100)]
        public string? LoaCode { get; set; }
        [Column("created_date", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? TotalAmount { get; set; }
        [Column("constructor_id")]
        public int? ConstructorId { get; set; }
        [Column("supervisor_id")]
        public int? SupervisorId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Retention { get; set; }
        [Column("Start_Date", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column("End_Date", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [Column("LOA_Amount", TypeName = "decimal(18, 4)")]
        public decimal? LoaAmount { get; set; }
        [Column("loa", TypeName = "decimal(18, 4)")]
        public decimal? Loa { get; set; }
        [Column("status")]
        public bool? Status { get; set; }
        [Column("comment")]
        [StringLength(500)]
        public string? Comment { get; set; }
        [Column("attached_file")]
        [StringLength(250)]
        public string? AttachedFile { get; set; }
        [StringLength(50)]
        public string? Worker { get; set; }
        [Column("Payment_Term")]
        public int? PaymentTerm { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Penalty { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Deposit { get; set; }
        [Column("Group_House_ID", TypeName = "ntext")]
        public string? GroupHouseId { get; set; }
        [Column("BoQ_Master_ID")]
        public int? BoQMasterId { get; set; }
        [Column("loa_no")]
        [StringLength(50)]
        public string? LoaNo { get; set; }

        [InverseProperty("SetupMaster")]
        public virtual ICollection<SetupFloor> SetupFloors { get; set; }
    }
}
