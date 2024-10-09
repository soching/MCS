using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Keyless]
    public partial class PaymentReport
    {
        [Column("Payroll_ID")]
        public int PayrollId { get; set; }
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        [Column("Constructor_Code")]
        [StringLength(50)]
        public string? ConstructorCode { get; set; }
        [Column("Constructor_Name")]
        [StringLength(150)]
        public string? ConstructorName { get; set; }
        [Column("Task_Code")]
        [StringLength(250)]
        public string? TaskCode { get; set; }
        [Column("Task_ID")]
        public int TaskId { get; set; }
        [Column("House_ID")]
        public int HouseId { get; set; }
        [Column("Salary_Amount", TypeName = "decimal(18, 3)")]
        public decimal? SalaryAmount { get; set; }
        [Column("Payroll_Date", TypeName = "datetime")]
        public DateTime? PayrollDate { get; set; }
        [Column("Is_Paid")]
        public int? IsPaid { get; set; }
        [Column("Advance_Paid")]
        public int? AdvancePaid { get; set; }
        [Column("Result_Detail_ID")]
        [StringLength(500)]
        [Unicode(false)]
        public string? ResultDetailId { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        [Column("Payment_Method")]
        [StringLength(50)]
        public string? PaymentMethod { get; set; }
        [StringLength(350)]
        public string? Remark { get; set; }
        [Column("Task_Master_ID")]
        public int? TaskMasterId { get; set; }
        [Column("Issue_Date", TypeName = "datetime")]
        public DateTime? IssueDate { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? RetentionAmount { get; set; }
        [Column("Total_Amount", TypeName = "decimal(18, 3)")]
        public decimal? TotalAmount { get; set; }
        [Column("LOA_Amount", TypeName = "decimal(18, 4)")]
        public decimal? LoaAmount { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Retention { get; set; }
        [Column("loa", TypeName = "decimal(18, 4)")]
        public decimal? Loa { get; set; }
        [Column("Task_Name")]
        [StringLength(250)]
        public string? TaskName { get; set; }
        [Column("LOA_CODE")]
        [StringLength(100)]
        public string? LoaCode { get; set; }
        [Column("Project_Name")]
        [StringLength(200)]
        public string? ProjectName { get; set; }
        [Column("Zone_Name")]
        [StringLength(150)]
        public string? ZoneName { get; set; }
        [Column("House_Type_Name")]
        [StringLength(250)]
        public string? HouseTypeName { get; set; }
        [Column("Block_No")]
        [StringLength(200)]
        public string? BlockNo { get; set; }
        [Column("Building_No")]
        [StringLength(200)]
        public string? BuildingNo { get; set; }
        [Column("Street_No")]
        [StringLength(200)]
        public string? StreetNo { get; set; }
        [Column("House_No")]
        [StringLength(200)]
        public string? HouseNo { get; set; }
        [Column("Paid_by")]
        [StringLength(350)]
        public string? PaidBy { get; set; }
        [Column("times")]
        [StringLength(4000)]
        public string? Times { get; set; }
        [Column("Remaining_Amount", TypeName = "decimal(20, 4)")]
        public decimal? RemainingAmount { get; set; }
        [Column("claim_percentage", TypeName = "decimal(38, 15)")]
        public decimal? ClaimPercentage { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Zone_ID")]
        public int? ZoneId { get; set; }
        [Column("House_Type_ID")]
        public int HouseTypeId { get; set; }
    }
}
