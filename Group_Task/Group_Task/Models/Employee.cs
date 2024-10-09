using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [Column("Employee_ID")]
        public int EmployeeId { get; set; }
        [Column("Employee_Name")]
        [StringLength(500)]
        public string? EmployeeName { get; set; }
        [StringLength(50)]
        public string? Gender { get; set; }
        [StringLength(100)]
        public string? Position { get; set; }
        [Column("Employee_No")]
        [StringLength(50)]
        [Unicode(false)]
        public string? EmployeeNo { get; set; }
        [Column("Working_Type")]
        [StringLength(50)]
        [Unicode(false)]
        public string? WorkingType { get; set; }
        [Column("Employee_Status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? EmployeeStatus { get; set; }
        public int? Printed { get; set; }
        [StringLength(500)]
        public string? Photo { get; set; }
    }
}
