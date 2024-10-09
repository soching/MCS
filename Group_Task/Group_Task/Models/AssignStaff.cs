using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Group_Task.Models
{
    [Table("AssignStaff")]
    public partial class AssignStaff
    {
        [Key]
        [Column("Assign_Staff_ID")]
        public int AssignStaffId { get; set; }
        [Column("Supervisor_ID")]
        public int SupervisorId { get; set; }
        [Column("Constructor_ID")]
        public int ConstructorId { get; set; }
        [Column("Project_ID")]
        public int? ProjectId { get; set; }
        [Column("Department_ID")]
        public int? DepartmentId { get; set; }
    }
}
