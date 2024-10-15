using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
{
    [Table("LeaveTypePolicyMaster")]
    public partial class LeaveTypePolicyMaster
    {
        [Key]
        [Column("LeaveTypePolicyID")]
        public Guid LeaveTypePolicyId { get; set; }
        [Column("LeaveTypeID")]
        public Guid? LeaveTypeId { get; set; }
        [StringLength(50)]
        public string? LeaveGroup { get; set; }
        [StringLength(250)]
        public string? Conditions { get; set; }
        [StringLength(50)]
        public string? Comparisions { get; set; }
        [StringLength(50)]
        public string? Periodics { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? FromValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ToValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Days { get; set; }
        public bool? IsConsider { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Percentage { get; set; }
    }
}
