using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("Payroll")]
    public partial class Payroll
    {
        [Key]
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
    }
}
