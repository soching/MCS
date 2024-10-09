using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("LeaveBalanceMaster")]
    public partial class LeaveBalanceMaster
    {
        [Key]
        [Column("LeaveBalanceID")]
        public Guid LeaveBalanceId { get; set; }
        [Column("LeaveTypeID")]
        public Guid? LeaveTypeId { get; set; }
        [Column("LeaveTypePolicyID")]
        public Guid? LeaveTypePolicyId { get; set; }
        [Column("FinancialYearID")]
        public Guid? FinancialYearId { get; set; }
        [Column("EmployeeID")]
        public Guid? EmployeeId { get; set; }
        [StringLength(50)]
        public string? LeaveGroup { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? BeginBalance { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? EndBalance { get; set; }
    }
}
