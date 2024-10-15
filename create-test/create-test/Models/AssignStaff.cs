using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using create_test.Models;
using Microsoft.EntityFrameworkCore;

namespace create_test.Models
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
