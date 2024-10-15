using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("LeaveMoneyMaster")]
    public partial class LeaveMoneyMaster
    {
        [Key]
        [Column("LeaveMoneyID")]
        public Guid LeaveMoneyId { get; set; }
        [Column("FinancialYearID")]
        public Guid? FinancialYearId { get; set; }
        [Column("EmployeeID")]
        public Guid? EmployeeId { get; set; }
        [StringLength(150)]
        public string? Months { get; set; }
        [StringLength(50)]
        public string? Years { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? HourlyRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BasicSalary { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LeaveBalanceDay { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? LeaveBalanceHour { get; set; }
    }
}
