using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    public partial class Result
    {
        [Key]
        [Column("Result_Detail_ID")]
        public long ResultDetailId { get; set; }
        [Column("Constructor_ID")]
        public int? ConstructorId { get; set; }
        [Column("Constructor_Code")]
        [StringLength(100)]
        public string? ConstructorCode { get; set; }
        [Column("Result_ID")]
        public int ResultId { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column("Standard_Date", TypeName = "decimal(18, 2)")]
        public decimal? StandardDate { get; set; }
        [Column("Result_Saturday", TypeName = "decimal(18, 3)")]
        public decimal? ResultSaturday { get; set; }
        [Column("Builder_Num0")]
        public int? BuilderNum0 { get; set; }
        [Column("Cleaning_Saturday")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CleaningSaturday { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Price { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 4)")]
        public decimal? TotalAmount { get; set; }
        [Column("Cleaning_Result")]
        [StringLength(50)]
        public string? CleaningResult { get; set; }
        [Column("Total_Quantity", TypeName = "decimal(18, 4)")]
        public decimal? TotalQuantity { get; set; }
        [Column("Entry_Date", TypeName = "datetime")]
        public DateTime? EntryDate { get; set; }
        [Column("Entry_By")]
        [StringLength(150)]
        public string? EntryBy { get; set; }
        [Column("Employee_ID")]
        public int? EmployeeId { get; set; }
        [Column("Setup_Task_ID")]
        public int? SetupTaskId { get; set; }
        [Column("Is_Paid")]
        public int? IsPaid { get; set; }
        [Column("Cash_Advance", TypeName = "decimal(18, 3)")]
        public decimal? CashAdvance { get; set; }
        [Column("Task_Code")]
        [StringLength(50)]
        public string? TaskCode { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Barrel { get; set; }
        [StringLength(50)]
        public string? Measure { get; set; }
        [Column("Allow_Over_Barrel")]
        public bool? AllowOverBarrel { get; set; }
        [StringLength(500)]
        public string? Note { get; set; }
        [Unicode(false)]
        public string? Photo { get; set; }
        [Column("Payroll_Date", TypeName = "datetime")]
        public DateTime? PayrollDate { get; set; }
        [Column("Setup_ID")]
        public int? SetupId { get; set; }
        public bool? Approve1 { get; set; }
        [Column("Approve1_By")]
        [StringLength(50)]
        public string? Approve1By { get; set; }
        [Column("Approve1_date", TypeName = "datetime")]
        public DateTime? Approve1Date { get; set; }
        public bool? Approve2 { get; set; }
        [Column("Approve2_By")]
        [StringLength(50)]
        public string? Approve2By { get; set; }
        public bool? Approve3 { get; set; }
        [Column("Approve3_By")]
        [StringLength(50)]
        public string? Approve3By { get; set; }
        public bool? Approve4 { get; set; }
        [Column("Approve4_By")]
        [StringLength(50)]
        public string? Approve4By { get; set; }
        [Column("Allow_Over_Barrel_By")]
        [StringLength(50)]
        public string? AllowOverBarrelBy { get; set; }
        public bool? Approve5 { get; set; }
        [Column("Approve5_By")]
        [StringLength(50)]
        public string? Approve5By { get; set; }
        public bool? Approve6 { get; set; }
        [Column("Approve6_By")]
        [StringLength(50)]
        public string? Approve6By { get; set; }
        public bool? Approve7 { get; set; }
        [Column("Approve7_By")]
        [StringLength(50)]
        public string? Approve7By { get; set; }
        public bool? Approve8 { get; set; }
        [Column("Approve8_By")]
        [StringLength(50)]
        public string? Approve8By { get; set; }
        [Column("Image_Path")]
        [StringLength(500)]
        [Unicode(false)]
        public string? ImagePath { get; set; }
        [StringLength(500)]
        public string? FloorName { get; set; }
        [Column("Process_By")]
        [StringLength(150)]
        public string? ProcessBy { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? PaidAmount { get; set; }
        [Column("old_data")]
        public bool? OldData { get; set; }
        [Column("Approve2_date", TypeName = "datetime")]
        public DateTime? Approve2Date { get; set; }
        [Column("Approve3_date", TypeName = "datetime")]
        public DateTime? Approve3Date { get; set; }
        [Column("Approve4_date", TypeName = "datetime")]
        public DateTime? Approve4Date { get; set; }
        [Column("Approve_qc1")]
        public int? ApproveQc1 { get; set; }
        [Column("Approve_qc1_By")]
        [StringLength(50)]
        public string? ApproveQc1By { get; set; }
        [Column("Approve_qc1_date", TypeName = "datetime")]
        public DateTime? ApproveQc1Date { get; set; }
        [Column("Approve_qc2")]
        public int? ApproveQc2 { get; set; }
        [Column("Approve_qc2_By")]
        [StringLength(50)]
        public string? ApproveQc2By { get; set; }
        [Column("Approve_qc2_date", TypeName = "datetime")]
        public DateTime? ApproveQc2Date { get; set; }
        public int? Assistant { get; set; }
        [Column("Assistant_By")]
        [StringLength(50)]
        public string? AssistantBy { get; set; }
        [Column("Assistant_date", TypeName = "datetime")]
        public DateTime? AssistantDate { get; set; }
        [Column("Assistant_Remark")]
        [StringLength(50)]
        public string? AssistantRemark { get; set; }
        [Column("counter")]
        public int? Counter { get; set; }
        [Column("Approve_Status")]
        public int? ApproveStatus { get; set; }
        [Column("Is_Require")]
        public int? IsRequire { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Percentage { get; set; }
        [Column("Process_Date", TypeName = "datetime")]
        public DateTime? ProcessDate { get; set; }
        [Column("Constructor_Name")]
        [StringLength(150)]
        public string? ConstructorName { get; set; }
        [Column("Type_amount")]
        public int? TypeAmount { get; set; }
        [Column("task_object_id")]
        public int? TaskObjectId { get; set; }
        [Column("RemarkQC1")]
        [StringLength(500)]
        public string? RemarkQc1 { get; set; }
        [Column("RemarkQC2")]
        [StringLength(500)]
        public string? RemarkQc2 { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? ReceiveAmount { get; set; }
        [Column("LOA_Per", TypeName = "decimal(18, 4)")]
        public decimal? LoaPer { get; set; }
        [Column("Supervisor_ID")]
        public int? SupervisorId { get; set; }
        [Column("Approved5_Date", TypeName = "datetime")]
        public DateTime? Approved5Date { get; set; }
        [Column("Approved6_Date", TypeName = "datetime")]
        public DateTime? Approved6Date { get; set; }
        [Column("Approved7_Date", TypeName = "datetime")]
        public DateTime? Approved7Date { get; set; }
        [Column("Result_Percentage", TypeName = "decimal(18, 4)")]
        public decimal? ResultPercentage { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? RetentionAmount { get; set; }
        public bool? RetentionPaid { get; set; }
        [StringLength(50)]
        public string? TransactionNum { get; set; }
        [Column("Actual_Progress", TypeName = "decimal(18, 4)")]
        public decimal? ActualProgress { get; set; }
        [Column("Barrel_Amount", TypeName = "decimal(18, 4)")]
        public decimal? BarrelAmount { get; set; }

        [ForeignKey("ResultId")]
        [InverseProperty("Results")]
        public virtual ResultMaster ResultNavigation { get; set; } = null!;
    }
}
