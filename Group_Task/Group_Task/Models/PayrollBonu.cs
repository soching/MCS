using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    public partial class PayrollBonu
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
        [StringLength(50)]
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
        [Column("Res_HouseAutonum")]
        [StringLength(500)]
        [Unicode(false)]
        public string ResHouseAutonum { get; set; } = null!;
        [Column("supervisor", TypeName = "decimal(18, 3)")]
        public decimal? Supervisor { get; set; }
        [Column("supervisor1", TypeName = "decimal(18, 3)")]
        public decimal? Supervisor1 { get; set; }
        [Column("supervisor2", TypeName = "decimal(18, 3)")]
        public decimal? Supervisor2 { get; set; }
        [Column("Scores_Over", TypeName = "decimal(18, 3)")]
        public decimal? ScoresOver { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? Scores { get; set; }
        public bool? Approve1 { get; set; }
        [Column("Approve1_By")]
        [StringLength(50)]
        public string? Approve1By { get; set; }
        public bool? Approve2 { get; set; }
        [Column("Approve2_By")]
        [StringLength(50)]
        public string? Approve2By { get; set; }
    }
}
